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
            Common.inputGUIDFile = "DOCXsample.docx";
            //Common.inputGUIDFile = "PPTSample.pptx";
            //Common.inputGUIDFile = "PDFsample.pdf";

            // Uncomment following lines and specify the licence file to embed product licence using file path.
            // Common.licensePath = Path.Combine(Environment.CurrentDirectory, @"GroupDocs.total.lic");
            // Common.ApplyLicense(Common.licensePath);

            // Uncomment following lines and specify the licence file to embed product licence using stream.
            Stream licenseStream = File.Open(Path.Combine(Environment.CurrentDirectory, @"GroupDocs.total.lic"), FileMode.Open, FileAccess.Read);
            Common.ApplyLicense(licenseStream);

            /// <summary>
            /// **** Convert Spreadsheet, PDF, Presentation, Document Processing  formats.
            /// </summary>


            // Convert file  Spreadsheet Document formats and get output as file path
            Conversion.ConvertToSpreadsheetAsPath();

            // Convert file  Spreadsheet Document formats and get output as Stream
            // Conversion.ConvertToSpreadsheetStream();

            // In Advanced example Convert Password Protected file to Spreadsheet Document formats 
            //Conversion.ConvertToSpreadsheetAdvanceOptions();

            // Convert file to PDF format and get output as file path
            Conversion.ConvertToPdfAsPath();

            // Convert file to PDF format and get output as Stream
            // Conversion.ConvertToPdfAsStream();

            // In Advanced example Convert Password Protected file to PDF format
            // Conversion.ConvertToPdfAdvanceOptions();

            // Convert file to PDF format and get output as file path and get processing progress
            Conversion.ConvertToPdfWithProgressAsPath();

            // Convert file to Presentation Document format and get output as file path
            Conversion.ConvertToPresentationAsPath();

            // Convert file to Presentation Document format and get output as Stream
            // Conversion.ConvertToPresentationAsStream();

            // In Advanced example Convert Password Protected file to Presentation Document format
            // Conversion.ConversionToSlidesAdvanceOptions();

            // Convert file to Word Processing Document format and get output as file path
            Conversion.ConvertToWordDocumentAsPath();

            // Get Available Save Options for a Document by Extenssion
            Conversion.GetAvailableSaveOptionsByExtenssion();

            // Convert file to Word Processing Document format and get output as Stream
            // Conversion.ConvertToWordDocumentAsStream();

            // In Advanced example Convert Password Protected file to Word Processing Document format
            // Conversion.ConvertToWordDocumentAdvanceOptions();

            /// <summary>
            /// **** Rendering and Converting to HTML and Image formats.
            /// </summary>

            // Converts and Render file to a HTML format and get output as file path
            Rendering.RenderHTMLAsPath();

            // Converts and Render file as HTML format and get output as Stream
            // Rendering.RenderHTMLAsStream();

            // In Advanced example Converts and Render Password Protected file to Excel format
            // Rendering.RenderHTMLAdvanceOptions();

            // Converts and Render file to an Image format and get output as file path
            Rendering.RenderImageAsPath(ImageSaveOptions.ImageFileType.Png);

            // Converts and Render file to an Image format and get output as Stream
            // Rendering.RenderImageAsStream(ImageSaveOptions.ImageFileType.Png);

            // In Advanced example Converts and Render Password Protected file to Image format
            // Rendering.RenderImageAdvanceOptions(ImageSaveOptions.ImageFileType.Gif);

            //ExEnd:ConvertFilesToDifferentFormats

        }
    }
}
