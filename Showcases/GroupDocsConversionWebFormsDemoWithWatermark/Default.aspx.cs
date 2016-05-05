using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;

namespace GroupDocsConversionWebFormsDemoWithWatermark
{
    public partial class _Default : Page
    {
        // your input file to be converted
        private string inputFileName = "sample.pdf";

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = string.Format("Input file: {0}", inputFileName);
        }

        protected void ConvertCommand(object sender, CommandEventArgs e)
        {
            ConversionConfig conversionConfig = new ConversionConfig { StoragePath = Server.MapPath("~/App_Data/"), CachePath = Server.MapPath("~/App_Data/") };
            ConversionHandler conversionHandler = new ConversionHandler(conversionConfig);

            // Apply GroupDocs.Conversion license using license path provided/set in licensePath property
            //model.licensePath = Server.MapPath("~/App_Data/");
            //conversionHandler.SetLicense(model.licensePath);

            string outputFile = "converted\\SampleConverted." + e.CommandArgument.ToString();

            string convertResult = "";

            try
            {
                // Watermark Options object
                WatermarkOptions watermarkOptions = new WatermarkOptions(textboxWatermarkText.Text.Trim());
                watermarkOptions.Color = Color.Blue;
                watermarkOptions.Font = new Font("Arial", 45);
                watermarkOptions.RotationAngle = 65;
                watermarkOptions.Transparency = 0.4;
                watermarkOptions.Left = 20;
                watermarkOptions.Top = 550;

                if (e.CommandArgument.ToString().ToLower().Equals("pdf"))
                {
                    convertResult = conversionHandler.Convert<string>(inputFileName, new PdfSaveOptions { OutputType = OutputType.String, WatermarkOptions = watermarkOptions });
                }
                if (e.CommandArgument.ToString().ToLower().Equals("xlsx"))
                {
                    convertResult = conversionHandler.Convert<string>(inputFileName, new CellsSaveOptions { OutputType = OutputType.String, WatermarkOptions = watermarkOptions });
                }
                else if (e.CommandArgument.ToString().ToLower().Equals("jpg"))
                {
                    IList<string> convertResults = conversionHandler.Convert<IList<string>>(inputFileName, new ImageSaveOptions { ConvertFileType = ImageSaveOptions.ImageFileType.Jpg, OutputType = OutputType.String, WatermarkOptions = watermarkOptions });

                    // Conver to Image format returns multiple images path as string array, one image for each input document page.
                    foreach (string s in convertResults)
                    {
                        if (!s.Equals(""))
                        {
                            Download(s, e.CommandArgument.ToString());
                        }
                    }
                    return;
                }
                else if (e.CommandArgument.ToString().ToLower().Equals("png"))
                {
                    // Conver to Image format returns multiple images path as string array, one image for each input document page.
                    IList<string> convertResults = conversionHandler.Convert<IList<string>>(inputFileName, new ImageSaveOptions { ConvertFileType = ImageSaveOptions.ImageFileType.Png, OutputType = OutputType.String, WatermarkOptions = watermarkOptions });
                    foreach (string s in convertResults)
                    {
                        if (!s.Equals(""))
                        {
                            Download(s, e.CommandArgument.ToString());
                        }
                    }
                    return;
                }
                else if (e.CommandArgument.ToString().ToLower().Equals("pptx"))
                {
                    convertResult = conversionHandler.Convert<string>(inputFileName, new SlidesSaveOptions { OutputType = OutputType.String, WatermarkOptions = watermarkOptions });
                }
                else if (e.CommandArgument.ToString().ToLower().Equals("html"))
                {
                    convertResult = conversionHandler.Convert<string>(inputFileName, new HtmlSaveOptions { OutputType = OutputType.String, WatermarkOptions = watermarkOptions });
                }


                if (!convertResult.Equals(""))
                {
                    Download(convertResult, e.CommandArgument.ToString().ToString());
                }
            }
            catch (Exception exc)
            {
                convertResult = exc.Message;
            }
        }

        private void Download(string outputFileName, string outputfileType)
        {
            var response = System.Web.HttpContext.Current.Response;
            response.ClearContent();
            response.Clear();
            var extension = Path.GetExtension(outputFileName);
            response.ContentType = outputfileType;
            response.AddHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(outputFileName) + ";");
            response.TransmitFile(outputFileName);
            response.Flush();
            response.End();
        }
    }
}