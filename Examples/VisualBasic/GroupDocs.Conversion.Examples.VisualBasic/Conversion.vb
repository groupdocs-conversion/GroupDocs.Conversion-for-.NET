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
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            'Convert and save converted spreadsheet documents.
            'Returns paths to the converted spreadsheet documents.
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, New CellsSaveOptions())

            'ExEnd:ConvertToSpreadsheetAsPath
        End Sub

        ''' <summary>
        ''' Converts documents to Spreadsheet Document formats and outputs the resulting document to a stream
        ''' </summary> 
        Public Shared Sub ConvertToSpreadsheetStream()
            'ExStart: ConvertToSpreadsheetStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

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
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

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
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, New WordsSaveOptions())

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

            'ExEnd: ConvertToWordDocumentAsStream
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

            'ExStart:ConvertToWordDocumentAdvanceOptions

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
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, New PdfSaveOptions())

            'ExEnd:ConvertToPdfAsStream
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

            'ExEnd: ConvertToPdfAdvanceOptions
        End Sub

#End Region

#Region "Convert to Presentation Document"

        ''' <summary>
        ''' Convert file to Presentation Document format and get output as file path
        ''' </summary>
        Public Shared Sub ConvertToPresentationAsPath()
            'ExSrart: ConvertToPresentationAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' Convert and save converted presentation documents.
            ' Returns paths to the converted presentation documents.

            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, New SlidesSaveOptions())
            'ExEnd: ConvertToPresentationAsPath
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

            'ExEnd: ConvertToPresentationAsStream
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

            'ExEnd: ConvertToPresentationAdvanceOptions
        End Sub


#End Region
    End Class
End Namespace
