'ExStart:CustomCacheDataHandlerClass
Imports System.IO
Imports Amazon
Imports Amazon.S3
Imports Amazon.S3.IO
Imports GroupDocs.Conversion.Config
Imports GroupDocs.Conversion.Converter.Option
Imports GroupDocs.Conversion.Domain
Imports GroupDocs.Conversion.Handler.Cache

Namespace GroupDocsConversionExamples.VisualBasic
    Class CustomCacheDataHandler
        Implements ICacheDataHandler
        Private Shared bucketName As String = ""
        'TODO: Put you bucketname here 
        Private ReadOnly _conversionConfig As ConversionConfig
        Private ReadOnly _client As AmazonS3Client
        Public Sub New(conversionConfig As ConversionConfig)
            _conversionConfig = conversionConfig
            _client = New AmazonS3Client(RegionEndpoint.EUWest1)
        End Sub

        Public Function Exists(cacheFileDescription As CacheFileDescription) As Boolean Implements ICacheDataHandler.Exists
            If Not _conversionConfig.UseCache Then
                Return False
            End If
            If cacheFileDescription Is Nothing Then
                Throw New System.Exception("CacheFileDescription is not set")
            End If
            If cacheFileDescription.LastModified = 0 Then
                Return False
            End If
            If String.IsNullOrEmpty(cacheFileDescription.Guid) Then
                Throw New System.Exception("CacheFileDescription is not set")
            End If
            If String.IsNullOrEmpty(_conversionConfig.StoragePath) Then
                Throw New System.Exception("Storage path is not set")
            End If
            Dim key = GetCachePath(_conversionConfig.CachePath, cacheFileDescription)
            Dim fileInfo As New S3FileInfo(_client, bucketName, key)
            If Not fileInfo.Exists Then
                Return False
            End If
            Return (fileInfo.LastWriteTimeUtc >= DateTime.UtcNow.AddMinutes(-5))
        End Function
        Public Function GetInputStream(cacheFileDescription As CacheFileDescription) As Stream Implements ICacheDataHandler.GetInputStream
            If cacheFileDescription Is Nothing OrElse [String].IsNullOrEmpty(cacheFileDescription.Guid) OrElse cacheFileDescription.LastModified = 0 Then
                Throw New System.Exception("CacheFileDescription is not set")
            End If
            Dim key = GetCachePath(_conversionConfig.CachePath, cacheFileDescription)
            Dim fileInfo = New S3FileInfo(_client, bucketName, key)
            If Not fileInfo.Exists Then
                Throw New System.Exception("File not found")
            End If
            Return fileInfo.OpenRead()
        End Function
        Public Function GetOutputSaveStream(cacheFileDescription As CacheFileDescription) As Stream Implements ICacheDataHandler.GetOutputSaveStream
            Try
                If Not _conversionConfig.UseCache Then
                    Return New MemoryStream()
                End If
                If cacheFileDescription Is Nothing OrElse [String].IsNullOrEmpty(cacheFileDescription.Guid) Then
                    Throw New System.Exception("CacheFileDescription is not set")
                End If
                Dim key As String = GetCachePath(_conversionConfig.CachePath, cacheFileDescription)
                Dim fileInfo As New S3FileInfo(_client, bucketName, key)
                Return fileInfo.Create()
            Catch e As System.Exception
                Throw New System.Exception(e.Message)
            End Try
        End Function
        Public Function GetCacheUri(cacheFileDescription As CacheFileDescription) As String Implements ICacheDataHandler.GetCacheUri
            Return GetCachePath(_conversionConfig.CachePath, cacheFileDescription)
        End Function
        Private Function GetCachePath(path As String, cacheFileDescription As CacheFileDescription) As String
            If cacheFileDescription.SaveOptions Is Nothing Then
                Throw New System.Exception("CacheFileDescription.Options is not set")
            End If
            Dim filePath As String = ""
            Dim fileName As String = ""
            Dim options = TryCast(cacheFileDescription.SaveOptions, ImageSaveOptions)
            If options IsNot Nothing Then
                If Not String.IsNullOrEmpty(options.CustomName) Then
                    If options.UseWidthForCustomName Then
                        fileName = String.Format("{0}_{1}.{2}", options.CustomName, options.Width, options.ConvertFileType.ToString().ToLower())
                    Else
                        fileName = String.Format("{0}.{1}", options.CustomName, options.ConvertFileType.ToString().ToLower())
                    End If
                Else
                    fileName = String.Format("{0}.{1}", cacheFileDescription.BaseName, options.ConvertFileType.ToString().ToLower())
                End If
                filePath = String.Format("{0}\{1}\{2}\{3}", path, cacheFileDescription.Guid, options.PageNumber, fileName)
            Else
                fileName = If(Not String.IsNullOrEmpty(cacheFileDescription.SaveOptions.CustomName), String.Format("{0}.{1}", cacheFileDescription.SaveOptions.CustomName, cacheFileDescription.SaveOptions.CustomName.Split("."c)(1).ToString().ToLower()), String.Format("{0}.{1}", cacheFileDescription.BaseName, cacheFileDescription.SaveOptions.CustomName.Split("."c)(1).ToString().ToLower()))
                filePath = String.Format("{0}\{1}\{2}", path, cacheFileDescription.Guid, fileName)
            End If
            Return filePath
        End Function
    End Class
End Namespace
'ExEnd:CustomCacheDataHandlerClass
