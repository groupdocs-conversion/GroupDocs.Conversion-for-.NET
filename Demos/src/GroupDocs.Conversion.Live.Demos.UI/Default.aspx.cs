using System;
using System.IO;
//using Tools.Foundation.Models;
using System.Web.UI;
using GroupDocs.Conversion.Live.Demos.UI.Models;
using GroupDocs.Conversion.Live.Demos.UI.Config;
using System.Web;
using System.Globalization;
using GroupDocs.Conversion.Live.Demos.UI.Helpers;
using System.Text.RegularExpressions;
//using GroupDocs.Apps.LIB;

namespace GroupDocs.Conversion.Live.Demos.UI
{
    public partial class Default : BasePage
    {
        string logMsg = "";
        string supportedFileExtensions = "";
        public string howto = "";
        public string metatitle = "";
        public string metadescription = "";
        public string metakeywords = "";
        public string fileFormat = "";
        public string fileFormat2 = "";
        public string DropOrUploadFileText = "Drop or upload your file";
        public string excMessage = "";
        public string excStack = "";

        protected void Page_Load(object sender, EventArgs e)
        {            
            try
            {
                if (!IsPostBack)
                {
                    ddlFrom_SelectedIndexChanged(sender, e);

                    metatitle = "Free Online Document Converter";
                    hheading.InnerHtml = metatitle;
                    metadescription = "Free online document converter for Word, Excel, Powerpoint, Presentation, " + supportedFileExtensions.ToUpper() + ". GroupDocs";
                    metakeywords = "convert document, free document converter, free online document converter, ilovepdf, ";
                    howto = " document files";

                    foreach (string str in supportedFileExtensions.Replace(" ", "").ToUpper().Split(','))
                    {
                        metakeywords += str + " converter, ";
                    }
                    metakeywords = metakeywords.Trim().Trim(',') + ", GroupDocs";

                    UploadFile.AllowMultiple = false;
                    aPoweredBy.InnerText = "GroupDocs.Conversion. "; ;
                    aPoweredBy.HRef = "https://products.groupdocs.com/conversion/total";                    
                }
                Page.Title = metatitle;
                Page.MetaDescription = metadescription;
            }
            catch (Exception ex)
            {
                pMessage.InnerHtml = "Error: " + ex.Message;
                pMessage.Attributes.Add("class", "alert alert-danger");
                pPopupMessage.InnerHtml = ex.Message;
                hdErrorMessage.Value = ex.Message;
                hdErrorDetail.Value = ex.StackTrace;
            }
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                string titleString = "";
                if (Page.RouteData.Values["from"] != null && Page.RouteData.Values["to"] != null)
                    titleString = Page.RouteData.Values["from"].ToString().ToUpper() + " to " + Page.RouteData.Values["to"].ToString().ToUpper();


                pPopupMessage.InnerHtml = "";
                hdErrorMessage.Value = "";
                hdErrorDetail.Value = "";
                hdErrorFolder.Value = "";

                ClientScript.RegisterStartupScript(this.GetType(), "customerrorModalSuccess", "<script>$(document).ready(function ($) { $('#customerrorModalSuccess').modal('show');});</script>");

            }
            catch (Exception)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "customerrorModal", "<script>$(document).ready(function ($) { $('#customerrorModal').modal('hide');});</script>");
                ClientScript.RegisterStartupScript(this.GetType(), "customerrorModalSuccess", "<script>$(document).ready(function ($) { $('#customerrorModalSuccess').modal('show');});</script>");
            }
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            Configuration.GroupDocsAppsAPIBasePath = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/";
            Configuration.FileDownloadLink = Configuration.GroupDocsAppsAPIBasePath + "DownloadFile.aspx";

            pPopupBody.InnerHtml = "<p><b><i>Would you like to report this error to the forum, so that we can look into it and resolve the issue? You will get the notification email when error is fixed.</i></b></p>";

            hdErrorFolder.Value = "";
            if (IsValid)
            {
                if (UploadFile.PostedFiles != null)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    string elapsedMs = "";
                    if (UploadFile.PostedFiles.Count > 1)
                    {
                        try
                        {
                            FileUploadResult isFileUploaded = null;

                            for (int i = 0; i < UploadFile.PostedFiles.Count; i++)
                            {
                                if (UploadFile.PostedFiles[i].ContentLength > 0)
                                {
                                    string fn = Regex.Replace(System.IO.Path.GetFileName(UploadFile.PostedFiles[i].FileName).Trim(), @"\A(?!(?:COM[0-9]|CON|LPT[0-9]|NUL|PRN|AUX|com[0-9]|con|lpt[0-9]|nul|prn|aux)|[\s\.])[^\\\/:*"" ?<>|]{ 1,254}\z", "");
                                    fn = fn.Replace(" ", String.Empty);

                                    string SaveLocation = Configuration.AssetPath + fn;
                                    SaveLocation = SaveLocation.Replace("'", "");

                                    UploadFile.PostedFiles[i].SaveAs(SaveLocation);

                                    if (i == 0)
                                    {
                                        isFileUploaded = FileManager.UploadFile(SaveLocation, "");
                                    }
                                    else
                                    {
                                        if ((isFileUploaded != null) && (isFileUploaded.FileName.Trim() != ""))
                                        {
                                            isFileUploaded = FileManager.UploadFileToFolder(SaveLocation, "", isFileUploaded.FolderId);
                                        }
                                    }

                                    if (isFileUploaded == null)
                                    {
                                        pMessage.InnerHtml = "Temporary disk error while file uploading. Please try again.";
                                        throw new Exception("Error folder access tempfop");
                                    }
                                }
                            }
                            hdErrorFolder.Value = isFileUploaded.FolderId.Trim();

                            Response response = GroupDocsConversionApiHelper.ConvertFile(isFileUploaded.FileName, isFileUploaded.FolderId, hfToFormat.Value.ToLower(), Path.GetExtension(isFileUploaded.FileName), true);

                            watch.Stop();
                            elapsedMs = (watch.ElapsedMilliseconds / 60000).ToString();

                            if (response == null)
                            {
                                throw new Exception(Resources["APIResponseTime"] + ", Time elapsed (minutes): " + elapsedMs);
                            }
                            else if (response.StatusCode == 200)
                            {
                                string url = Configuration.FileDownloadLink + "?FileName=" + response.FileName + "&Time=" + DateTime.Now.ToString();
                                litDownloadNow.Text = "<a target=\"_blank\" href=\"" + url + "\" class=\"btn btn-success btn-lg\">" + Resources["DownLoadNow"] + " <i class=\"fa fa-download\"></i></a>";
                                downloadUrl.Value = HttpUtility.UrlEncode(url);

                                ConvertPlaceHolder.Visible = false;
                                DownloadPlaceHolder.Visible = true;

                                logMsg = "ControllerName: GroupDocsConversionController FileName: " + response.FileName + " FolderName: " + isFileUploaded.FolderId + " OutFileExtension: " + hfToFormat.Value.ToLower();
                            }
                            else
                            {
                                throw response.exc;
                            }

                        }
                        catch (Exception ex)
                        {
                            pMessage.InnerHtml = "Error: " + ex.Message;
                            pMessage.Attributes.Add("class", "alert alert-danger");

                            pPopupMessage.InnerHtml = ex.Message;
                            if (ex.Message.ToLower().Contains("tempfop"))
                            {
                                pMessage.InnerHtml = "Temporary disk error while file uploading. Please try again.";
                            }

                            if (ex.Message.ToLower().Contains(" timeout"))
                            {
                                string msgBody = String.Format("We regret to inform you that your file took more than {0} minute(s). We cannot process it at the moment. Please try again later. If you would like to report it in our forums, please enter your email address below. Your message will be posted in our forums and our team will contact you.", Math.Ceiling((Configuration.ThreadAbortSeconds / 60.0)));
                                pPopupBody.InnerHtml = "<p><b><i>" + msgBody + "</i></b></p>";
                                pMessage.InnerHtml = String.Format("We regret to inform you that your file took more than {0} minute(s). We cannot process it at the moment. Please try again later.", Math.Ceiling((Configuration.ThreadAbortSeconds / 60.0)));
                            }

                            hdErrorMessage.Value = ex.Message;
                            hdErrorDetail.Value = ex.StackTrace;
                        }
                    }
                    else
                    {
                        try
                        {
                            // remove any invalid character from the filename.
                            string fn = Regex.Replace(System.IO.Path.GetFileName(UploadFile.PostedFiles[0].FileName).Trim(), @"\A(?!(?:COM[0-9]|CON|LPT[0-9]|NUL|PRN|AUX|com[0-9]|con|lpt[0-9]|nul|prn|aux)|[\s\.])[^\\\/:*"" ?<>|]{ 1,254}\z", "");
                            fn = fn.Replace(" ", String.Empty);
                            string SaveLocation = Configuration.AssetPath + fn;

                            SaveLocation = SaveLocation.Replace("'", "");

                            UploadFile.PostedFiles[0].SaveAs(SaveLocation);

                            var isFileUploaded = FileManager.UploadFile(SaveLocation, "");

                            if ((isFileUploaded != null) && (isFileUploaded.FileName.Trim() != ""))
                            {
                                hdErrorFolder.Value = isFileUploaded.FolderId.Trim();

                                Response response = GroupDocsConversionApiHelper.ConvertFile(isFileUploaded.FileName, isFileUploaded.FolderId, hfToFormat.Value.ToLower(), Path.GetExtension(isFileUploaded.FileName), false);

                                watch.Stop();
                                elapsedMs = (watch.ElapsedMilliseconds / 60000).ToString();

                                if (response == null)
                                {
                                    throw new Exception(Resources["APIResponseTime"] + ", Time elapsed (minutes): " + elapsedMs);
                                }
                                else if (response.StatusCode == 200)
                                {
                                    string url = Configuration.FileDownloadLink + "?FileName=" + response.FileName + "&Time=" + DateTime.Now.ToString();
                                    litDownloadNow.Text = "<a target=\"_blank\" href=\"" + url + "\" class=\"btn btn-success btn-lg\">" + Resources["DownLoadNow"] + " <i class=\"fa fa-download\"></i></a>";
                                    downloadUrl.Value = HttpUtility.UrlEncode(url);

                                    ConvertPlaceHolder.Visible = false;
                                    DownloadPlaceHolder.Visible = true;

                                    logMsg = "ControllerName: GroupDocsConversionController FileName: " + response.FileName + " FolderName: " + isFileUploaded.FolderId + " OutFileExtension: " + hfToFormat.Value.ToLower();
                                }
                                else
                                {
                                    throw response.exc;
                                }

                            }
                            else
                            {
                                pMessage.InnerHtml = "Temporary disk error while file uploading. Please try again.";
                                throw new Exception("Error folder access tempFop");
                            }
                        }
                        catch (Exception ex)
                        {
                            pMessage.InnerHtml = "Error: " + ex.Message;
                            pMessage.Attributes.Add("class", "alert alert-danger");

                            pPopupMessage.InnerHtml = ex.Message;
                            if (ex.Message.ToLower().Contains("tempFop"))
                            {
                                pMessage.InnerHtml = "Temporary disk error while file uploading. Please try again.";
                            }

                            if (ex.Message.ToLower().Contains(" timeout"))
                            {
                                string msgBody = String.Format("We regret to inform you that your file took more than {0} minute(s). We cannot process it at the moment. Please try again later. If you would like to report it in our forums, please enter your email address below. Your message will be posted in our forums and our team will contact you.", Math.Ceiling((Configuration.ThreadAbortSeconds / 60.0)));
                                pPopupBody.InnerHtml = "<p><b><i>" + msgBody + "</i></b></p>";
                                pMessage.InnerHtml = String.Format("We regret to inform you that your file took more than {0} minute(s). We cannot process it at the moment. Please try again later.", Math.Ceiling((Configuration.ThreadAbortSeconds / 60.0)));
                            }

                            hdErrorMessage.Value = ex.Message;
                            hdErrorDetail.Value = ex.StackTrace;
                        }
                    }
                }
                else
                {
                    pMessage.InnerHtml = Resources["FileSelectMessage"];
                    pMessage.Attributes.Add("class", "alert alert-danger");
                }
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string url = HttpUtility.UrlDecode(downloadUrl.Value);
                string emailBody = EmailManager.PopulateBody("", Resources["DownloadFileLinkTitle"], url, "", Resources["ConversionFeatureDescription"], Resources["FileConvertedSuccessMessage1"]);
                EmailManager.SendEmail(emailTo.Value, Configuration.FromEmailAddress, Resources["EmailTitle"], emailBody, "");

                pMessage2.Attributes.Add("class", "alert alert-success");
                pMessage2.InnerHtml = Resources["FileConvertedSuccessMessage"];
            }
            catch (Exception ex)
            {
                pMessage2.InnerHtml = "Error: " + ex.Message;
                pMessage2.Attributes.Add("class", "alert alert-danger");
                pPopupMessage.InnerHtml = ex.Message;
                hdErrorMessage.Value = ex.Message;
                hdErrorDetail.Value = ex.StackTrace;
            }
        }

        private string TitleCase(string value)
        {
            return new CultureInfo("en-US", false).TextInfo.ToTitleCase(value);
        }

        protected void ddlFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.GroupDocsAppsAPIBasePath = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/";

            string validationExpression = "";
            string validFileExtensions = "";
            //string strFromFormat = "*";
            
            hfIsToFormat.Value = "0";
            Response response = GroupDocsConversionApiHelper.GetAllSupportedFormats("");

            if (response == null)
            {
                throw new Exception(Resources["APIResponseTime"]);
            }
            else if (response.StatusCode == 200)
            {
                if (response.OutputType.Length > 0)
                {
                    if (Page.RouteData.Values["from"] != null)
                    {
                        validationExpression = "." + Page.RouteData.Values["from"].ToString().ToUpper() + ", ." + response.OutputType.Replace(", ", "|.").ToLower();
                        validFileExtensions = Page.RouteData.Values["from"].ToString().ToUpper() + ", " + response.OutputType;
                        supportedFileExtensions = Page.RouteData.Values["from"].ToString().ToUpper() + ", " + response.OutputType;
                    }
                    else
                    {
                        validationExpression = "." + response.OutputType.Replace(", ", "|.").ToLower();
                        validFileExtensions = response.OutputType;
                        supportedFileExtensions = response.OutputType;
                    }
                }
            }

            ValidateFileType.ValidationExpression = @"(.*?)(" + validationExpression.ToLower() + "|" + validationExpression.ToUpper() + ")$";
            hdnFileExtensionMessage.Value = Resources["InvalidFileExtension"];

            int index = supportedFileExtensions.LastIndexOf(",");
            if (index != -1)
            {
                string substr = supportedFileExtensions.Substring(index);
                string str = substr.Replace(",", " or");
                supportedFileExtensions = supportedFileExtensions.Replace(substr, str);
            }

            ValidateFileType.ErrorMessage = Resources["InvalidFileExtension"] + " " + supportedFileExtensions;

            string docTitle = "document";

            btnConvert.Text = Resources["btnConvertNow"];
            ViewState["validFileExtensions"] = supportedFileExtensions;
            ViewState["validToFileExtensions"] = validFileExtensions;
            ViewState["docTitle"] = docTitle;
        }

    }

}