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

namespace GroupDocs.Conversion.Examples.CSharp
{
    public static class Conversion
    {
        public static string inputGUIDFile = "DOCXsample.docx";

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

            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new CellsSaveOptions { OutputType = OutputType.String });
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
            SaveOptions saveOptions = new CellsSaveOptions
             {
                 OutputType = OutputType.String,
                 ShowGridLines = true // display border for each all cells

             };

            // Convert and save converted spreadsheet documents.
            // Returns paths to the converted spreadsheet documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, saveOptions);
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
            SaveOptions saveOptions = new CellsSaveOptions
            {
                OutputType = OutputType.String,
                ShowHiddenSheets = true // use hidden sheets
            };

            // Convert and save converted spreadsheet documents.
            // Returns paths to the converted spreadsheet documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, saveOptions);
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
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new CellsSaveOptions());
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
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert file to Xls, starting from page 2 and convert 2 pages
            SaveOptions saveOptions = new CellsSaveOptions
            {
                ConvertFileType = CellsSaveOptions.CellsFileType.Xls,
                PageNumber = 2,
                NumPagesToConvert = 2

            };

            // Unprotect input document, Convert and save spreadsheet documents using advance options.
            // Returns the converted spreadsheet documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
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
            var convertedDocumentStream = conversionHandler.Convert<String>(fileStream, new CellsSaveOptions { OutputType = OutputType.String, CustomName = Path.GetFileNameWithoutExtension(Common.inputGUIDFile) });

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
            var convertedDocumentStream = conversionHandler.Convert<Stream>(fileStream, new CellsSaveOptions());
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
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new WordsSaveOptions { OutputType = OutputType.String });
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
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new WordsSaveOptions());
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
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert file to Doc, starting from page 2 and convert 2 pages,
            SaveOptions saveOptions = new WordsSaveOptions
            {
                ConvertFileType = WordsSaveOptions.WordsFileType.Doc,
                PageNumber = 2,
                NumPagesToConvert = 2,

            };

            // Unprotect input document, Convert and save word processing documents using advance options.
            // Returns the converted word processing documents as IO Stream .
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
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
            var convertedDocumentStream = conversionHandler.Convert<String>(fileStream, new WordsSaveOptions { OutputType = OutputType.String, CustomName = Path.GetFileNameWithoutExtension(Common.inputGUIDFile) });

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
            var convertedDocumentStream = conversionHandler.Convert<Stream>(fileStream, new WordsSaveOptions());
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
            SaveOptions saveOptions = new WordsSaveOptions
            {
                ConvertFileType = WordsSaveOptions.WordsFileType.Doc,
                PageNumber = 2,
                NumPagesToConvert = 2,
                HideWordTrackedChanges = true,

            };

            // Unprotect input document, Convert and save word processing documents using advance options with Show/Hide Track changes.
            // Returns the converted word processing documents as IO Stream with Show/Hide Track changes.
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
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
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new PdfSaveOptions { OutputType = OutputType.String });
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
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new PdfSaveOptions());
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

            //Set password to unprotect protected document during loading
            LoadOptions loadOptions = new LoadOptions { Password = "secret" };

            // convert starting from page 2 and convert 2 pages,
            // use DPI 300, page width 1024, page height 768
            SaveOptions saveOptions = new PdfSaveOptions
            {
                PageNumber = 2,
                NumPagesToConvert = 2,
                Dpi = 300,
                Width = 1024,
                Height = 768
            };

            // Unprotect input document, Convert and save Pdf documents using advance options.
            // Returns the converted spreadsheet Pdf as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
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
            var convertedDocumentStream = conversionHandler.Convert<String>(fileStream, new PdfSaveOptions { OutputType = OutputType.String, CustomName = Path.GetFileNameWithoutExtension(Common.inputGUIDFile) });

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
            var convertedDocumentStream = conversionHandler.Convert<Stream>(fileStream, new PdfSaveOptions());
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

            // Convert and save converted presentation documents.
            // Returns paths to the converted presentation documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new SlidesSaveOptions { OutputType = OutputType.String });
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
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, new SlidesSaveOptions());
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
            LoadOptions loadOptions = new LoadOptions
            {
                Password = "secret"
                // DefaultFont = "Verdana"  // Default font for rendering the presentation. The following font will be used if a presentation font is missing.
            };

            // convert file to Ppt, starting from page 2 and convert 2 pages,
            // use DPI 300, image width 1024, image height 768
            SaveOptions saveOptions = new SlidesSaveOptions
            {
                ConvertFileType = SlidesSaveOptions.SlidesFileType.Ppt,
                PageNumber = 2,
                NumPagesToConvert = 2,
            };

            // Unprotect input document, Convert and save presentation documents using advance options.
            // Returns the converted presentation documents as IO Stream.
            var convertedDocumentStream = conversionHandler.Convert<Stream>(Common.inputGUIDFile, loadOptions, saveOptions);
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
            var convertedDocumentStream = conversionHandler.Convert<String>(fileStream, new SlidesSaveOptions { OutputType = OutputType.String, CustomName = Path.GetFileNameWithoutExtension(Common.inputGUIDFile) });

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
            var convertedDocumentStream = conversionHandler.Convert<Stream>(fileStream, new SlidesSaveOptions());
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
            SaveOptions saveOptions = new SlidesSaveOptions
            {
                OutputType = OutputType.String,
                RemoveSlidesComments = true // removes all slide comments
            };

            // Convert and save converted presentation documents.
            // Returns paths to the converted presentation documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, saveOptions);
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
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new PdfSaveOptions { OutputType = OutputType.String });

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
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new PdfSaveOptions { OutputType = OutputType.String });
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
            var inputDataHandler = new CustomInputDataHandler();
            var conversionHandler = new ConversionHandler(conversionConfig, inputDataHandler);

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new PdfSaveOptions { OutputType = OutputType.String });
        }

        //ExEnd:ConvertWithCustomInputDataHandler
        #endregion

        #region Convert file and get output as file path using Custom Output Data Handler

        /// <summary>
        /// Convert file and get output as file path using Custom Output Data Handler
        /// </summary>

        //ExStart:ConvertWithCustomOutputDataHandler
        public static void ConvertWithCustomOutputDataHandler()
        {
            // Creating new ConversionConfig class object with input and output files directory path
            ConversionConfig conversionConfig = new ConversionConfig { StoragePath = Common.storagePath, CachePath = Common.cachePath, OutputPath = Common.outputPath };

            // Instantiating the conversion handler from custom output data handler class
            var outputDataHandler = new CustomOutputDataHandler(conversionConfig);
            var conversionHandler = new ConversionHandler(conversionConfig, outputDataHandler);

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new PdfSaveOptions { OutputType = OutputType.String });

            Console.WriteLine("The conversion finished. The result can be located here: {0}. Press <<ENTER>> to exit.", convertedDocumentPath);
        }

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
            var cacheDataHandler = new CustomCacheDataHandler(conversionConfig);
            var conversionHandler = new ConversionHandler(conversionConfig, cacheDataHandler);

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, new PdfSaveOptions { OutputType = OutputType.String });
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
            var result = conversionHandler.Convert<string>(Common.inputGUIDFile, availableConversions["pdf"]);
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

            SaveOptions saveoptions = new PdfSaveOptions
            {
                OutputType = OutputType.String,
                WatermarkOptions = new WatermarkOptions("Watermark text")
                {
                    Color = Color.Blue,
                    Font = new Font("Arial", 40),
                    RotationAngle = 45,
                    Transparency = 0.1,
                    Left = 200,
                    Top = 400
                }
            };

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert<string>(Common.inputGUIDFile, saveoptions);

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

        //ExStart:ConvertAndGetPagewiseOutputAsPaths
        public static void ConvertAndGetPagewiseOutputAsPaths()
        {
            // Instantiating the conversion handler from custom common class
            ConversionHandler conversionHandler = Common.getConversionHandler();

            // Note: when using PageMode expected result is either IList<string> or IList<Stream> depending
            // of used OutputType in save options provided
            SaveOptions saveoptions = new PdfSaveOptions
            {
                OutputType = OutputType.String,
                PageMode = true // Enable to get each page converted as sperate document
            };

            // Convert and save converted Pdf documents.
            // Returns paths to the converted Pdf documents.
            var convertedDocumentPath = conversionHandler.Convert<IList<string>>(Common.inputGUIDFile, saveoptions);

            foreach (var path in convertedDocumentPath)
            {
                Console.WriteLine("{0}", path);
            }
        }

        //ExEnd:ConvertAndGetPagewiseOutputAsPaths
        #endregion

    }
}
//ExEnd:ConversionClass
