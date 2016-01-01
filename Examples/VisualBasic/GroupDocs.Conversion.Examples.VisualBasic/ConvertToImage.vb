Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports GroupDocs.Conversion.Config
Imports GroupDocs.Conversion.Converter.Option
Imports GroupDocs.Conversion.Handler

namespace GroupDocs.Conversion.Examples.VisualBasic
    Class ConvertToImage
        ' Default Sample File Path and output path and GUID File as Input
        Public Shared storagePath As String = Path.Combine(Environment.CurrentDirectory, "..\..\Data\SampleFiles")
        Public Shared cachePath As String = Path.Combine(Environment.CurrentDirectory, "..\..\Data\OutputFiles")
        Public Shared inputGUIDFile As String = "DOCXsample.docx"
        'Public static string inputGUIDFile = "PDFsample.pdf"

        ' Result as file path
        Public Shared Sub ToImageAsPath()
            ' Setup Conversion configuration
			Dim conversionConfig = New ConversionConfig() With { _
				Key .StoragePath = storagePath, _
				Key .CachePath = cachePath _
			}

            'instantiating the conversion handler
            Dim conversionHandler = New ConversionHandler(conversionConfig)

			Dim convertedDocumentPath = conversionHandler.Convert(Of IList(Of String))(inputGUIDFile, New ImageSaveOptions() With { _
				Key .ConvertFileType = ImageSaveOptions.ImageFileType.Jpg _
			})
        End Sub

        ' Result as Stream
        Public Shared Sub ToImageAsStream()
            ' Setup Conversion configuration
			Dim conversionConfig = New ConversionConfig() With { _
				Key .StoragePath = storagePath, _
				Key .CachePath = cachePath _
			}

            'instantiating the conversion handler
            Dim conversionHandler = New ConversionHandler(conversionConfig)


			Dim convertedDocumentStream = conversionHandler.Convert(Of IList(Of Stream))(inputGUIDFile, New ImageSaveOptions() With { _
				Key .ConvertFileType = ImageSaveOptions.ImageFileType.Jpg _
			})
        End Sub

        ' Advanced example
        Public Shared Sub ToImageAdvance()
            ' Setup Conversion configuration
			Dim conversionConfig = New ConversionConfig() With { _
				Key .StoragePath = storagePath, _
				Key .CachePath = cachePath _
			}
            conversionConfig.SetUseCache(True)

            'instantiating the conversion handler
            Dim conversionHandler = New ConversionHandler(conversionConfig)

            'Set password to unprotect protected document during loading
			Dim loadOptions As New LoadOptions() With { _
				Key .Password = "secret" _
			}

            ' convert file to Tiff, starting from page 2 and convert 2 pages,
            ' use DPI 300, image width 1024, image height 768
			Dim saveOptions As SaveOptions = New ImageSaveOptions() With { _
				Key .ConvertFileType = ImageSaveOptions.ImageFileType.Tiff, _
				Key .PageNumber = 2, _
				Key .NumPagesToConvert = 2, _
				Key .Dpi = 300, _
				Key .Width = 1024, _
				Key .Height = 768 _
			}

            Dim convertedDocumentStream = conversionHandler.Convert(Of IList(Of Stream))(inputGUIDFile, loadOptions, saveOptions)
        End Sub
    End Class
End Namespace