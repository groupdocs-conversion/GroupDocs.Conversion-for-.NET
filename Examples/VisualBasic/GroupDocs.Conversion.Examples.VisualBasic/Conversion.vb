'ExStart:ConversionClass
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports GroupDocs.Conversion.Config
Imports GroupDocs.Conversion.Converter.Option
Imports GroupDocs.Conversion.Handler
Imports System.Drawing

Namespace GroupDocsConversionExamples.VisualBasic
    Public NotInheritable Class Conversion
        Private Sub New()
        End Sub
        Public Shared inputGUIDFile As String = "DOCXsample.docx"

#Region "Convert to Spreadsheet Document"

        ''' <summary>
        ''' Convert file  Spreadsheet Document formats and get output as file path
        ''' </summary> 
        Public Shared Sub ConvertToSpreadsheetAsPath()
            'ExStart:ConvertToSpreadsheetAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandlerUsingCache(True)

            'Convert and save converted spreadsheet documents.
            'Returns paths to the converted spreadsheet documents.

            Dim cellsSaveOptions As New CellsSaveOptions()
            cellsSaveOptions.OutputType = OutputType.String
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, cellsSaveOptions)

            'ExEnd:ConvertToSpreadsheetAsPath
        End Sub


        ''' <summary>
        ''' Convert file  Spreadsheet Document formats and enable GridLines and get output as file path
        ''' </summary> 
        Public Shared Sub ConvertToSpreadsheetWithGridLinesAsPath()
            'ExStart:ConvertToSpreadsheetWithGridLinesAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' Save options
            ' display border for each all cells
            Dim saveOptions As New CellsSaveOptions()
            saveOptions.OutputType = OutputType.String
            saveOptions.ShowGridLines = True

            ' Convert and save converted spreadsheet documents.
            ' Returns paths to the converted spreadsheet documents.
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, saveOptions)
            'ExEnd:ConvertToSpreadsheetWithGridLinesAsPath
        End Sub

        ''' <summary>
        ''' Convert file  Spreadsheet Document formats and use hidden sheets and get output as file path
        ''' </summary> 
        Public Shared Sub ConvertToSpreadsheetEnableHiddenSheetsAsPath()
            'ExStart:ConvertToSpreadsheetEnableHiddenSheetsAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' Save options
            ' use hidden sheets
            Dim saveOptions As New CellsSaveOptions()
            saveOptions.OutputType = OutputType.String
            saveOptions.ShowHiddenSheets = True

            ' Convert and save converted spreadsheet documents.
            ' Returns paths to the converted spreadsheet documents.
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, saveOptions)
            'ExEnd:ConvertToSpreadsheetEnableHiddenSheetsAsPath
        End Sub

        ''' <summary>
        ''' Converts documents to Spreadsheet Document formats and outputs the resulting document to a stream
        ''' </summary> 
        Public Shared Sub ConvertToSpreadsheetStream()
            'ExStart: ConvertToSpreadsheetStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandlerUsingCache(True)

            'Convert and save converted spreadsheet documents. 
            'Returns the converted spreadsheet documents as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, New CellsSaveOptions())

            'ExEnd:ConvertToSpreadsheetStream
        End Sub

        ''' <summary>
        ''' In advance options example Convert Password Protected file to Spreadsheet Document formats 
        ''' </summary>

        Public Shared Sub ConvertToSpreadsheetAdvanceOptions()
            'ExStart:ConvertToSpreadsheetAdvanceOptions
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandlerUsingCache(True)

            'Set password to unprotect protected document during loading
            Dim loadOptions As New LoadOptions()
            loadOptions.Password = "secret"

            ' convert file to Xls, starting from page 2 and convert 2 pages
            Dim saveOptions As New CellsSaveOptions()
            saveOptions.ConvertFileType = CellsSaveOptions.CellsFileType.Xls
            saveOptions.PageNumber = 2
            saveOptions.NumPagesToConvert = 2

            ' Unprotect input document, Convert and save spreadsheet documents using advance options.
            ' Returns the converted spreadsheet documents as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)

            'ExEnd:ConvertToSpreadsheetAdvanceOptions
        End Sub


        ''' <summary>
        ''' Converts stream input documents to Spreadsheet Document formats and outputs the resulting document to a file path
        ''' </summary>

        Public Shared Sub ConvertToSpreadsheetFromStreamToFile()
            'ExStart:ConvertToSpreadsheetFromStreamToFile
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' read input document as a stream
            Dim fileStream As New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)

            ' Returns the converted spreadsheet documents as File Path using stream input.
            Dim convertedDocumentStream = conversionHandler.Convert(Of [String])(fileStream, New CellsSaveOptions() With { _
                 .OutputType = OutputType.[String], _
                 .CustomName = Path.GetFileNameWithoutExtension(Common.inputGUIDFile) _
            })

            fileStream.Close()
            'ExEnd:ConvertToSpreadsheetFromStreamToFile
        End Sub

        ''' <summary>
        ''' Converts stream input documents to Spreadsheet Document formats and outputs the resulting document to a stream
        ''' </summary>

        Public Shared Sub ConvertToSpreadsheetFromStreamToStream()
            'ExStart:ConvertToSpreadsheetFromStreamToStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' read input document as a stream
            Dim fileStream As New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)

            ' Returns the converted spreadsheet documents as IO Stream using stream input.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(fileStream, New CellsSaveOptions())
            fileStream.Close()
            'ExEnd:ConvertToSpreadsheetFromStreamToStream
        End Sub


#End Region

#Region "Convert to Word Processing Document"


        ''' <summary>
        ''' Convert file to Word Processing Document format and get output as file path
        ''' </summary> 

        Public Shared Sub ConvertToWordDocumentAsPath()
            ' ExStart:ConvertToWordDocumentAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            'Convert and save converted word processing documents.
            'Returns paths to the converted word processing documents.

            Dim wordsSaveOptions As New WordsSaveOptions()
            wordsSaveOptions.OutputType = OutputType.String

            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, wordsSaveOptions)

            ' ExEnd:ConvertToWordDocumentAsPath
        End Sub


        ''' <summary>
        ''' Converts documents to Word Processing Document formats and outputs the resulting document to a stream
        ''' </summary>

        Public Shared Sub ConvertToWordDocumentAsStream()
            ' ExStart:ConvertToWordDocumentAsStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            'Convert and save converted word processing documents. 
            'Returns the converted word processing documents as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, New WordsSaveOptions())

            'ExEnd:ConvertToWordDocumentAsStream
        End Sub

        ''' <summary>
        ''' In advance options example Convert Password Protected file to Word Processing Document format
        ''' </summary>

        Public Shared Sub ConvertToWordDocumentAdvanceOptions()
            'ExStart:ConvertToWordDocumentAdvanceOptions
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            'Set password to unprotect protected document during loading
            Dim loadOptions As New LoadOptions()
            loadOptions.Password = "secret"

            ' convert file to Doc, starting from page 2 and convert 2 pages,
            Dim saveOptions As New WordsSaveOptions()
            saveOptions.ConvertFileType = WordsSaveOptions.WordsFileType.Doc
            saveOptions.PageNumber = 2
            saveOptions.NumPagesToConvert = 2

            'Unprotect input document, Convert and save word processing documents using advance options.
            'Returns the converted word processing documents as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)

            'ExEnd:ConvertToWordDocumentAdvanceOptions

        End Sub


        ''' <summary>
        ''' Converts stream input documents to Word Processing Document formats and outputs the resulting document to a file path
        ''' </summary>
        Public Shared Sub ConvertToWordFromStreamToFile()
            'ExStart:ConvertToWordFromStreamToFile
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' read input document as a stream
            Dim fileStream As New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)

            ' Returns the converted Word Processing Documents as File Path using stream input.
            Dim convertedDocumentStream = conversionHandler.Convert(Of [String])(fileStream, New WordsSaveOptions() With { _
                 .OutputType = OutputType.[String], _
                 .CustomName = Path.GetFileNameWithoutExtension(Common.inputGUIDFile) _
            })

            fileStream.Close()
            'ExEnd:ConvertToWordFromStreamToFile
        End Sub

        ''' <summary>
        ''' Converts stream input documents to Word Proccessing Document formats and outputs the resulting document to a stream
        ''' </summary>
        Public Shared Sub ConvertToWordFromStreamToStream()
            'ExStart:ConvertToWordFromStreamToStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' read input document as a stream
            Dim fileStream As New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)

            ' Returns the converted Word Processing Documents as IO Stream using stream input.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(fileStream, New WordsSaveOptions())
            fileStream.Close()
            'ExEnd:ConvertToWordFromStreamToStream
        End Sub

        ''' <summary>
        ''' In advance options example Convert Password Protected file to Word Processing Document format with show/hide track changes 
        ''' </summary>

        Public Shared Sub ConvertToWordDocumentAdvanceOptionswithtrackchanges()
            'ExStart:ConvertToWordDocumentAdvanceOptions
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            'Set password to unprotect protected document during loading
            Dim loadOptions As New LoadOptions()
            loadOptions.Password = "secret"

            ' convert file to Doc, starting from page 2 and convert 2 pages,
            Dim saveOptions As New WordsSaveOptions()
            saveOptions.ConvertFileType = WordsSaveOptions.WordsFileType.Doc
            saveOptions.PageNumber = 2
            saveOptions.NumPagesToConvert = 2
            saveOptions.HideWordTrackedChanges = True

            'Unprotect input document, Convert and save word processing documents using advance options show/hide track changes.
            'Returns the converted word processing documents as IO Stream show/hide track changes.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)

            'ExEnd:ConvertToWordDocumentAdvanceOptionswithtrackchanges

        End Sub


#End Region

#Region "Convert to Pdf"

        ''' <summary>
        ''' Convert file to Pdf format and get output as file path
        ''' </summary>

        Public Shared Sub ConvertToPdfAsPath()
            'ExStart:ConvertToPdfAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' Convert and save converted Pdf documents.
            ' Returns paths to the converted Pdf documents.
            Dim pdfSaveOptions As New PdfSaveOptions()
            pdfSaveOptions.OutputType = OutputType.String
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, pdfSaveOptions)

            'ExEnd:ConvertToPdfAsPath
        End Sub

        ''' <summary>
        ''' Converts documents to Pdf Document formats and outputs the resulting document to a stream
        ''' </summary>

        Public Shared Sub ConvertToPdfAsStream()
            'ExStart:ConvertToPdfAsStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' Convert and save converted Pdf documents. 
            ' Returns the converted spreadsheet Pdf as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, New PdfSaveOptions())

            'ExEnd:ConvertToPdfAsStream
        End Sub

        ''' <summary>
        ''' In advance options example Convert Password Protected file to Pdf format
        ''' </summary>        
        Public Shared Sub ConvertToPdfAdvanceOptions()
            'ExStart: ConvertToPdfAdvanceOptions
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            'Set password to unprotect protected document during loading
            Dim loadOptions As New LoadOptions()
            loadOptions.Password = "secret"

            ' convert starting from page 2 and convert 2 pages,
            ' use DPI 300, page width 1024, page height 768
            Dim saveOptions As New PdfSaveOptions()
            saveOptions.PageNumber = 2
            saveOptions.NumPagesToConvert = 2
            saveOptions.Dpi = 300
            saveOptions.Width = 1024
            saveOptions.Height = 768

            ' Unprotect input document, Convert and save Pdf documents using advance options.
            ' Returns the converted spreadsheet Pdf as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)

            'ExEnd:ConvertToPdfAdvanceOptions
        End Sub


        ''' <summary>
        ''' Converts stream input documents to pdf Document formats and outputs the resulting document to a file path
        ''' </summary>
        Public Shared Sub ConvertToPdfFromStreamToFile()
            'ExStart:ConverToPdfFromStreamToFile
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' read input document as a stream
            Dim fileStream As New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)

            ' Returns the converted pdf documents as File Path using stream input.
            Dim convertedDocumentStream = conversionHandler.Convert(Of [String])(fileStream, New PdfSaveOptions() With { _
                 .OutputType = OutputType.[String], _
                 .CustomName = Path.GetFileNameWithoutExtension(Common.inputGUIDFile) _
            })

            fileStream.Close()
            'ExEnd:ConverToPdfFromStreamToFile
        End Sub

        ''' <summary>
        ''' Converts stream input documents to pdf Document formats and outputs the resulting document to a stream
        ''' </summary>
        Public Shared Sub ConvertToPdfFromStreamToStream()
            'ExStart:ConvertToPdfFromStreamToStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' read input document as a stream
            Dim fileStream As New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)

            ' Returns the converted pdf documents as IO Stream using stream input.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(fileStream, New PdfSaveOptions())
            fileStream.Close()
            'ExEnd:ConvertToPdfFromStreamToStream
        End Sub


