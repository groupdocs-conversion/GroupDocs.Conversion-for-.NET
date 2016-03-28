Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports GroupDocs.Conversion.Config
Imports GroupDocs.Conversion.Converter.Option
Imports GroupDocs.Conversion.Handler

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

        Private Shared Sub ConversionProgressHandler(sender As Object, args As ConversionProgressEventArgs)
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

    End Class
End Namespace
