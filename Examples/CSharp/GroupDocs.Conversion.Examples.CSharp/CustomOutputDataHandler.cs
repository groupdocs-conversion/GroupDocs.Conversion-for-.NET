using System.IO;
using Amazon;
using Amazon.S3;
using Amazon.S3.IO;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Converter.Option;
using GroupDocs.Conversion.Domain;
using GroupDocs.Conversion.Handler.Output;

namespace GroupDocs.Conversion.Examples.CSharp
{
    class CustomOutputDataHandler : IOutputDataHandler
    {
        private static string bucketName = ""; //TODO: Put you bucketname here
        private readonly ConversionConfig _conversionConfig;
        private readonly AmazonS3Client _client;
        public CustomOutputDataHandler(ConversionConfig conversionConfig)
        {
            _conversionConfig = conversionConfig;
            _client = new AmazonS3Client(RegionEndpoint.EUWest1);
        }
        public string SaveFile(FileDescription fileDescription, Stream stream, SaveOptions saveOptions)
        {
            string key = GetOutputPath(fileDescription, saveOptions);
            stream.Seek(0, SeekOrigin.Begin);
            S3FileInfo fileInfo = new S3FileInfo(_client, bucketName, key);
            byte[] buffer = new byte[16384]; //16*1024
            using (Stream output = fileInfo.Create())
            {
                int read = stream.Read(buffer, 0, buffer.Length);
                while (read > 0)
                {
                    output.Write(buffer, 0, read);
                    read = stream.Read(buffer, 0, buffer.Length);
                }
                output.Flush();
                output.Close();
            }
            return fileInfo.FullName;
        }
        private string GetOutputPath(FileDescription fileDescription, SaveOptions saveOptions)
        {
            string filePath = "";
            string fileName = "";
            ImageSaveOptions options = saveOptions as ImageSaveOptions;
            if (options != null)
            {
                fileName = !string.IsNullOrEmpty(options.CustomName)
                    ? (options.UseWidthForCustomName
                        ? string.Format("{0}_{1}_{2}.{3}", options.CustomName,
                            options.PageNumber,
                            options.Width,
                            options.ConvertFileType.ToString().ToLower())
                        : string.Format("{0}_{1}.{2}", options.CustomName,
                            options.PageNumber,
                            options.ConvertFileType.ToString().ToLower()))
                    : string.Format("{0}_{1}.{2}", fileDescription.BaseName,
                        options.PageNumber,
                        options.ConvertFileType.ToString().ToLower());
                filePath = string.Format(@"{0}\{1}", _conversionConfig.OutputPath, fileName);
            }
            else
            {
                fileName = !string.IsNullOrEmpty(saveOptions.CustomName)
                    ? string.Format("{0}.{1}", saveOptions.CustomName,
                        saveOptions.CustomName.Split('.')[1].ToString().ToLower())
                    : string.Format("{0}.{1}", fileDescription.BaseName,
                        saveOptions.CustomName.Split('.')[1].ToString().ToLower());
                filePath = string.Format(@"{0}\{1}", _conversionConfig.OutputPath, fileName);
            }
            return filePath;
        }
    }
}
