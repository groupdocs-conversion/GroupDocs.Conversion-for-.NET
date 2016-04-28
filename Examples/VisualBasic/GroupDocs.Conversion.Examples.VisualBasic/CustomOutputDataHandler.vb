'ExStart:CustomOutputDataHandlerClass
Imports System.IO
Imports Amazon
Imports Amazon.S3
Imports Amazon.S3.IO
Imports GroupDocs.Conversion.Config
Imports GroupDocs.Conversion.Converter.Option
Imports GroupDocs.Conversion.Domain
Imports GroupDocs.Conversion.Handler.Output

Namespace GroupDocsConversionExamples.VisualBasic
    Class CustomOutputDataHandler
        Implements IOutputDataHandler
        Private Shared bucketName As String = ""
        'TODO: Put you bucketname here
        Private ReadOnly _conversionConfig As ConversionConfig
        Private ReadOnly _client As AmazonS3Client
        Public Sub New(conversionConfig As ConversionConfig)
            _conversionConfig = conversionConfig
            _client = New AmazonS3Client(RegionEndpoint.EUWest1)
        End Sub
        Public Function SaveFile(fileDescription As FileDescription, stream As Stream, saveOptions As SaveOptions) As String Implements IOutputDataHandler.SaveFile
            Dim key As String = GetOutputPath(fileDescription, saveOptions)
            stream.Seek(0, SeekOrigin.Begin)
            Dim fileInfo As New S3FileInfo(_client, bucketName, key)
            Dim buffer As Byte() = New Byte(16383) {}
            '16*1024
            Using output As Stream = fileInfo.Create()
                Dim read As Integer = stream.Read(buffer, 0, buffer.Length)
                While read > 0
                    output.Write(buffer, 0, read)
                    read = stream.Read(buffer, 0, buffer.Length)
                End While
                output.Flush()
                output.Close()
            End Using
            Return fileInfo.FullName
        End Function
        Private Function GetOutputPath(fileDescription As FileDescription, saveOptions As SaveOptions) As String
            Dim filePath As String = ""
            Dim fileName As String = ""
            Dim options As ImageSaveOptions = TryCast(saveOptions, ImageSaveOptions)
            If options IsNot Nothing Then
                fileName = If(Not String.IsNullOrEmpty(options.CustomName), (If(options.UseWidthForCustomName, String.Format("{0}_{1}_{2}.{3}", options.CustomName, options.PageNumber, options.Width, options.ConvertFileType.ToString().ToLower()), String.Format("{0}_{1}.{2}", options.CustomName, options.PageNumber, options.ConvertFileType.ToString().ToLower()))), String.Format("{0}_{1}.{2}", fileDescription.BaseName, options.PageNumber, options.ConvertFileType.ToString().ToLower()))
                filePath = String.Format("{0}\{1}", _conversionConfig.OutputPath, fileName)
            Else
                fileName = If(Not String.IsNullOrEmpty(saveOptions.CustomName), String.Format("{0}.{1}", saveOptions.CustomName, saveOptions.CustomName.Split("."c)(1).ToString().ToLower()), String.Format("{0}.{1}", fileDescription.BaseName, saveOptions.CustomName.Split("."c)(1).ToString().ToLower()))
                filePath = String.Format("{0}\{1}", _conversionConfig.OutputPath, fileName)
            End If
            Return filePath
        End Function
    End Class
End Namespace
'ExEnd:CustomOutputDataHandlerClass
