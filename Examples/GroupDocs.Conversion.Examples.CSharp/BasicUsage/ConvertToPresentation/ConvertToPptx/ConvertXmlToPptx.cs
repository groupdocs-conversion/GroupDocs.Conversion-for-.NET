using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert XML file into PPTX format.
    /// For more details about Extended Markup Language (.xml) to PowerPoint Open XML Presentation (.pptx) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-xml-to-pptx
    /// </summary>
    internal static class ConvertXmlToPptx
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "xml-converted-to.pptx");
            
            // Load the source XML file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_XML))
            {
                var options = new PresentationConvertOptions();
                // Save converted PPTX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to pptx completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
