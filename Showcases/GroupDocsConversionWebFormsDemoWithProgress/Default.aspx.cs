using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Linq;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;
using System.Threading;

namespace GroupDocsConversionWebFormsDemoWithProgress
{
    public partial class Default : System.Web.UI.Page
    {
        public string inputGUIDFile = "DOCXsample.docx";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                labelFailed.Visible = false;
                labelFailed.InnerHtml = "Conversion failed";
                if (!Page.IsPostBack)
                {
                    ConversionHandler conversionHandler = new ConversionHandler(new ConversionConfig());
                    var availableConversions = conversionHandler.GetSaveOptions(Path.GetExtension(inputGUIDFile).Replace(".", ""));
                    ddlOutputTypes.Items.Add(new ListItem("Select Output File Type", "-1"));
                    foreach (var outputTypes in availableConversions)
                    {
                        ddlOutputTypes.Items.Add(new ListItem(outputTypes.Key.ToUpperInvariant(), outputTypes.Key));
                    }
                }
            }
            catch (Exception exc)
            {
                labelFailed.Visible = true;
                labelFailed.InnerHtml = exc.Message;
            }
        }

        protected void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                labelFailed.Visible = false;
                labelCompleted.Visible = false;

                ConversionConfig conversionConfig = new ConversionConfig { StoragePath = Server.MapPath("~/App_Data/"), CachePath = Server.MapPath("~/App_Data/output/") };
                ConversionHandler conversionHandler = new ConversionHandler(conversionConfig);
                conversionHandler.ConversionProgress += ConversionProgressHandler;

                // Apply GroupDocs.Conversion license using license path provided/set in licensePath property
                //model.licensePath = Server.MapPath("~/App_Data/");
                //conversionHandler.SetLicense(model.licensePath);

                var saveOptions = conversionHandler.GetSaveOptions(ddlOutputTypes.SelectedValue)[ddlOutputTypes.SelectedValue];
                saveOptions.OutputType = OutputType.String;

                var convertResults = conversionHandler.Convert<String>(inputGUIDFile, saveOptions);

                if (convertResults == null)
                {
                    convertResults = conversionHandler.Convert<List<string>>(inputGUIDFile, saveOptions)[0];
                }

                Download(convertResults, ddlOutputTypes.SelectedValue);
                labelCompleted.Visible = true;
                ClientScript.RegisterStartupScript(this.GetType(), "hideProgress", "hideProgress();", true);
            }
            catch (Exception exc)
            {
                labelFailed.Visible = true;
                labelFailed.InnerHtml = exc.Message;
            }
        }
        [System.Web.Services.WebMethod]
        public static string GetText()
        {
            for (int i = 0; i < 10; i++)
            {
                // In actual projects this action may be a database operation.   
                //For demsonstration I have made this loop to sleep.   
                Thread.Sleep(2600);
            }
            return "Download Complete...";
        }
        private void ConversionProgressHandler(object sender, ConversionProgressEventArgs args)
        {
            progressLabel.Text = args.Progress.ToString() + "% Converted.";
            ClientScript.RegisterStartupScript(this.GetType(), "showProgress", "showProgress(" + args.Progress.ToString() + ");", true);
        }

        private void Download(string outputFileName, string outputfileType)
        {
            var response = System.Web.HttpContext.Current.Response;
            response.ClearContent();
            response.Clear();
            response.ContentType = outputfileType;
            response.AddHeader("Content-Disposition", "attachment; filename=" + outputfileType + ";");
            response.TransmitFile(outputFileName);
            response.Flush();
            response.End();
        }

    }
}