#End Region

#Region "Convert to Presentation Document"

        ''' <summary>
        ''' Convert file to Presentation Document format and get output as file path
        ''' </summary>
        Public Shared Sub ConvertToPresentationAsPath()
            'ExStart:ConvertToPresentationAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' Convert and save converted presentation documents.
            ' Returns paths to the converted presentation documents.

            Dim slidesSaveOptions As New SlidesSaveOptions()
            slidesSaveOptions.OutputType = OutputType.String

            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, slidesSaveOptions)
            'ExEnd:ConvertToPresentationAsPath
        End Sub

        ''' <summary>
        ''' Converts documents to Presentation Document format and outputs the resulting document to a stream
        ''' </summary>
        Public Shared Sub ConvertToPresentationAsStream()
            'ExStart: ConvertToPresentationAsStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' Convert and save converted presentation documents. 
            ' Returns the converted presentation documents as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, New SlidesSaveOptions())

            'ExEnd:ConvertToPresentationAsStream
        End Sub

        ''' <summary>
        ''' In advance options example Convert Password Protected file to Presentation Document format
        ''' </summary>

        Public Shared Sub ConvertToPresentationAdvanceOptions()
            'ExStart: ConvertToPresentationAdvanceOptions
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            'Set password to unprotect protected document during loading
            Dim loadOptions As New LoadOptions()
            loadOptions.Password = "secret"

            ' convert file to Ppt, starting from page 2 and convert 2 pages,
            ' use DPI 300, image width 1024, image height 768
            Dim saveOptions As New SlidesSaveOptions()
            saveOptions.ConvertFileType = SlidesSaveOptions.SlidesFileType.Ppt
            saveOptions.PageNumber = 2
            saveOptions.NumPagesToConvert = 2

            ' Unprotect input document, Convert and save presentation documents using advance options.
            ' Returns the converted presentation documents as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)

            'ExEnd:ConvertToPresentationAdvanceOptions
        End Sub


        ''' <summary>
        ''' Converts stream input documents to Presentation Document formats and outputs the resulting document to a file path
        ''' </summary>
        Public Shared Sub ConvertToPresentationFromStreamToFile()
            'ExStart:ConvertToPresentationFromStreamToFile
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' read input document as a stream
            Dim fileStream As New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)

            ' Returns the converted presentation documents as File Path using stream input.
            Dim convertedDocumentStream = conversionHandler.Convert(Of [String])(fileStream, New SlidesSaveOptions() With { _
                 .OutputType = OutputType.[String], _
                 .CustomName = Path.GetFileNameWithoutExtension(Common.inputGUIDFile) _
            })

            fileStream.Close()
            'ExEnd:ConvertToPresentationFromStreamToFile
        End Sub

        ''' <summary>
        ''' Converts stream input documents to Presentation Document formats and outputs the resulting document to a stream
        ''' </summary>
        Public Shared Sub ConvertToPresentationFromStreamToStream()
            'ExStart:ConvertToPresentationFromStreamToStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' read input document as a stream
            Dim fileStream As New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)

            ' Returns the converted presentation documents as IO Stream using stream input.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(fileStream, New SlidesSaveOptions())
            fileStream.Close()
            'ExEnd:ConvertToPresentationFromStreamToStream
        End Sub

        ''' <summary>
        ''' Convert file to Presentation Document format and remove comments and get output as file path
        ''' </summary>
        Public Shared Sub ConvertToPresentationWithoutCommentsAsPath()
            'ExStart:ConvertToPresentationWithoutCommentsAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' Convert and save converted presentation documents.
            ' Returns paths to the converted presentation documents.

            Dim slidesSaveOptions As New SlidesSaveOptions()
            slidesSaveOptions.OutputType = OutputType.String
            slidesSaveOptions.RemoveSlidesComments = True ' removes all slide comments

            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, slidesSaveOptions)
            'ExEnd:ConvertToPresentationWithoutCommentsAsPath
        End Sub

