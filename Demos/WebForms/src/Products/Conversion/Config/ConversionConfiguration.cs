using GroupDocs.Conversion.WebForms.Products.Common.Config;
using GroupDocs.Conversion.WebForms.Products.Common.Util.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace GroupDocs.Conversion.WebForms.Products.Conversion.Config
{
    /// <summary>
    /// ConversionConfiguration
    /// </summary>
    public class ConversionConfiguration : CommonConfiguration
    {
        private string FilesDirectory = "DocumentSamples/Conversion";
        private string ResultDirectory = "DocumentSamples/Conversion/Converted";

        /// <summary>
        /// Constructor
        /// </summary>
        public ConversionConfiguration()
        {
            YamlParser parser = new YamlParser();
            dynamic configuration = parser.GetConfiguration("conversion");
            ConfigurationValuesGetter valuesGetter = new ConfigurationValuesGetter(configuration);

            // get Viewer configuration section from the web.config
            FilesDirectory = valuesGetter.GetStringPropertyValue("filesDirectory", FilesDirectory);
            if (!IsFullPath(FilesDirectory))
            {
                FilesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FilesDirectory);
                if (!Directory.Exists(FilesDirectory))
                {                   
                    Directory.CreateDirectory(FilesDirectory);
                }
            }
            ResultDirectory = valuesGetter.GetStringPropertyValue("resultDirectory", ResultDirectory);
            if (!IsFullPath(ResultDirectory))
            {
                ResultDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ResultDirectory);
                if (!Directory.Exists(ResultDirectory))
                {
                    Directory.CreateDirectory(ResultDirectory);
                }
            }
        }

        private static bool IsFullPath(string path)
        {
            return !String.IsNullOrWhiteSpace(path)
                && path.IndexOfAny(System.IO.Path.GetInvalidPathChars().ToArray()) == -1
                && Path.IsPathRooted(path)
                && !Path.GetPathRoot(path).Equals(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal);
        }        

        public void SetFilesDirectory(string filesDirectory)
        {
            this.FilesDirectory = filesDirectory;
        }

        public string GetFilesDirectory()
        {
            return FilesDirectory;
        }

        public void SetResultDirectory(string resultDirectory)
        {
            this.ResultDirectory = resultDirectory;
        }

        public string GetResultDirectory()
        {
            return ResultDirectory;
        }
    }
}