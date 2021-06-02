using System.Web.Http;
using GroupDocs.Conversion.Live.Demos.UI.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Conversion;
using GroupDocs.Conversion.Contracts;
using System.Threading;
using GroupDocs.Conversion.Options.Convert;
using System.IO.Compression;

namespace GroupDocs.Conversion.Live.Demos.UI.Controllers
{
	public class GroupDocsConversionController : ApiControllerBase
	{
		[HttpGet]
		[ActionName("ConvertFile")]
		public Response ConvertFile(string fileName, string folderName, string outputType, string productName, bool isMultiple)
		{           
			Exception threadException = null;

			if (outputType == "~")
				outputType = "pdf";
            
			string sourceFolder = AppSettings.WorkingDirectory + folderName;
			string sourceExtention = Path.GetExtension(fileName);

			if (!Directory.Exists(AppSettings.OutputDirectory + "/" + folderName))
			{
				Directory.CreateDirectory(AppSettings.OutputDirectory + "/" + folderName);
			}

			if (outputType.Contains(sourceExtention.Replace(".", "")))
			{
				System.IO.File.Copy(AppSettings.WorkingDirectory + "/" + folderName + "/" + fileName, AppSettings.OutputDirectory + "/" + folderName + "/" + fileName, true);
				return new Response()
				{
					FileName = folderName + "/" + fileName,
					Status = "ok",
					StatusCode = 200,
					exc = null
				};
			}

			try
			{
				outputType = outputType.Replace(" ", "");
				string outputOption = outputType.ToUpper();
				bool isImage = false;

				if ("TIFF,TIF,JPEG,JPG,PNG,GIF,BMP,ICO,PSD,JPG, J2K, BMP, TIFF, GIF, PNG, EMF, WMF, PSD, WEBP, SVG, DICOM, DJVU, DNG, ODG, EPS, JPG, XPS".Contains(outputOption))
				{
					isImage = true;
				}

				if (isMultiple)
				{
					System.IO.DirectoryInfo dir = System.IO.Directory.GetParent(sourceFolder + "/");
					System.IO.FileInfo[] files = dir.GetFiles("*" + sourceExtention).OrderBy(p => p.CreationTime).ToArray();
					foreach (FileInfo file in files)
					{
						var documentExtension = Path.GetExtension(file.FullName).TrimStart('.').ToLower();

						var response = ProcessTask(file.Name, folderName, "." + outputType, isImage, "", true, delegate (string inFilePath, string outPath, string zipOutFolder)
						{
							string outfileName = Path.GetFileNameWithoutExtension(file.Name);

							GroupDocs.Conversion.Converter converter = new GroupDocs.Conversion.Converter(sourceFolder + "/" + file.Name);
							try
							{
								ConvertOptions convertOptions = null;
								try
								{
									convertOptions = converter.GetPossibleConversions()[outputType.ToLower()].ConvertOptions;
								}
								catch
								{
									convertOptions = new PdfConvertOptions();
								}

								if (isImage)
								{
									outPath = zipOutFolder + "/" + outfileName;
									string outputFileTemplate = Path.Combine(outPath + "_page_{0}." + outputType.ToLower());
									if (converter.GetDocumentInfo().PagesCount == 1)
										outputFileTemplate = Path.Combine(outPath + "." + outputType.ToLower());

									Conversion.Contracts.SavePageStream getPageStream = page => new FileStream(string.Format(outputFileTemplate, page), FileMode.Create);
									converter.Convert(getPageStream, convertOptions);
								}
								else
								{
									converter.Convert(AppSettings.OutputDirectory + folderName + "/" + outfileName + "." + outputType.ToLower(), convertOptions);
								}
							}
							catch (Exception ex)
							{
								threadException = ex;
							}
							finally
							{
								converter.Dispose();
							}

                            if (threadException != null)
							{
								throw threadException;
							}

						});
					}
					string zipOutFile = AppSettings.OutputDirectory + folderName + ".zip";
					try
					{
						if (System.IO.File.Exists(zipOutFile))
							System.IO.File.Delete(zipOutFile);

						ZipFile.CreateFromDirectory(AppSettings.OutputDirectory + folderName, zipOutFile);
					}
					catch
					{ }

					return new Response { FileName = folderName + ".zip", FolderName = "", ProductName = productName, OutputType = outputType, Status = "OK", StatusCode = 200, Text = "" };
				}
				else
				{
					var documentExtension = Path.GetExtension(fileName).TrimStart('.').ToLower();

					return ProcessTask(fileName, folderName, "." + outputType, isImage, "", delegate (string inFilePath, string outPath, string zipOutFolder)
					{
						string outfileName = Path.GetFileNameWithoutExtension(fileName);

						GroupDocs.Conversion.Converter converter = new GroupDocs.Conversion.Converter(sourceFolder + "/" + fileName);
						try
						{
							ConvertOptions convertOptions = null;
							try
							{
								convertOptions = converter.GetPossibleConversions()[outputType.ToLower()].ConvertOptions;
							}
							catch
							{
								convertOptions = new PdfConvertOptions();
							}
							if (isImage)
							{
								outPath = zipOutFolder + "/" + outfileName;
								string outputFileTemplate = Path.Combine(outPath + "_page_{0}." + outputType.ToLower());
								if (converter.GetDocumentInfo().PagesCount == 1)
									outputFileTemplate = Path.Combine(outPath + "." + outputType.ToLower());

								Conversion.Contracts.SavePageStream getPageStream = page => new FileStream(string.Format(outputFileTemplate, page), FileMode.Create);
								converter.Convert(getPageStream, convertOptions);
							}
							else
							{
								converter.Convert(AppSettings.OutputDirectory + folderName + "/" + outfileName + "." + outputType.ToLower(), convertOptions);
							}
						}
						catch (Exception ex)
						{
							threadException = ex;
						}
						finally
						{
							converter.Dispose();
						}

                        if (threadException != null)
						{
							throw threadException;
						}
					});
				}

			}
			catch (Exception exc)
			{
				string statusMessage = exc.Message;
				if (exc.Message.Contains("The given key was not present in the dictionary"))
					statusMessage = "Conversion from '" + Path.GetExtension(fileName).ToUpper() + "' to '" + outputType.ToUpper() + "' is not supported.";

				return new Response { exc = exc, FileName = fileName, FolderName = folderName, ProductName = productName, OutputType = outputType, Status = statusMessage, StatusCode = 500, Text = exc.ToString() };
			}
		}