#End Region


#Region "Convert and Get Processing Progress"

        ''' <summary>
        ''' Convert file to Pdf format and get output as file path and get processing progress
        ''' </summary>

        'ExStart:ConvertToPdfWithProgressAsPath
        Public Shared Sub ConvertToPdfWithProgressAsPath()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' attach Conversion Progress Handler
            AddHandler conversionHandler.ConversionProgress, AddressOf ConversionProgressHandler

            ' Convert and save converted Pdf documents.
            ' Returns paths to the converted Pdf documents.
            Dim pdfSaveOptions As New PdfSaveOptions()
            pdfSaveOptions.OutputType = OutputType.String
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, pdfSaveOptions)

            Console.WriteLine("The conversion finished. The result can be located here: {0}. Press <<ENTER>> to exit.", convertedDocumentPath)
            Console.ReadLine()
        End Sub

        Private Shared Sub ConversionProgressHandler(args As ConversionProgressEventArgs)
            Console.WriteLine("Conversion progress: {0}", args.Progress)
        End Sub

        'ExEnd:ConvertToPdfWithProgressAsPath
#End Region


#Region "Get Available Save Options for a Document by Extenssion"

        ''' <summary>
        ''' Get Available Save Options for a Document by Extenssion
        ''' </summary>

        Public Shared Sub GetAvailableSaveOptionsByExtenssion()
            'ExStart:GetAvailableSaveOptionsByExtenssion
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim documentExtension = Path.GetExtension(Common.inputGUIDFile).TrimStart("."c)
            Dim availableConversions = conversionHandler.GetSaveOptions(documentExtension)

            'returns IDictionary<string, SaveOptions>
            'list all available conversions
            Console.WriteLine("*** Available Save Options ***")
            For Each name As String In availableConversions.Keys
                Console.WriteLine(name)
            Next
            'use prepared save option for ToPdf conversion
            Dim result = conversionHandler.Convert(Of String)(Common.inputGUIDFile, availableConversions("pdf"))
            'ExEnd:ConvertToPdfWithProgressAsPath
        End Sub

