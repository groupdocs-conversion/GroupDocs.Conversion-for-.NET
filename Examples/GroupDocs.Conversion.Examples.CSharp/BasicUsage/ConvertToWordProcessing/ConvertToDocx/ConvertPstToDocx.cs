using System;
using System.IO;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert PST file into DOCX format.
    /// For more details about Personal Storage File (.pst) to Microsoft Word Open XML Document (.docx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-pst-to-docx
    /// </summary>
    internal static class ConvertPstToDocx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "pst-converted-{0}-to.docx");
            
            // Load the source PST file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_PST, (LoadContext loadContext) => loadContext.SourceFormat == EmailFileType.Ost
                                                                                                                ? new PersonalStorageLoadOptions()
                                                                                                                : null))
	        {
                var options = new WordProcessingConvertOptions();
		        var counter = 1;
                // Save converted DOCX file
                converter.Convert(
		            (SaveContext saveContext) => new FileStream(string.Format(outputFile, counter++), FileMode.Create),
                    options
                );            
	        }

            Console.WriteLine("\nConversion to docx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
