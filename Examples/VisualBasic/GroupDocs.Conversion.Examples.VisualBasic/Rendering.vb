Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports GroupDocs.Conversion.Config
Imports GroupDocs.Conversion.Converter.Option
Imports GroupDocs.Conversion.Handler

Namespace GroupDocsConversionExamples.VisualBasic
    Public NotInheritable Class Rendering
        Private Sub New()
        End Sub
#Region "Converts and Render in HTML"

        ''' <summary>
        ''' Converts and Render file to a HTML format and get output as file path
        ''' </summary> 

        Public Shared Sub RenderHTMLAsPath()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, New HtmlSaveOptions())
        End Sub

        ''' <summary>
        ''' Converts and Render Document as HTML format and outputs the resulting file to a stream
        ''' </summary>

        Public Shared Sub RenderHTMLAsStream()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, New HtmlSaveOptions())
        End Sub

        ''' <summary>
        ''' In AdvanceOptions() example Converts and Render Password Protected file to HTML format
        ''' </summary

        Public Shared Sub RenderHTMLAdvanceOptions()
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            'Set password to unprotect protected document during loading
            Dim loadOptions As New LoadOptions()
            loadOptions.Password = "secret"

            ' convert starting from page 2 and convert 2 pages
            Dim saveOptions As SaveOptions = New HtmlSaveOptions()
            saveOptions.PageNumber = 2
            saveOptions.NumPagesToConvert = 2

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)
        End Sub

#End Region

#Region "Converts and Render in Image"


        ''' <summary>
        ''' Converts and Render file to an Image format and get output as file path
        ''' </summary> 
        ''' <param name="outputFileType"></param>
        Public Shared Sub RenderImageAsPath(outputFileType As ImageSaveOptions.ImageFileType)

            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' set output file type
            Dim objImageSaveOptions As New ImageSaveOptions()
            objImageSaveOptions.ConvertFileType = outputFileType

            Dim convertedDocumentPath = conversionHandler.Convert(Of IList(Of String))(Common.inputGUIDFile, objImageSaveOptions)
        End Sub

        ''' <summary>
        ''' Converts and Render Document as Image format and outputs the resulting file to a stream
        ''' </summary>
        ''' <param name="outputFileType"></param>
        Public Shared Sub RenderImageAsStream(outputFileType As ImageSaveOptions.ImageFileType)

            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' set output file type
            Dim objImageSaveOptions As New ImageSaveOptions()
            objImageSaveOptions.ConvertFileType = outputFileType

            Dim convertedDocumentStream = conversionHandler.Convert(Of IList(Of Stream))(Common.inputGUIDFile, objImageSaveOptions)
        End Sub

        ''' <summary>
        ''' In AdvanceOptions()d example Converts and Render Password Protected file to Image format
        ''' </summary>
        ''' <param name="outputFileType"></param>
        Public Shared Sub RenderImageAdvanceOptions(outputFileType As ImageSaveOptions.ImageFileType)
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim loadOptions As New LoadOptions()
            loadOptions.Password = "secret"

            ' convert file to Tiff, starting from page 2 and convert 2 pages,
            ' use DPI 300, image width 1024, image height 768
            Dim saveOptions As SaveOptions
            saveOptions = New HtmlSaveOptions()
            'saveOptions.ConvertFileType = outputFileType
            saveOptions.PageNumber = 2
            saveOptions.NumPagesToConvert = 2
            'saveOptions.Dpi = 300
            'saveOptions.Width = 1024
            'saveOptions.Height = 768

            Dim convertedDocumentStream = conversionHandler.Convert(Of IList(Of Stream))(Common.inputGUIDFile, loadOptions, saveOptions)
        End Sub

#End Region
    End Class
End Namespace