#End Region


#Region "Convert and Get Processing Status of ConversionStart, ConversionProgress, ConversionComplete events"

        ''' <summary>
        ''' Convert file to Pdf format and get output as file path and get Status of ConversionStart, ConversionProgress, ConversionComplete events
        ''' </summary>

        'ExStart:ConvertToPdfWithProgressStatusAsPath
        Public Shared Sub ConvertToPdfWithProgressStatusAsPath()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' attach ConversionStart event
            AddHandler conversionHandler.ConversionStart, AddressOf ConversionStartEvent

            ' attach ConversionProgress event
            AddHandler conversionHandler.ConversionProgress, AddressOf ConversionProgressEvent

            ' attach ConversionComplete event
            AddHandler conversionHandler.ConversionComplete, AddressOf ConversionCompleteEvent

            ' Save options
            Dim saveoptions As New PdfSaveOptions()
            saveoptions.OutputType = OutputType.String

            ' Convert and save converted Pdf documents.
            ' Returns paths to the converted Pdf documents.
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, saveoptions)
        End Sub

        Private Shared Sub ConversionStartEvent(args As ConversionStartEventArgs)
            Console.WriteLine("Conversion {0} started", args.ConversionGuid)
        End Sub

        Private Shared Sub ConversionProgressEvent(args As ConversionProgressEventArgs)
            Console.WriteLine("Conversion {0} progress: {1} %", args.ConversionGuid, args.Progress)
        End Sub

        Private Shared Sub ConversionCompleteEvent(args As ConversionCompleteEventArgs)
            Console.WriteLine("Conversion {0} completed", args.ConversionGuid)
            Console.WriteLine("Result document is {0}. Cache is {1}", args.ConversionType, If(args.UsedCache, "used", "not used"))
            Console.WriteLine("Result document has {0} page(s).", DirectCast(args, PdfConversionCompleteEventArgs).PageCount)

        End Sub

        'ExEnd:ConvertToPdfWithProgressStatusAsPath
#End Region

#Region "Convert file and get output as file path using Custom Input Data Handler"

        ''' <summary>
        ''' Convert file and get output as file path using Custom Input Data Handler
        ''' </summary>

        'ExStart:ConvertWithCustomInputDataHandler
        Public Shared Sub ConvertWithCustomInputDataHandler()
            ' Creating new ConversionConfig class object with input and output files directory path
            Dim conversionConfig As New ConversionConfig()
            conversionConfig.StoragePath = Common.storagePath
            conversionConfig.CachePath = Common.cachePath
            conversionConfig.OutputPath = Common.outputPath

            ' Instantiating the conversion handler from custom input data handler class
            Dim inputDataHandler = New CustomInputDataHandler()
            Dim conversionHandler = New ConversionHandler(conversionConfig, inputDataHandler)

            ' Save options
            Dim saveoptions As New PdfSaveOptions()
            saveoptions.OutputType = OutputType.String

            ' Convert and save converted Pdf documents.
            ' Returns paths to the converted Pdf documents.
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, saveoptions)
        End Sub

        'ExEnd:ConvertWithCustomInputDataHandler
