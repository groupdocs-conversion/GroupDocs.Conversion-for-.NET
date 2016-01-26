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
            'ExStart:RenderHTMLAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' Convert and save converted HTML documents.
            ' Returns paths to the converted HTML documents.
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, New HtmlSaveOptions())
            'ExEnd:RenderHTMLAsPath
        End Sub

        ''' <summary>
        ''' Converts and Render Document as HTML format and outputs the resulting file to a stream
        ''' </summary>

        Public Shared Sub RenderHTMLAsStream()
            'ExStart:RenderHTMLAsStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' Convert and save converted HTML documents. 
            ' Returns the converted HTML documents as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, New HtmlSaveOptions())
            'ExEnd:RenderHTMLAsStream
        End Sub

        ''' <summary>
        ''' In advance options example Converts and Render Password Protected file to HTML format
        ''' </summary

        Public Shared Sub RenderHTMLAdvanceOptions()
            'ExStart:RenderHTMLAdvanceOptions
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            'Set password to unprotect protected document during loading
            Dim loadOptions As New LoadOptions()
            loadOptions.Password = "secret"

            ' convert starting from page 2 and convert 2 pages
            Dim saveOptions As SaveOptions = New HtmlSaveOptions()
            saveOptions.PageNumber = 2
            saveOptions.NumPagesToConvert = 2

            ' Unprotect input document, Convert and save HTML documents using advance options.
            ' Returns the converted HTML documents as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)
            'ExEnd:RenderHTMLAdvanceOptions
        End Sub

#End Region

#Region "Converts and Render in Image"


        ''' <summary>
        ''' Converts and Render file to an Image format and get output as file path
        ''' </summary> 
        ''' <param name="outputFileType"></param>
        Public Shared Sub RenderImageAsPath(outputFileType As ImageSaveOptions.ImageFileType)
            'ExStart:RenderImageAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' set output file type
            Dim objImageSaveOptions As New ImageSaveOptions()
            objImageSaveOptions.ConvertFileType = outputFileType

            ' Convert and save converted image file.
            ' Returns paths to the converted image file.
            Dim convertedDocumentPath = conversionHandler.Convert(Of IList(Of String))(Common.inputGUIDFile, objImageSaveOptions)
            ' ExEnd:RenderImageAsPath
        End Sub

        ''' <summary>
        ''' Converts and Render Document as Image format and outputs the resulting file to a stream
        ''' </summary>
        ''' <param name="outputFileType"></param>
        Public Shared Sub RenderImageAsStream(ByVal outputFileType As ImageSaveOptions.ImageFileType)
            'ExStart:RenderImageAsStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' set output file type
            Dim objImageSaveOptions As New ImageSaveOptions()
            objImageSaveOptions.ConvertFileType = outputFileType

            ' Convert and save converted image file. 
            ' Returns the converted image file as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of IList(Of Stream))(Common.inputGUIDFile, objImageSaveOptions)

            'ExEnd:RenderImageAsStream
        End Sub

        ''' <summary>
        ''' In advance options example Converts and Render Password Protected file to Image format
        ''' </summary>
        ''' <param name="outputFileType"></param>
        Public Shared Sub RenderImageAdvanceOptions(ByVal outputFileType As ImageSaveOptions.ImageFileType)
            'ExStart: RenderImageAdvanceOptions
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            Dim loadOptions As New LoadOptions()
            loadOptions.Password = "secret"

            ' convert file to Tiff, starting from page 2 and convert 2 pages,
            ' use DPI 300, image width 1024, image height 768
            Dim saveOptions As SaveOptions
            saveOptions = New ImageSaveOptions()
            'saveOptions.ConvertFileType = outputFileType
            saveOptions.PageNumber = 2
            saveOptions.NumPagesToConvert = 2
            'saveOptions.Dpi = 300
            'saveOptions.Width = 1024
            'saveOptions.Height = 768

            ' convert file to Tiff, starting from page 2 and convert 2 pages,
            ' use DPI 300, image width 1024, image height 768
            Dim convertedDocumentStream = conversionHandler.Convert(Of IList(Of Stream))(Common.inputGUIDFile, loadOptions, saveOptions)

            'ExEnd:RenderImageAdvanceOptions
        End Sub

#End Region
    End Class
End Namespace
