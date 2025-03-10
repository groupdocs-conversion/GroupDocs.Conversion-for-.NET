using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert XLSX file into TEX format.
    /// For more details about Microsoft Excel Open XML Spreadsheet (.xlsx) to LaTeX Source Document (.tex) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-xlsx-to-tex
    /// </summary>
    internal static class ConvertXlsxToTex
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "xlsx-converted-to.tex");
            
            // Load the source XLSX file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_XLSX))
            {
                PageDescriptionLanguageConvertOptions options = new PageDescriptionLanguageConvertOptions { Format = GroupDocs.Conversion.FileTypes.PageDescriptionLanguageFileType.Tex };
                // Save converted TEX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to tex completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