#End Region

#Region "Convert file and get output as file path using Custom Output Data Handler"

        ''' <summary>
        ''' Convert file and get output as file path using Custom Output Data Handler
        ''' </summary>

        'ExStart:ConvertWithCustomOutputDataHandler
        Public Shared Sub ConvertWithCustomOutputDataHandler()
            ' Creating new ConversionConfig class object with input and output files directory path
            Dim conversionConfig As New ConversionConfig()
            conversionConfig.StoragePath = Common.storagePath
            conversionConfig.CachePath = Common.cachePath
            conversionConfig.OutputPath = Common.outputPath

            ' Instantiating the conversion handler from custom output data handler class
            Dim outputDataHandler = New CustomOutputDataHandler(conversionConfig)
            Dim conversionHandler = New ConversionHandler(conversionConfig, outputDataHandler)

            ' Save options
            Dim saveoptions As New PdfSaveOptions()
            saveoptions.OutputType = OutputType.String

            ' Convert and save converted Pdf documents.
            ' Returns paths to the converted Pdf documents.
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, saveoptions)

            Console.WriteLine("The conversion finished. The result can be located here: {0}. Press <<ENTER>> to exit.", convertedDocumentPath)
        End Sub

        'ExEnd:ConvertWithCustomOutputDataHandler
#End Region

#Region "Convert file and get Output as file path using Custom Cache Data Handler"

        ''' <summary>
        ''' Convert file and get Output as file path using Custom Cache Data Handler
        ''' </summary>

        'ExStart:ConvertWithCustomCacheDataHandler
        Public Shared Sub ConvertWithCustomCacheDataHandler()
            ' Creating new ConversionConfig class object with input and output files directory path
            Dim conversionConfig As New ConversionConfig()
            conversionConfig.StoragePath = Common.storagePath
            conversionConfig.CachePath = Common.cachePath
            conversionConfig.OutputPath = Common.outputPath
            conversionConfig.UseCache = True

            ' Instantiating the conversion handler from custom cache data handler class
            Dim cacheDataHandler = New CustomCacheDataHandler(conversionConfig)
            Dim conversionHandler = New ConversionHandler(conversionConfig, cacheDataHandler)

            ' Save options
            Dim saveoptions As New PdfSaveOptions()
            saveoptions.OutputType = OutputType.String

            ' Convert and save converted Pdf documents.
            ' Returns paths to the converted Pdf documents.
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, saveoptions)

        End Sub

        'ExEnd:ConvertWithCustomCacheDataHandler
