//ExStart:ConversionClass
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Handler;
using System.Drawing;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp
{
    public static class Conversion
    {
        //public static string inputGUIDFile = "DOCXsample.docx"; To overwrite inputfile

        #region Convert to Spreadsheet Document

        /// <summary>
        /// Convert file  Spreadsheet Document formats and get output as file path
        /// </summary> 
        public static void ConvertToSpreadsheetAsPath()
        {
            //ExStart:ConvertToSpreadsheetAsPath
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted spreadsheet documents.
            // Returns paths to the converted spreadsheet documents.

            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, new CellsSaveOptions { });
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".xls");

            //ExEnd:ConvertToSpreadsheetAsPath
        }

        /// <summary>
        /// Convert file  Spreadsheet Document formats and enable GridLines and get output as file path
        /// </summary> 
        public static void ConvertToSpreadsheetWithGridLinesAsPath()
        {
            //ExStart:ConvertToSpreadsheetWithGridLinesAsPath
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Save options
            CellsSaveOptions saveOptions = new CellsSaveOptions();
            saveOptions.CellsOptions.ShowGridLines = true;


            // Convert and save converted spreadsheet documents.
            // Returns paths to the converted spreadsheet documents.
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, saveOptions);
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".xls");
            //ExEnd:ConvertToSpreadsheetWithGridLinesAsPath
        }

        /// <summary>
        /// Convert file  Spreadsheet Document formats and use hidden sheets and get output as file path
        /// </summary> 
        public static void ConvertToSpreadsheetEnableHiddenSheetsAsPath()
        {
            //ExStart:ConvertToSpreadsheetEnableHiddenSheetsAsPath
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Save options
            CellsSaveOptions saveOptions = new CellsSaveOptions();
            saveOptions.CellsOptions.ShowHiddenSheets = true;

            // Convert and save converted spreadsheet documents.
            // Returns paths to the converted spreadsheet documents.
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, saveOptions);
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".xls");
            //ExEnd:ConvertToSpreadsheetEnableHiddenSheetsAsPath
        }

        /// <summary>
        /// Converts documents to Spreadsheet Document formats and outputs the resulting document to a stream
        /// </summary> 
        public static void ConvertToSpreadsheetStream()
        {
            //ExStart:ConvertToSpreadsheetStream
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted spreadsheet documents. 
            // Returns the converted spreadsheet documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert(Common.inputGUIDFile, new CellsSaveOptions());
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);
            //ExEnd:ConvertToSpreadsheetStream
        }

        /// <summary>
        /// In advance options example Convert Password Protected file to Spreadsheet Document formats 
        /// </summary>

        public static void ConvertToSpreadsheetAdvanceOptions()
        {
            //ExStart:ConvertToSpreadsheetAdvanceOptions
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            //Set password to unprotect protected document during loading

            var loadOptions = new CellsLoadOptions();
            loadOptions.Password = "secret";
            //loadOptions.DefaultFont = "Verdana";
            loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Arial", "Tahoma"));
            loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Calibri", "Tahoma"));
            // convert file to Xls, starting from page 2 and convert 2 pages
            CellsSaveOptions saveOptions = new CellsSaveOptions();

            saveOptions.PageNumber = 2;
            saveOptions.NumPagesToConvert = 2;
            saveOptions.CellsOptions.SkipEmptyRowsAndColumns = true;
            saveOptions.CellsOptions.ConvertRange = "D1:F8";
            // Unprotect input document, Convert and save spreadsheet documents using advance options.
            // Returns the converted spreadsheet documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert(Common.inputGUIDFile, loadOptions, saveOptions);
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            //ExEnd:ConvertToSpreadsheetAdvanceOptions
        }


        /// <summary>
        /// Converts stream input documents to Spreadsheet Document formats and outputs the resulting document to a file path
        /// </summary>

        public static void ConvertToSpreadsheetFromStreamToFile()
        {
            //ExStart:ConvertToSpreadsheetFromStreamToFile
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // read input document as a stream
            FileStream fileStream = new FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read);

            // Returns the converted spreadsheet documents as File Path using stream input.
            var convertedDocumentPath = conversionHandler.Convert(fileStream, new CellsSaveOptions { });
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".xls");

            fileStream.Close();
            //ExEnd:ConvertToSpreadsheetFromStreamToFile
        }

        /// <summary>
        /// Converts stream input documents to Spreadsheet Document formats and outputs the resulting document to a stream
        /// </summary>

        public static void ConvertToSpreadsheetFromStreamToStream()
        {
            //ExStart:ConvertToSpreadsheetFromStreamToStream
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // read input document as a stream
            FileStream fileStream = new FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read);

            // Returns the converted spreadsheet documents as IO Stream using stream input.
            var convertedDocumentStream = conversionHandler.Convert(fileStream, new CellsSaveOptions());
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            fileStream.Close();
            //ExEnd:ConvertToSpreadsheetFromStreamToStream
        }

        #endregion

        #region Convert to Word Processing Document


        /// <summary>
        /// Convert file to Word Processing Document format and get output as file path
        /// </summary> 

        public static void ConvertToWordDocumentAsPath()
        {
            //ExStart:ConvertToWordDocumentAsPath
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted word processing documents.
            // Returns paths to the converted word processing documents.
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, new WordsSaveOptions { });
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".doc");
            //ExEnd:ConvertToWordDocumentAsPath
        }


        /// <summary>
        /// Converts documents to Word Processing Document formats and outputs the resulting document to a stream
        /// </summary>

        public static void ConvertToWordDocumentAsStream()
        {
            //ExStart:ConvertToWordDocumentAsStream
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted word processing documents. 
            // Returns the converted word processing documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert(Common.inputGUIDFile, new WordsSaveOptions());
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            //ExEnd:ConvertToWordDocumentAsStream
        }

        /// <summary>
        /// In advance options example Convert Password Protected file to Word Processing Document format
        /// </summary>

        public static void ConvertToWordDocumentAdvanceOptions()
        {
            //ExStart:ConvertToWordDocumentAdvanceOptions
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            //Set password to unprotect protected document during loading

            var loadOptions = new WordsLoadOptions();
            loadOptions.Password = "secret";
            //loadOptions.DefaultFont = "Verdana";
            loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Angsana New", "Arial Unicode MS"));
            loadOptions.AutoFontSubstitution = false;
            // convert file to Doc, starting from page 2 and convert 2 pages,
            WordsSaveOptions saveOptions = new WordsSaveOptions
            {
                ConvertFileType = WordsSaveOptions.WordsFileType.Doc,
                PageNumber = 2,
                NumPagesToConvert = 2,

            };

            // Unprotect input document, Convert and save word processing documents using advance options.
            // Returns the converted word processing documents as IO Stream .
            var convertedDocumentStream = conversionHandler.Convert(Common.inputGUIDFile, loadOptions, saveOptions);
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            //ExEnd:ConvertToWordDocumentAdvanceOptions
        }

        /// <summary>
        /// Converts stream input documents to Word Processing Document formats and outputs the resulting document to a file path
        /// </summary>
        public static void ConvertToWordFromStreamToFile()
        {
            //ExStart:ConvertToWordFromStreamToFile
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // read input document as a stream
            FileStream fileStream = new FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read);

            // Returns the converted Word Processing Documents as File Path using stream input.
            var convertedDocumentPath = conversionHandler.Convert(fileStream, new WordsSaveOptions { });
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".doc");

            fileStream.Close();
            //ExEnd:ConvertToWordFromStreamToFile
        }

        /// <summary>
        /// Converts stream input documents to Word Proccessing Document formats and outputs the resulting document to a stream
        /// </summary>
        public static void ConvertToWordFromStreamToStream()
        {
            //ExStart:ConvertToWordFromStreamToStream
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // read input document as a stream
            FileStream fileStream = new FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read);

            // Returns the converted Word Processing Documents as IO Stream using stream input.
            var convertedDocumentStream = conversionHandler.Convert(fileStream, new WordsSaveOptions());
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            fileStream.Close();
            //ExEnd:ConvertToWordFromStreamToStream
        }


        /// <summary>
        /// Converts stream input documents to Word Proccessing Document formats with show/Hide Track Changes and outputs the resulting document to a stream
        /// </summary>
        public static void ConvertToWordDocumentAdvanceOptionswithtrackchanges()
        {
            //ExStart:ConvertToWordDocumentAdvanceOptionswithTrackchanges
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert file to Doc, starting from page 2 and convert 2 pages,
            WordsSaveOptions saveOptions = new WordsSaveOptions
            {
                ConvertFileType = WordsSaveOptions.WordsFileType.Doc,
                PageNumber = 2,
                NumPagesToConvert = 2,
                HideWordTrackedChanges = true,

            };

            // Unprotect input document, Convert and save word processing documents using advance options with Show/Hide Track changes.
            // Returns the converted word processing documents as IO Stream with Show/Hide Track changes.
            var convertedDocumentStream = conversionHandler.Convert(Common.inputGUIDFile, loadOptions, saveOptions);
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            //ExEnd:ConvertToWordDocumentAdvanceOptionswithTrackchanges
        }
        #endregion

        #region Convert to Pdf

        /// <summary>
        /// Convert file to Pdf format and get output as file path
        /// </summary>

        public static void ConvertToPdfAsPath()
        {
            //ExStart:ConvertToPdfAsPath
            //Instantiating the conversion handler from custom common class 
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var saveOptions = new GroupDocs.Conversion.Converter.Option.PdfSaveOptions();

            //Image path
            byte[] image = System.IO.File.ReadAllBytes(@"D:\GitRepos\GroupDocs.Conversion-for-.NET\Examples\Data\SampleFiles\MVCConversion.png");
            //image watermark
            saveOptions.WatermarkOptions.Image = image;
            saveOptions.PdfOptions.Grayscale = true;
            saveOptions.PdfOptions.Linearize = true;

            // all images in the document are re-compressed. The compression is defined by the ImageQuality property.
            saveOptions.PdfOptions.OptimizationOptions.CompressImages = true;

            //  value in percent where 100% is unchanged quality and image size. To decrease the image size, use ImageQuality less than 100
            //saveOptions.PdfOptions.OptimizationOptions.ImageQuality = 50;
            // Link duplcate streams
            //saveOptions.PdfOptions.OptimizationOptions.LinkDuplcateStreams = true;
            // Remove unused objects
            //saveOptions.PdfOptions.OptimizationOptions.RemoveUnusedObjects = true;
            // Remove unused streams
            //saveOptions.PdfOptions.OptimizationOptions.RemoveUnusedStreams = true;
            // Make fonts not embedded if set to true
            //saveOptions.PdfOptions.OptimizationOptions.UnembedFonts = true;

            saveOptions.WordBookmarkOptions.BookmarksOutlineLevel = 5;

            saveOptions.ConvertFileType = PdfSaveOptions.PdfFileType.Pdf;
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, saveOptions);
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".pdf");
            //ExEnd:ConvertToPdfAsPath 
        }

        /// <summary>
        /// Converts documents to Pdf Document formats and outputs the resulting document to a stream
        /// </summary>

        public static void ConvertToPdfAsStream()
        {
            //ExStart:ConvertToPdfAsStream
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted Pdf documents. 
            // Returns the converted spreadsheet Pdf as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert(Common.inputGUIDFile, new PdfSaveOptions());
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            //ExEnd:ConvertToPdfAsStream
        }

        /// <summary>
        /// In advance options example Convert Password Protected file to Pdf format
        /// </summary>        
        public static void ConvertToPdfAdvanceOptions()
        {
            //ExStart:ConvertToPdfAdvanceOptions
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler(); 
            var loadOptions = new PdfLoadOptions { Password = "secret", FlattenAllFields = false};

            // convert starting from page 2 and convert 2 pages,
            // use DPI 300, page width 1024, page height 768
            PdfSaveOptions saveOptions = new PdfSaveOptions
            {
                EmailOptions =
                {
                    DisplayHeader = true,
                    DisplayEmailAddress = true,
                    DisplayFromEmailAddress = true,
                    DisplayToEmailAddress = true,
                    DisplayCcEmailAddress = true,
                    DisplayBccEmailAddress = true
                },
                Rotate = Options.Save.PdfSaveOptions.Rotation.None,
                
                PageNumber = 2,
                NumPagesToConvert = 2,
                Dpi = 300,
                Width = 1024,
                Height = 768
            };

            // Unprotect input document, Convert and save Pdf documents using advance options.
            // Returns the converted  Pdf as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert(Common.inputGUIDFile, loadOptions, saveOptions);
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            //ExEnd:ConvertToPdfAdvanceOptions
        }

        /// <summary>
        /// Converts stream input documents to pdf Document formats and outputs the resulting document to a file path
        /// </summary>
        public static void ConvertToPdfFromStreamToFile()
        {
            //ExStart:ConverToPdfFromStreamToFile
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // read input document as a stream
            FileStream fileStream = new FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read);

            // Returns the converted pdf documents as File Path using stream input.
            var convertedDocumentPath = conversionHandler.Convert(fileStream, new PdfSaveOptions { });
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".pdf");

            fileStream.Close();
            //ExEnd:ConverToPdfFromStreamToFile
        }

        /// <summary>
        /// Converts stream input documents to pdf Document formats and outputs the resulting document to a stream
        /// </summary>
        public static void ConvertToPdfFromStreamToStream()
        {
            //ExStart:ConvertToPdfFromStreamToStream
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // read input document as a stream
            FileStream fileStream = new FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read);

            // Returns the converted pdf documents as IO Stream using stream input.
            var convertedDocumentStream = conversionHandler.Convert(fileStream, new PdfSaveOptions());
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            fileStream.Close();
            //ExEnd:ConvertToPdfFromStreamToStream
        }

        #endregion

        #region Convert to Presentation Document

        /// <summary>
        /// Convert file to Presentation Document format and get output as file path
        /// </summary>
        public static void ConvertToPresentationAsPath()
        {
            //ExStart:ConvertToPresentationAsPath
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();
            //include hidden slides in converted document 
            var loadOptions = new SlidesLoadOptions
            {
                ShowHiddenSlides = true
            };
            // Returns paths to the converted presentation documents.
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, loadOptions, new SlidesSaveOptions { });
            //measure conversion time
            Console.WriteLine("Elapsed time: {0}ms", convertedDocumentPath.Elapsed);
            //save output
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".ppt");
            //ExEnd:ConvertToPresentationAsPath
        }

        /// <summary>
        /// Converts documents to Presentation Document format and outputs the resulting document to a stream
        /// </summary>
        public static void ConvertToPresentationAsStream()
        {
            //ExStart:ConvertToPresentationAsStream
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted presentation documents. 
            // Returns the converted presentation documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert(Common.inputGUIDFile, new SlidesSaveOptions());
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            //ExEnd:ConvertToPresentationAsStream
        }

        /// <summary>
        /// In advance options example Convert Password Protected file to Presentation Document format
        /// </summary>

        public static void ConvertToPresentationAdvanceOptions()
        {
            //ExStart:ConvertToPresentationAdvanceOptions
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            //Set password to unprotect protected document during loading
            var loadOptions = new SlidesLoadOptions();
            loadOptions.Password = "secret";
            //loadOptions.DefaultFont = "Verdana";
            loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Arial", "Tahoma"));
            loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Calibri", "Tahoma"));
            // convert file to Ppt, starting from page 2 and convert 2 pages, 
            SlidesSaveOptions saveOptions = new SlidesSaveOptions
            {
                ConvertFileType = SlidesSaveOptions.SlidesFileType.Ppt,
                PageNumber = 2,
                NumPagesToConvert = 2,
            };

            // Unprotect input document, Convert and save presentation documents using advance options.
            // Returns the converted presentation documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert(Common.inputGUIDFile, loadOptions, saveOptions);
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            //ExEnd:ConvertToPresentationAdvanceOptions
        }

        /// <summary>
        /// Converts stream input documents to Presentation Document formats and outputs the resulting document to a file path
        /// </summary>
        public static void ConvertToPresentationFromStreamToFile()
        {
            //ExStart:ConvertToPresentationFromStreamToFile
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // read input document as a stream
            FileStream fileStream = new FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read);

            // Returns the converted presentation documents as File Path using stream input.
            var convertedDocumentPath = conversionHandler.Convert(fileStream, new SlidesSaveOptions { });
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".ppt");

            fileStream.Close();
            //ExEnd:ConvertToPresentationFromStreamToFile
        }

        /// <summary>
        /// Converts stream input documents to Presentation Document formats and outputs the resulting document to a stream
        /// </summary>
        public static void ConvertToPresentationFromStreamToStream()
        {
            //ExStart:ConvertToPresentationFromStreamToStream
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // read input document as a stream
            FileStream fileStream = new FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read);

            // Returns the converted presentation documents as IO Stream using stream input.
            var convertedDocumentStream = conversionHandler.Convert(fileStream, new SlidesSaveOptions());
            MemoryStream targetStream = new MemoryStream();
            convertedDocumentStream.Save(targetStream);

            fileStream.Close();
            //ExEnd:ConvertToPresentationFromStreamToStream
        }

        /// <summary>
        /// Convert file to Presentation Document format and remove comments and get output as file path
        /// </summary>
        public static void ConvertToPresentationWithoutCommentsAsPath()
        {
            //ExStart:ConvertToPresentationWithoutCommentsAsPath
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Slide save options to remove slide comments
            SlidesSaveOptions saveOptions = new SlidesSaveOptions
            {

                HideComments = true // hides all slide comments
            };

            // Convert and save converted presentation documents.
            // Returns paths to the converted presentation documents.
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, saveOptions);
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".ppt");
            //ExEnd:ConvertToPresentationWithoutCommentsAsPath
        }

        #endregion

        #region Convert and Get Processing Progress

        /// <summary>
        /// Convert file to Pdf format and get output as file path and get processing progress
        /// </summary>

        //ExStart:ConvertToPdfWithProgressAsPath
        public static void ConvertToPdfWithProgressAsPath()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // attach Conversion Progress Handler
            conversionHandler.ConversionProgress += ConversionProgressHandler;

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, new PdfSaveOptions { });
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".pdf");

            Console.WriteLine("The conversion finished. The result can be located here: {0}. Press <<ENTER>> to exit.", convertedDocumentPath);
            Console.ReadLine();
        }

        private static void ConversionProgressHandler(ConversionProgressEventArgs args)
        {
            Console.WriteLine("Conversion progress: {0}", args.Progress);
        }

        //ExEnd:ConvertToPdfWithProgressAsPath
        #endregion

        #region Convert and Get Processing Status of ConversionStart, ConversionProgress, ConversionComplete events

        /// <summary>
        /// Convert file to Pdf format and get output as file path and get Status of ConversionStart, ConversionProgress, ConversionComplete events
        /// </summary>

        //ExStart:ConvertToPdfWithProgressStatusAsPath
        public static void ConvertToPdfWithProgressStatusAsPath()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // attach ConversionStart event
            conversionHandler.ConversionStart += delegate(ConversionStartEventArgs args)
            {
                Console.WriteLine("Conversion {0} started", args.ConversionGuid);
            };

            // attach ConversionProgress event
            conversionHandler.ConversionProgress += delegate(ConversionProgressEventArgs args)
            {
                Console.WriteLine("Conversion {0} progress: {1} %", args.ConversionGuid, args.Progress);
            };

            // attach ConversionComplete event
            conversionHandler.ConversionComplete += delegate(ConversionCompleteEventArgs args)
            {
                Console.WriteLine("Conversion {0} completed", args.ConversionGuid);
                Console.WriteLine("Result document is {0}. Cache is {1}", args.ConversionType, args.UsedCache ? "used" : "not used");
                Console.WriteLine("Result document has {0} page(s).", ((PdfConversionCompleteEventArgs)args).PageCount);
            };

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, new PdfSaveOptions { });
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".pdf");
        }

        //ExEnd:ConvertToPdfWithProgressStatusAsPath
        #endregion

        #region Convert file and get output as file path using Custom Input Data Handler

        /// <summary>
        /// Convert file and get output as file path using Custom Input Data Handler
        /// </summary>

        //ExStart:ConvertWithCustomInputDataHandler
        public static void ConvertWithCustomInputDataHandler()
        {
            // Creating new ConversionConfig class object with input and output files directory path
            ConversionConfig conversionConfig = new ConversionConfig { StoragePath = Common.storagePath, CachePath = Common.cachePath, OutputPath = Common.outputPath };

            // Instantiating the conversion handler from custom input data handler class
            //var inputDataHandler = new CustomInputDataHandler();
            var conversionHandler = new ConversionHandler(conversionConfig);

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, new PdfSaveOptions { });
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".pdf");
        }

        //ExEnd:ConvertWithCustomInputDataHandler
        #endregion

        #region Convert file and get output as file path using Custom Output Data Handler

        /// <summary>
        /// Convert file and get output as file path using Custom Output Data Handler
        /// </summary>

        //ExEnd:ConvertWithCustomOutputDataHandler
        #endregion

        #region Convert file and get Output as file path using Custom Cache Data Handler

        /// <summary>
        /// Convert file and get Output as file path using Custom Cache Data Handler
        /// </summary>

        //ExStart:ConvertWithCustomCacheDataHandler
        public static void ConvertWithCustomCacheDataHandler()
        {
            // Creating new ConversionConfig class object with input and output files directory path
            ConversionConfig conversionConfig = new ConversionConfig { StoragePath = Common.storagePath, CachePath = Common.cachePath, OutputPath = Common.outputPath };
            conversionConfig.UseCache = true;

            // Instantiating the conversion handler from custom cache data handler class
            var conversionHandler = new ConversionHandler(conversionConfig);

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, new PdfSaveOptions { });
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".pdf");
        }

        //ExEnd:ConvertWithCustomCacheDataHandler
        #endregion

        #region Get Available Save Options for a Document by Extenssion

        /// <summary>
        /// Get Available Save Options for a Document by Extenssion
        /// </summary>

        public static void GetAvailableSaveOptionsByExtenssion()
        {
            //ExStart:GetAvailableSaveOptionsByExtenssion
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var documentExtension = Path.GetExtension(Common.inputGUIDFile).TrimStart('.');
            var availableConversions = conversionHandler.GetSaveOptions(documentExtension);  //returns IDictionary<string, SaveOptions>

            //list all available conversions
            Console.WriteLine("*** Available Save Options ***");
            foreach (var name in availableConversions.Keys)
            {
                Console.WriteLine(name);
            }
            //use prepared save option for ToPdf conversion
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, availableConversions["pdf"]);
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".pdf");
            //ExEnd:ConvertToPdfWithProgressAsPath
        }

        #endregion

        #region Convert file and add watermark into output file

        /// <summary>
        /// Convert file and add watermark into output file
        /// </summary>

        //ExStart:ConvertAndAddWaterMarkAsPath
        public static void ConvertAndAddWaterMarkAsPath()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var saveOptions = new PdfSaveOptions();
            saveOptions.WatermarkOptions.Text = "Sample watermark";
            saveOptions.WatermarkOptions.Color = Color.Red;
            saveOptions.WatermarkOptions.Width = 100;
            saveOptions.WatermarkOptions.Height = 100;
            saveOptions.WatermarkOptions.Background = true;
            saveOptions.PdfOptions.FormatingOptions.PageMode = PdfFormatingOptions.PdfPageMode.FullScreen;
            saveOptions.PdfOptions.FormatingOptions.PageLayout = PdfFormatingOptions.PdfPageLayout.SinglePage;

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert(Common.inputGUIDFile, saveOptions);
            convertedDocumentPath.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".pdf");

            Console.WriteLine("The conversion finished. The result can be located here: {0}. Press <<ENTER>> to exit.", convertedDocumentPath);
            Console.ReadLine();
        }

        //ExEnd:ConvertAndAddWaterMarkAsPath
        #endregion

        #region Convert file using Conversion Listners Interfaces

        /// <summary>
        /// Convert file using Conversion Listners Interfaces
        /// </summary>

        //ExStart:ConvertUsingConversionLitenerAnddInterfaces
        public static void ConvertUsingConversionLitenerAnddInterfaces()
        {
            // Instantiating the conversion handler from custom common class
            var manager = new ConversionManager(Common.storagePath);
            var result = manager.Convert(Common.inputGUIDFile);
            Console.WriteLine(result);
        }

        //ExEnd:ConvertUsingConversionLitenerAnddInterfaces
        #endregion

        #region Convert and Get Pagewise output

        /// <summary>
        /// Convert and Get Pagewise output
        /// </summary>

        #endregion

        #region Common Conversion Methods
        /// <summary>
        /// To get pages count of a document which will be converted
        /// </summary> 
        public static void GetDocumentPagesCountAsPath()
        {
            //ExStart:GetDocumentPagesCountAsPath
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted spreadsheet documents.
            // Returns paths to the converted  documents.

            var count = conversionHandler.GetDocumentInfo(Common.inputGUIDFile).PageCount;
            Console.WriteLine(count);

            //ExEnd:GetDocumentPagesCountAsPath
        }

        /// <summary>
        /// To get possible conversions from file extension
        /// </summary> 
        public static void GetPossibleConversionsAsPath()
        {
            //ExStart:GetPossibleConversionsAsPath
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // get possible conversions from file extension.
            string[] possibleConversions = conversionHandler.GetPossibleConversions(Common.inputGUIDFile);

            Console.WriteLine("Possible Conversions: ");

            for (int i = 0; i < possibleConversions.Length; i++)
            {
                Console.WriteLine(possibleConversions[i]);
            }

            //ExEnd:GetPossibleConversionsAsPath
        }

        /// <summary>
        /// To get possible conversions from stream
        /// </summary> 
        public static void GetPossibleConversionsAsStream()
        {
            //ExStart:GetPossibleConversionsAsStream
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();


            // read input document as a stream
            FileStream fileStream = new FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read);

            // get possible conversions from stream
            string[] possibleConversions = conversionHandler.GetPossibleConversions(fileStream);

            Console.WriteLine("Possible Conversions: ");

            for (int i = 0; i < possibleConversions.Length; i++)
            {
                Console.WriteLine(possibleConversions[i]);
            }

            //ExEnd:GetPossibleConversionsAsStream
        }

        #endregion

        public static void TempDataHanlderImplementation()
        {
            const string sourceFileName = "sample.docx"; //TODO: Put the source filename here
            const string resultFileName = "result.pdf"; //TODO: Put the result filename here

            var config = new ConversionConfig
            {
                StoragePath = ".",
                OutputPath = ".",
                TempDataHandler = new MyTempDataHandler()
            };
            var handler = new ConversionHandler(config);


            var result = handler.Convert(sourceFileName, new PdfSaveOptions());
            result.Save(resultFileName);


            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        public static void ConversionFromTxtDoc()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            var loadOptions = new TxtLoadOptions();
            loadOptions.DetectNumberingWithWhitespaces = false;
            loadOptions.LeadingSpacesOptions = TxtLoadOptions.TxtLeadingSpacesOptions.Trim;
            loadOptions.TrailingSpacesOptions = TxtLoadOptions.TxtTrailingSpacesOptions.Trim;
            var saveOptions = new PdfSaveOptions();
            var convertedDocument = conversionHandler.Convert(Common.inputGUIDFile, loadOptions, saveOptions);
            convertedDocument.Save("result-" + Path.GetFileNameWithoutExtension(Common.inputGUIDFile) + ".pdf");

            Console.WriteLine("The conversion finished. The result can be located here: {0}. Press <<ENTER>> to exit.", convertedDocument);
            Console.ReadLine();
        }

    }
}
//ExEnd:ConversionClass
