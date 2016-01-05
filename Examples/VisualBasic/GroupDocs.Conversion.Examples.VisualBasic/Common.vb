Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports GroupDocs.Conversion.Config
Imports GroupDocs.Conversion.Converter.Option
Imports GroupDocs.Conversion.Handler

Namespace GroupDocsConversionExamples.VisualBasic
    Public NotInheritable Class Common
        Private Sub New()
        End Sub
        'ExStart:CommonProperties
        Public Shared storagePath As String = Path.Combine(Environment.CurrentDirectory, "..\..\..\..\Data\SampleFiles")
        Public Shared cachePath As String = Path.Combine(Environment.CurrentDirectory, "..\..\..\..\Data\OutputFiles")
        Public Shared licensePath As String = Path.Combine(Environment.CurrentDirectory, "GroupDocs.conversion.lic")
        Public Shared inputGUIDFile As String = "DOCXsample.docx"

        Private Shared conversionConfig As ConversionConfig
        Private Shared conversionHandler As ConversionHandler

        'ExEnd:CommonProperties

        ''' <summary>
        ''' Get GroupDocs.Conversion Handler Object
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function getConversionHandler() As ConversionHandler
            If conversionConfig Is Nothing Then
                conversionConfig = New ConversionConfig()
            End If
            conversionConfig.StoragePath = storagePath
            conversionConfig.CachePath = cachePath

            If conversionHandler Is Nothing Then
                conversionHandler = New ConversionHandler(conversionConfig)
            End If

            Return conversionHandler
        End Function


        'ExStart:ApplyLicense
        ''' <summary>
        ''' Applies product license
        ''' </summary>
        Public Shared Sub ApplyLicense()
            ' apply license
            conversionHandler.SetLicense(licensePath)
        End Sub
        'ExEnd:ApplyLicense
    End Class
End Namespace
