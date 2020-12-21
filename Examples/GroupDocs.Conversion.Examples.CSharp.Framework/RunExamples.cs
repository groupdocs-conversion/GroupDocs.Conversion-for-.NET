using System;
using GroupDocs.Conversion.Examples.CSharp.AdvancedUsage;
using GroupDocs.Conversion.Examples.CSharp.BasicUsage;
using GroupDocs.Conversion.Examples.CSharp.QuickStart;

namespace GroupDocs.Conversion.Examples.CSharp
{
    internal static class RunExamples
    {
        static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            //NOTE: Please uncomment the example you want to try out

            #region Quick Start

            SetLicenseFromFile.Run();
            //SetLicenseFromStream.Run();
            //SetMeteredLicense.Run();
            HelloWorld.Run();

            #endregion

            #region Basic Usage

            // GetAllPossibleConversions.Run();
            // GetPossibleConversionsForSpecifiedDocumentExtension.Run();
            // GetPossibleConversions.Run();
            // GetSourceDocumentInfo.Run();

            #region Convert document to HTML

            // ConvertToHtml.Run();

            #endregion

            #region Convert document to Image

            // ConvertToJpg.Run();
            // ConvertToPng.Run();
            // ConvertToPsd.Run();

            #endregion

            #region Convert document to PDF

            // ConvertToPdf.Run();

            #endregion

            #region Convert document to Presentation

            // ConvertToPresentation.Run();

            #endregion

            #region Convert document to Spreadsheet

            // ConvertToSpreadsheet.Run();

            #endregion

            #region Convert document to WordProcessing

            // ConvertToWordProcessing.Run();

            #endregion

            #endregion

            #region Advanced Usage

            #region Common rendering options

            // AddWatermark.Run();
            // ConvertSpecificPages.Run();
            // GetDefaultConvertOptionsForDesiredTargetFormat.Run();
            // ConvertToStream.Run();

            #endregion

            #region Loading

            // GetDefaultLoadOptionsForSourceDocument.Run();
            // LoadPasswordProtectedDocument.Run();

            #region Loading documents from different sources

            // LoadDocumentFromLocalDisk.Run();
            // LoadDocumentFromStream.Run();
            // LoadDocumentFromUrl.Run();
            // LoadDocumentFromFtp.Run();
            // LoadDocumentFromAmazonS3.Run();
            // LoadDocumentFromAzureBlobStorage.Run();

            #endregion

            #region Load options by document type

            #region Cad

            // ConvertCadAndSpecifyLayouts.Run();
            // ConvertCadAndSpecifyWidthAndHeight.Run();

            #endregion

            #region Csv

            // ConvertCsvByConvertingDateTimeAndNumericData.Run();
            // ConvertCsvBySpecifyingDelimiter.Run();
            // ConvertCsvBySpecifyingEncoding.Run();

            #endregion

            #region Email

            // ConvertEmailWithAlteringFieldsVisibility.Run();
            // ConvertEmailWithTimezoneOffset.Run();
            // ConvertEmailWithAttachments.Run();
            // ConvertEmailWithLocalizingEmailFields.Run();
            // ConvertEmailWithUseOfGlobalization.Run();

            #endregion

            #region Markup

            // ConvertMarkupWithAddingPageNumbering.Run();
            
            #endregion

            #region Note

            // ConvertNoteBySpecifyingFontSubstitution.Run();

            #endregion

            #region Pdf

            // ConvertPdfAndFlattenAllFields.Run();
            // ConvertPdfAndHideAnnotations.Run();
            // ConvertPdfAndRemoveEmbeddedFiles.Run();

            #endregion

            #region PersonalStorage

            // GetFoldersFromPersonalStorage.Run();
            // ConvertPersonalStorageContentToDifferentFormats.Run();
            
            #endregion
            
            #region Presentation

            // ConvertPresentationByHidingComments.Run();
            // ConvertPresentationBySpecifyingFontSubstitution.Run();
            // ConvertPresentationWithHiddenSlidesIncluded.Run();

            #endregion

            #region Spreadsheet

            // ConvertSpreadsheetAndHideComments.Run();
            // ConvertSpreadsheetByShowingGridLines.Run();
            // ConvertSpreadsheetBySkippingEmptyRowsAndColumns.Run();
            // ConvertSpreadsheetBySpecifyingFontSubstitution.Run();
            // ConvertSpreadsheetBySpecifyingRange.Run();
            // ConvertSpreadsheetWithHiddenSheetsIncluded.Run();

            #endregion

            #region Txt

            // ConvertTxtByControllingLeadingSpacesBehavior.Run();
            // ConvertTxtByControllingTrailingSpacesBehavior.Run(); 
            // ConvertTxtBySpecifyingEncoding.Run();

            #endregion

            #region WordProcessing

            // ConvertWordProcessingByHidingComments.Run();
            // ConvertWordProcessingByHidingTrackedChanges.Run();
            // ConvertWordProcessingBySpecifyingFontSubstitution.Run();

            #endregion

            #region Xml

            // ConvertXmlAsDataSourceToSpreadsheet.Run();
            
            #endregion
            
            #endregion

            #endregion

            #region Caching

            // UseCacheWhenProcessingDocuments.Run();
            // HowToUseCustomCacheImplementation.Run();

            #endregion

            // ConvertToHtmlWithAdvancedOptions.Run();
            // ConvertToImageWithAdvancedOptions.Run();
            // ConvertToPdfWithAdvancedOptions.Run();
            // ConvertToPresentationWithAdvancedOptions.Run();
            // ConvertToSpreadsheetWithAdvancedOptions.Run();
            // ConvertToWordProcessingWithAdvancedOptions.Run();

            // ConvertEachEmailAttachmentToDifferentFormat.Run();
            // ConvertOstDocumentMessagesToDifferentFormats.Run();
            
            // ListenConversionStateAndProgress.Run();

            #endregion

            Console.WriteLine();
            Console.WriteLine("All done.");
            Console.ReadKey();
        }
    }
}