#End Region

#Region "Convert file and add watermark into output file"

        ''' <summary>
        ''' Convert file and add watermark into output file
        ''' </summary>

        'ExStart:ConvertAndAddWaterMarkAsPath
        Public Shared Sub ConvertAndAddWaterMarkAsPath()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' watermark options object
            Dim watermarkOptions As New WatermarkOptions("Watermark text")
            watermarkOptions.Color = Color.Blue
            watermarkOptions.Font = New Font("Arial", 40)
            watermarkOptions.RotationAngle = 45
            watermarkOptions.Transparency = 0.1
            watermarkOptions.Left = 200
            watermarkOptions.Top = 400

            ' save option with watermark property
            Dim saveoptions As New PdfSaveOptions()
            saveoptions.OutputType = OutputType.String

            ' applying watermark Options
            saveoptions.WatermarkOptions = watermarkOptions

            ' Convert and save converted Pdf documents.
            ' Returns paths to the converted Pdf documents.
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, saveoptions)

            Console.WriteLine("The conversion finished. The result can be located here: {0}. Press <<ENTER>> to exit.", convertedDocumentPath)
            Console.ReadLine()
        End Sub

        'ExEnd:ConvertAndAddWaterMarkAsPath
#End Region

#Region "Convert file using Conversion Listners Interfaces"

        ''' <summary>
        ''' Convert file using Conversion Listners Interfaces
        ''' </summary>

        'ExStart:ConvertUsingConversionLitenerAnddInterfaces
        Public Shared Sub ConvertUsingConversionLitenerAnddInterfaces()
            ' Instantiating the conversion handler from custom common class
            Dim manager = New ConversionManager(Common.storagePath)
            Dim result = manager.Convert(Common.inputGUIDFile)
            Console.WriteLine(result)
        End Sub

        'ExEnd:ConvertUsingConversionLitenerAnddInterfaces
#End Region

#Region "Convert and Get Pagewise output"

        ''' <summary>
        ''' Convert and Get Pagewise output
        ''' </summary>

        'ExStart:ConvertAndGetPagewiseOutputAsPaths
        Public Shared Sub ConvertAndGetPagewiseOutputAsPaths()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' Note: when using PageMode expected result is either IList<string> or IList<Stream> depending
            ' of used OutputType in save options provided
            ' Enable to get each page converted as sperate document
            ' Save options
            Dim saveoptions As New PdfSaveOptions()
            saveoptions.OutputType = OutputType.String
            saveoptions.PageMode = True ' Enables pagewise seprate output file in Array of list

            ' Convert and save converted Pdf documents.
            ' Returns paths to the converted Pdf documents.
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, saveoptions)

            For Each path As String In convertedDocumentPath
                Console.WriteLine("{0}", path)
            Next
        End Sub

        'ExEnd:ConvertAndGetPagewiseOutputAsPaths
#End Region

    End Class
End Namespace
'ExEnd:ConversionClass
