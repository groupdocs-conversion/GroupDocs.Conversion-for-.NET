'ExStart:CommonClass
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
        ' storagePath property to set input file/s directory
        Public Shared storagePath As String = Path.Combine(Environment.CurrentDirectory, "..\..\..\..\Data\SampleFiles")

        ' cachePath property to set output file/s directory
        Public Shared cachePath As String = Path.Combine(Environment.CurrentDirectory, "..\..\..\..\Data\OutputFiles")

        ' licensePath property to set GroupDocs.Conversion license file anme and path
        Public Shared licensePath As String = Path.Combine(Environment.CurrentDirectory, "GroupDocs.conversion.lic")

        ' inputGUIDFile property to set input file
        Public Shared inputGUIDFile As String = "DOCXsample.docx"

        ' Declare ConversionConfig class object
        Private Shared conversionConfig As ConversionConfig

        ' Declare ConversionHandler class object
        Private Shared conversionHandler As ConversionHandler

        'ExEnd:CommonProperties

        'ExStart:getConversionHandler
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
        'ExEnd:getConversionHandler

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
'ExEnd:CommonClass