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
            Dim htmlSaveOptions As New HtmlSaveOptions()
            htmlSaveOptions.OutputType = OutputType.String
            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(Common.inputGUIDFile, htmlSaveOptions)
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
            'saveOptions.FixedLayout = True

            saveOptions.NumPagesToConvert = 2


            ' Unprotect input document, Convert and save HTML documents using advance options.
            ' Returns the converted HTML documents as IO Stream.
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(Common.inputGUIDFile, loadOptions, saveOptions)
            'ExEnd:RenderHTMLAdvanceOptions
        End Sub


        ''' <summary>
        ''' Converts and Render streamed document into a HTML formated file and get output as file path
        ''' </summary>
        Public Shared Sub RenderToHTMLFromStreamToFile()
            'ExStart:RenderToHTMLFromStreamToFile
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()



            ' Convert and save converted HTML documents.
            ' Returns paths to the converted HTML documents.
            Dim saveOptions = New HtmlSaveOptions() With { _
                 .CustomName = Common.inputGUIDFile, _
                 .PageNumber = 2, _
                 .NumPagesToConvert = 2, _
                 .UsePdf = True, _
                 .OutputType = OutputType.[String] _
            }

            ' read input document as a stream
            Dim fileStream As New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)

            Dim convertedDocumentStream = conversionHandler.Convert(Of [String])(fileStream, New HtmlSaveOptions() With { _
                 .OutputType = OutputType.[String], _
                 .CustomName = Path.GetFileNameWithoutExtension(Common.inputGUIDFile) _
            })

            fileStream.Close()
            'ExEnd:RenderToHTMLFromStreamToFile
        End Sub

        ''' <summary>
        ''' Converts and Render streamed document into a HTML formated file and get output as stream
        ''' </summary>
        Public Shared Sub RenderToHTMLFromStreamToStream()
            'ExStart:RenderToHTMLFromStreamToStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler

            ' Convert and save converted HTML documents. 
            ' Returns the converted HTML documents as IO Stream.
            ' read input document as a stream
            Dim fileStream As FileStream = New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)
            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(fileStream, New HtmlSaveOptions)

            fileStream.Close()
            'ExEnd:RenderToHTMLFromStreamToStream
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
            objImageSaveOptions.OutputType = OutputType.String

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


        ''' <summary>
        ''' Converts and Render streamed file to an Image format and get output as file path
        ''' </summary>
        ''' <param name="outputFileType"></param>
        Public Shared Sub RenderToImageFromStreamToFile(outputFileType As ImageSaveOptions.ImageFileType)
            'ExStart:RenderToImageFromStreamToFile
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()



            ' Convert and save converted image file.
            ' Returns paths to the converted image file.
            Dim saveOptions = New ImageSaveOptions() With { _
                 .ConvertFileType = ImageSaveOptions.ImageFileType.Jpeg, _
                 .OutputType = OutputType.[String] _
            }

            ' read input document as a stream
            Dim fileStream As New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)

            Dim convertedDocumentStream = conversionHandler.Convert(Of [String])(fileStream, New ImageSaveOptions() With { _
                 .OutputType = OutputType.[String], _
                 .CustomName = Path.GetFileNameWithoutExtension(Common.inputGUIDFile) _
            })

            fileStream.Close()
            'ExEnd:RenderToImageFromStreamToFile
        End Sub


        ''' <summary>
        ''' Converts and Render streamed Document as Image format and outputs the resulting file to a stream
        ''' </summary>
        ''' <param name="outputFileType"></param>
        Public Shared Sub RenderToImageFromStreamToStream(outputFileType As ImageSaveOptions.ImageFileType)
            'ExStart:RenderToImageFromStreamToStream
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()



            ' Returns the converted image file as IO Stream.
            ' read input document as a stream
            Dim fileStream As New FileStream(Path.Combine(Common.storagePath, Common.inputGUIDFile), FileMode.Open, FileAccess.Read)

            Dim convertedDocumentStream = conversionHandler.Convert(Of IList(Of Stream))(fileStream, New ImageSaveOptions() With { _
                .ConvertFileType = outputFileType _
            })

            fileStream.Close()
            'ExEnd:RenderToImageFromStreamToStream
        End Sub


        ''' <summary>
        ''' Converts and Render file to an PSD Image format and get output as file path
        ''' </summary> 
        ''' <param name="outputFileType"></param>
        Public Shared Sub RenderPSDImageAsPath()
            'ExStart:RenderPSDImageAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()



            ' Convert and save converted image file.
            ' Returns paths to the converted image file.
            Dim saveOptions As New ImageSaveOptions()
            saveOptions.ConvertFileType = ImageSaveOptions.ImageFileType.Psd
            saveOptions.OutputType = OutputType.String

            ' Psd option
            Dim psdOptions As New PsdOptions()
            psdOptions.ColorMode = psdOptions.ColorModes.Grayscale
            psdOptions.CompressionMethod = psdOptions.CompressionMethods.Raw

            ' applying Psd Options
            saveOptions.PsdOptions = psdOptions

            Dim convertedDocumentPath = conversionHandler.Convert(Of IList(Of String))(Common.inputGUIDFile, saveOptions)
            'ExEnd:RenderPSDImageAsPath
        End Sub


        ''' <summary>
        ''' Converts and Render file to an Webp format and get output as file path
        ''' </summary> 
        ''' <param name="outputFileType"></param>
        Public Shared Sub RenderWebpAsPath(outputFileType As ImageSaveOptions.ImageFileType)
            'ExStart:RenderWebpformatAsPath
            ' Instantiating the conversion handler from custom common class
            Dim conversionHandler As ConversionHandler = Common.getConversionHandler()

            ' set output file type
            Dim objImageSaveOptions As New ImageSaveOptions()
            objImageSaveOptions.ConvertFileType = outputFileType
            objImageSaveOptions.OutputType = OutputType.String

            ' Convert and save converted Webp file.
            ' Returns paths to the converted image file.
            Dim convertedDocumentPath = conversionHandler.Convert(Of IList(Of String))(Common.inputGUIDFile, objImageSaveOptions)
            ' ExEnd:RenderWebpformatAsPath
        End Sub

#End Region

    End Class
End Namespace
