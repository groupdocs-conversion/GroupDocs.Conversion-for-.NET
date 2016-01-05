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
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, New CellsSaveOptions())
        End Sub

        ''' <summary>
        ''' Converts documents to Spreadsheet Document formats and outputs the resulting document to a stream
        ''' </summary> 
        Public Shared Sub ConvertToSpreadsheetStream()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, New CellsSaveOptions())
        End Sub

        ''' <summary>
        ''' In AdvanceOptions()d example Convert Password Protected file to Spreadsheet Document formats 
        ''' </summary>

        Public Shared Sub ConvertToSpreadsheetAdvanceOptions()
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

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)
        End Sub

#End Region

#Region "Convert to Word Processing Document"


        ''' <summary>
        ''' Convert file to Word Processing Document format and get output as file path
        ''' </summary> 

        Public Shared Sub ConvertToWordDocumentAsPath()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, New WordsSaveOptions())
        End Sub


        ''' <summary>
        ''' Converts documents to Word Processing Document formats and outputs the resulting document to a stream
        ''' </summary>

        Public Shared Sub ConvertToWordDocumentAsStream()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, New WordsSaveOptions())
        End Sub

        ''' <summary>
        ''' In AdvanceOptions()d example Convert Password Protected file to Word Processing Document format
        ''' </summary>

        Public Shared Sub ConvertToWordDocumentAdvanceOptions()
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

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)
        End Sub

#End Region

#Region "Convert to Pdf"

        ''' <summary>
        ''' Convert file to Pdf format and get output as file path
        ''' </summary>

        Public Shared Sub ConvertToPdfAsPath()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, New PdfSaveOptions())
        End Sub

        ''' <summary>
        ''' Converts documents to Pdf Document formats and outputs the resulting document to a stream
        ''' </summary>

        Public Shared Sub ConvertToPdfAsStream()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, New PdfSaveOptions())
        End Sub

        ''' <summary>
        ''' In AdvanceOptions()d example Convert Password Protected file to Pdf format
        ''' </summary>        
        Public Shared Sub ConvertToPdfAdvanceOptions()
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

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)
        End Sub

#End Region

#Region "Convert to Presentation Document"

        ''' <summary>
        ''' Convert file to Presentation Document format and get output as file path
        ''' </summary>
        Public Shared Sub ConvertToPresentationAsPath()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, New SlidesSaveOptions())
        End Sub

        ''' <summary>
        ''' Converts documents to Presentation Document format and outputs the resulting document to a stream
        ''' </summary>
        Public Shared Sub ConvertToPresentationAsStream()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, New SlidesSaveOptions())
        End Sub

        ''' <summary>
        ''' In AdvanceOptions()d example Convert Password Protected file to Presentation Document format
        ''' </summary>

        Public Shared Sub ConvertToPresentationAdvanceOptions()
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

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)
        End Sub


#End Region
    End Class
End Namespace
