using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GroupDocs.Conversion.Converter.Option;

namespace GroupDocs.Conversion.Examples.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExStart:ConvertFilesToDifferentFormats

            /// you can set Input and output paths and input file name along with license path common for all example methods.
            Common.storagePath = Path.Combine(Environment.CurrentDirectory, @"../../../../Data/SampleFiles");
            Common.cachePath = Path.Combine(Environment.CurrentDirectory, @"../../../../Data/Cache");
            Common.outputPath = Path.Combine(Environment.CurrentDirectory, @"../../../../Data/ConvertedFiles");

            //Common.inputGUIDFile = "PPTSample.pptx";
            //Common.inputGUIDFile = "PDFsample.pdf";

            // Uncomment following lines and specify the licence file to embed product licence using file path.
            //Common.licensePath = Path.Combine(Environment.CurrentDirectory, @"D:/License/GroupDocs.total.lic");
            //Common.ApplyLicense(Common.licensePath);

            // Uncomment following lines and specify the licence file to embed product licence using stream.
            //Stream licenseStream = File.Open(Path.Combine(Environment.CurrentDirectory, @"GroupDocs.total.lic"), FileMode.Open, FileAccess.Read);
            //Common.ApplyLicense(licenseStream);

            /// <summary>
            /// **** Convert Spreadsheet, PDF, Presentation, Document Processing  formats.
            /// </summary>


            // Convert file  Spreadsheet Document formats and get output as file path
            //Conversion.ConvertToSpreadsheetAsPath();

            // Convert file  Spreadsheet Document formats and get output as Stream
            //Conversion.ConvertToSpreadsheetStream();

            // In Advanced example Convert Password Protected file to Spreadsheet Document formats 
            //Conversion.ConvertToSpreadsheetAdvanceOptions();

            // Converts stream input documents to Spreadsheet Document formats and outputs the resulting document to a file path
            //Conversion.ConvertToSpreadsheetFromStreamToFile();

            // Convert file  Spreadsheet Document formats and enable GridLines and get output as file path
            //Conversion.ConvertToSpreadsheetWithGridLinesAsPath();

            // Convert file  Spreadsheet Document formats and use hidden sheets and get output as file path
            //Conversion.ConvertToSpreadsheetEnableHiddenSheetsAsPath();

            // Converts stream input documents to Spreadsheet Document formats and outputs the resulting document to a stream
            //Conversion.ConvertToSpreadsheetFromStreamToStream();

            // Convert file to PDF format and get output as file path
            //Conversion.ConvertToPdfAsPath();

            // Convert file to PDF format and get output as Stream
            // Conversion.ConvertToPdfAsStream();

            // In Advanced example Convert Password Protected file to PDF format
            // Conversion.ConvertToPdfAdvanceOptions();

            // Convert file to PDF format and get output as file path and get processing progress
            //Conversion.ConvertToPdfWithProgressAsPath();

            // Converts stream input documents to pdf Document formats and outputs the resulting document to a file path
            //Conversion.ConvertToPdfFromStreamToFile();

            // Converts stream input documents to pdf Document formats and outputs the resulting document to a stream
            //Conversion.ConvertToPdfFromStreamToStream();

            // Convert file to Presentation Document format and get output as file path
            //Conversion.ConvertToPresentationAsPath();

            // Convert file to Presentation Document format and get output as Stream
            // Conversion.ConvertToPresentationAsStream();

            // In Advanced example Convert Password Protected file to Presentation Document format
            // Conversion.ConversionToSlidesAdvanceOptions();

            // Converts stream input documents to presentation Document formats and outputs the resulting document to a file path
            //Conversion.ConvertToPresentationFromStreamToFile();

            // Converts stream input documents to presentation Document formats and outputs the resulting document to a stream
            //Conversion.ConvertToPresentationFromStreamToStream();

            // Convert file to Presentation Document format and remove comments and get output as file path
            //Conversion.ConvertToPresentationWithoutCommentsAsPath();

            // Convert file to Word Processing Document format and get output as file path
            //Conversion.ConvertToWordDocumentAsPath();

            // Get Available Save Options for a Document by Extenssion
            //Conversion.GetAvailableSaveOptionsByExtenssion();

            // Convert file to Word Processing Document format and get output as Stream
            // Conversion.ConvertToWordDocumentAsStream();

            // In Advanced example Convert Password Protected file to Word Processing Document format
            // Conversion.ConvertToWordDocumentAdvanceOptions();

            // Converts stream input documents to Word Processing Document formats and outputs the resulting document to a file path
            //Conversion.ConvertToWordFromStreamToFile();

            // Converts stream input documents to Word Processing Document formats and outputs the resulting document to a stream
            //Conversion.ConvertToWordFromStreamToStream();

            /// <summary>
            /// **** Rendering and Converting to HTML and Image formats.
            /// </summary>

            // Converts and Render file to a HTML format and get output as file path
            //Rendering.RenderHTMLAsPath();

            // Converts and Render file as HTML format and get output as Stream
            // Rendering.RenderHTMLAsStream();

            // Converts and render stream input document to html format and get output as file path
            //Rendering.RenderToHTMLFromStreamToFile();

            // Converts and render stream input document to html and outputs the resulting document to a stream
            //Rendering.RenderToHTMLFromStreamToStream();

            // In Advanced example Converts and Render Password Protected file to Excel format
            // Rendering.RenderHTMLAdvanceOptions();

            // Converts and Render file to an Image format and get output as file path
            Rendering.RenderImageAsPath(ImageSaveOptions.ImageFileType.Png);

            // Converts and Render file to an Image format and get output as Stream
            // Rendering.RenderImageAsStream(ImageSaveOptions.ImageFileType.Png);

            // In Advanced example Converts and Render Password Protected file to Image format
            // Rendering.RenderImageAdvanceOptions(ImageSaveOptions.ImageFileType.Gif);

            // Converts and render stream input document to image format and get output as file path
            //Rendering.RenderToImageFromStreamToFile(ImageSaveOptions.ImageFileType.Jpeg);

            // Converts and render stream input document to image and outputs the resulting document to a stream
            //Rendering.RenderToImageFromStreamToStream(ImageSaveOptions.ImageFileType.Jpeg);

            // Converts and Render file to an PSD Image format and get output as file path
            //Rendering.RenderPSDImageAsPath();

            // Convert file and get output as file path using Custom Input Data Handler
            //Conversion.ConvertWithCustomInputDataHandler();

            // Convert file and get output as file path using Custom Output Data Handler
            //Conversion.ConvertWithCustomOutputDataHandler();

            // Convert file and get Output as file path using Custom Cache Data Handler
            //Conversion.ConvertWithCustomCacheDataHandler();

            // Convert file and add watermark into output file
            //Conversion.ConvertAndAddWaterMarkAsPath();

            // Convert file using Conversion Listners Interfaces
            //Conversion.ConvertUsingConversionLitenerAnddInterfaces();

            // Convert and Get Pagewise output
            //Conversion.ConvertAndGetPagewiseOutputAsPaths();

            //get pages count of a document which will be converted
            //Conversion.GetDocumentPagesCountAsPath();

            //get possible conversions from file extension
            //Conversion.GetPossibleConversionsAsPath();

            /// get possible conversions from stream
            //Conversion.GetPossibleConversionsAsStream();

            // Converts and Render file to an Webp format and get output as file path
            //Rendering.RenderWebpAsPath(ImageSaveOptions.ImageFileType.Webp);

            //ExEnd:ConvertFilesToDifferentFormats

        }
    }
}