		[HttpGet]
		[ActionName("GetAllSupportedFormats")]
		public Response GetAllSupportedFormats()
		{
			try
			{
				IEnumerable<PossibleConversions> availableConversions = Converter.GetAllPossibleConversions();
				string strToExtensions = "";

				foreach (var possibleConversions in availableConversions)
				{
					if (possibleConversions != null)
					{
						if (possibleConversions.Source != null)
						{
							strToExtensions += possibleConversions.Source.Extension.ToUpper() + ", ";
						}
					}
				}

				strToExtensions = strToExtensions.Trim().Trim(',');

				return new Response
				{
					OutputType = strToExtensions,
					StatusCode = 200
				};
			}
			catch (Exception exc)
			{
				return new Response
				{
					FolderName = "",
					OutputType = "",
					Status = exc.Message,
					StatusCode = 500,
					Text = exc.ToString(),
					exc = exc
				};
			}
		}

		[HttpGet]
		[ActionName("GetToSupportedFormats")]
		public Response GetToSupportedFormats(string toFormat)
		{
			try
			{
				string strToExtensions = "";

				var availableConversions = Converter.GetPossibleConversions(toFormat);

				foreach (var possibleConversions in availableConversions.All)
				{
					if (possibleConversions != null)
					{
						if (possibleConversions.ConvertOptions != null)
						{
							if (possibleConversions.ConvertOptions.Format != null)
							{
								strToExtensions += possibleConversions.ConvertOptions.Format.Extension.ToUpper() + ", ";
							}
						}
					}
				}

				strToExtensions = strToExtensions.Trim().Trim(',');
				if (strToExtensions.Trim().Equals(""))
					strToExtensions = toFormat.ToUpper();

				return new Response
				{
					OutputType = strToExtensions,
					StatusCode = 200
				};
			}
			catch (Exception exc)
			{
				return new Response
				{
					FolderName = "",
					OutputType = "",
					Status = exc.Message,
					StatusCode = 500,
					Text = exc.ToString(),
					exc = exc
				};
			}
		}

		private Response ProcessTask(string fileName, string folderName, string outFileExtension, bool createZip, string userEmail, ActionDelegate action)
		{
			return ProcessConversion("GroupDocsConversionController", fileName, folderName, outFileExtension, createZip, action);
		}

		private Response ProcessTask(string fileName, string folderName, string outFileExtension, bool createZip, string userEmail, bool isMultiple, ActionDelegate action)
		{
			return ProcessConversion("GroupDocsConversionController", fileName, folderName, outFileExtension, createZip, action, isMultiple);
		}
	}
}