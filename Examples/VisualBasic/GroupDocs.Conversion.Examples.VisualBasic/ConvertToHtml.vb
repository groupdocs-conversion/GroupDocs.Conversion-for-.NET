Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports GroupDocs.Conversion.Config
Imports GroupDocs.Conversion.Converter.Option
Imports GroupDocs.Conversion.Handler

namespace GroupDocs.Conversion.Examples.VisualBasic
    Class ConvertToHtml
        ' Default Sample File Path and output path and GUID File as Input
        Public Shared storagePath As String = Path.Combine(Environment.CurrentDirectory, "..\..\Data\SampleFiles")
        Public Shared cachePath As String = Path.Combine(Environment.CurrentDirectory, "..\..\Data\OutputFiles")
        Public Shared inputGUIDFile As String = "DOCXsample.docx"
        'Public static string inputGUIDFile = "PDFsample.pdf"

        ' Result as file path
        Public Shared Sub ToHTMLAsPath()
            ' Setup Conversion configuration
			Dim conversionConfig = New ConversionConfig() With { _
				Key .StoragePath = storagePath, _
				Key .CachePath = cachePath _
			}

            'instantiating the conversion handler
            Dim conversionHandler = New ConversionHandler(conversionConfig)

            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(inputGUIDFile, New HtmlSaveOptions())
        End Sub

        ' Result as Stream
        Public Shared Sub ToHTMLAsStream()
            ' Setup Conversion configuration
			Dim conversionConfig = New ConversionConfig() With { _
				Key .StoragePath = storagePath, _
				Key .CachePath = cachePath _
			}

            'instantiating the conversion handler
            Dim conversionHandler = New ConversionHandler(conversionConfig)

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(inputGUIDFile, New HtmlSaveOptions())
        End Sub

        ' Advanced example
        Public Shared Sub ToHTMLAdvance()
            ' Setup Conversion configuration
			Dim conversionConfig = New ConversionConfig() With { _
				Key .StoragePath = storagePath, _
				Key .CachePath = cachePath _
			}
            ' cache converted file
            conversionConfig.SetUseCache(True)

            'instantiating the conversion handler
            Dim conversionHandler = New ConversionHandler(conversionConfig)

            'Set password to unprotect protected document during loading
			Dim loadOptions As New LoadOptions() With { _
				Key .Password = "rizwan" _
			}

            ' convert starting from page 2 and convert 2 pages
			Dim saveOptions As SaveOptions = New HtmlSaveOptions() With { _
				Key .PageNumber = 2, _
				Key .NumPagesToConvert = 2 _
			}

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(inputGUIDFile, LoadOptions, SaveOptions)
        End Sub
    End Class
End Namespace