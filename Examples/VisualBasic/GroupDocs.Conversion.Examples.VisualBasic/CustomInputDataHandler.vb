'ExStart:CustomInputDataHandlerClass
Imports System.IO
Imports Amazon
Imports Amazon.S3
Imports Amazon.S3.Model
Imports GroupDocs.Conversion.Domain
Imports GroupDocs.Conversion.Handler.Input

Namespace GroupDocsConversionExamples.VisualBasic
    Class CustomInputDataHandler
        Implements IInputDataHandler
        Private Shared bucketName As String = ""
        'TODO: Put you bucketname here 
        Private ReadOnly _client As AmazonS3Client
        Public Sub New()
            _client = New AmazonS3Client(RegionEndpoint.EUWest1)
        End Sub
        Public Function GetFileDescription(guid As String) As FileDescription Implements IInputDataHandler.GetFileDescription
            Dim result As New FileDescription()
            Dim requests = New GetObjectRequest()
            requests.BucketName = bucketName
            requests.Key = guid
            Dim fileName As String
            Dim size As Long
            Using response = _client.GetObject(requests)
                fileName = response.Key
                size = response.ContentLength
            End Using

            result.Guid = guid
            result.Name = fileName
            result.Size = size
            Return result
        End Function
        Public Function GetFile(guid As String) As Stream Implements IInputDataHandler.GetFile
            Dim requests As New GetObjectRequest()
            requests.BucketName = bucketName
            requests.Key = guid

            Dim result = New MemoryStream()
            Using response = _client.GetObject(requests)
                Dim buffer As Byte() = New Byte(16383) {}
                '16*1024
                Dim read As Integer
                While (InlineAssignHelper(read, response.ResponseStream.Read(buffer, 0, buffer.Length))) > 0
                    result.Write(buffer, 0, read)
                End While
            End Using
            Return result
        End Function
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Namespace
'ExEnd:CustomInputDataHandlerClass
