using System;
using GroupDocs.Conversion.Contracts;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to get folders from personal storage
    /// </summary>
    internal static class GetFoldersFromPersonalStorage
    {
        public static void Run()
        {
            using (Converter converter = new Converter(Constants.SAMPLE_OST))
            {
                var documentInfo = converter.GetDocumentInfo();
                var ostInfo = (PersonalStorageDocumentInfo) documentInfo;
                Console.WriteLine(ostInfo.RootFolderName);
                foreach (var folder in ostInfo.Folders)
                {
                    Console.WriteLine(folder);
                }
            }
        }
    }
}
