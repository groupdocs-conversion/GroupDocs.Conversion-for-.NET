using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert OST file into TXT format.
    /// For more details about Outlook Offline Storage File (.ost) to Plain Text File Format (.txt) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-ost-to-txt
    /// </summary>
    internal static class ConvertOstToTxt
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "ost-converted-{0}-to.txt");
            
            // Load the source OST file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_OST, fileType => fileType == PersonalStorageFileType.Ost
                                                                                                                ? new PersonalStorageLoadOptions()
                                                                                                                : null))
	        {
                WordProcessingConvertOptions options = new WordProcessingConvertOptions { Format = GroupDocs.Conversion.FileTypes.WordProcessingFileType.Txt };
		        var counter = 1;
                // Save converted TXT file
                converter.Convert(
		            (FileType fileType) => new FileStream(string.Format(outputFile, counter++), FileMode.Create),
                    options
                );            
	        }

            Console.WriteLine("\nConversion to txt completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
