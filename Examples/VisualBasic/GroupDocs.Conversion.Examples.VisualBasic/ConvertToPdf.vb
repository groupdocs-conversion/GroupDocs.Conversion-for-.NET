Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports GroupDocs.Conversion.Config
Imports GroupDocs.Conversion.Converter.Option
Imports GroupDocs.Conversion.Handler

namespace GroupDocs.Conversion.Examples.VisualBasic
    Class ConvertToPdf
        ' Default Sample File Path and output path and GUID File as Input
        Public Shared storagePath As String = Path.Combine(Environment.CurrentDirectory, "..\..\Data\SampleFiles")
        Public Shared cachePath As String = Path.Combine(Environment.CurrentDirectory, "..\..\Data\OutputFiles")
        Public Shared inputGUIDFile As String = "DOCXsample.docx"
        'Public static string inputGUIDFile = "PDFsample.pdf"

        ' Result as file path
        Public Shared Sub ToPdfAsPath()
            ' Setup Conversion configuration
			Dim conversionConfig = New ConversionConfig() With { _
				Key .StoragePath = storagePath, _
				Key .CachePath = cachePath _
			}

            'instantiating the conversion handler
            Dim conversionHandler = New ConversionHandler(conversionConfig)

            Dim convertedDocumentPath = conversionHandler.Convert(Of String)(inputGUIDFile, New PdfSaveOptions())
        End Sub

        ' Result as Stream
        Public Shared Sub ToPdfAsStream()
            ' Setup Conversion configuration
			Dim conversionConfig = New ConversionConfig() With { _
				Key .StoragePath = storagePath, _
				Key .CachePath = cachePath _
			}

            'instantiating the conversion handler
            Dim conversionHandler = New ConversionHandler(conversionConfig)


            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(inputGUIDFile, New PdfSaveOptions())
        End Sub

        ' Advanced example
        Public Shared Sub ToPdfAdvance()
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

            ' convert starting from page 2 and convert 2 pages,
            ' use DPI 300, page width 1024, page height 768
			Dim saveOptions As SaveOptions = New PdfSaveOptions() With { _
				Key .PageNumber = 2, _
				Key .NumPagesToConvert = 2, _
				Key .Dpi = 300, _
				Key .Width = 1024, _
				Key .Height = 768 _
			}

            Dim convertedDocumentStream = conversionHandler.Convert(Of Stream)(inputGUIDFile, loadOptions, saveOptions)
        End Sub
    End Class
End Namespace