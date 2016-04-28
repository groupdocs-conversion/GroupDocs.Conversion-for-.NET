'ExStart:ConversionManagerWithInterfaceClass
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports GroupDocs.Conversion.Config
Imports GroupDocs.Conversion.Converter.Option
Imports GroupDocs.Conversion.Handler

Namespace GroupDocsConversionExamples.VisualBasic
    Public NotInheritable Class ConversionManager
        Implements IConversionProgressListener
        Implements IConversionStatusListener
        Private ReadOnly _conversionHandler As ConversionHandler
        Public Sub New(path As String)
            _conversionHandler = Common.getConversionHandler()
            _conversionHandler.SetConversionProgressListener(Me)
            _conversionHandler.SetConversionStatusListener(Me)
        End Sub
        Public Sub ConversionProgressChanged(args As ConversionProgressEventArgs) Implements IConversionProgressListener.ConversionProgressChanged
            Console.WriteLine("Conversion progress: {0} %", args.Progress)
        End Sub
        Public Sub ConversionStatusChanged(args As ConversionEventArgs) Implements IConversionStatusListener.ConversionStatusChanged
            Console.WriteLine("Conversion status changed to: {0}", args.Status)
        End Sub
        Public Function Convert(file As String) As String
            Dim options As New PdfSaveOptions()
            options.OutputType = OutputType.String
            Return _conversionHandler.Convert(Of String)(file, options)
        End Function
    End Class
End Namespace
'ExEnd:ConversionManagerWithInterfaceClass
