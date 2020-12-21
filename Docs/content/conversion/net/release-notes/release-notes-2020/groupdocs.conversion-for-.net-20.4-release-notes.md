---
id: groupdocs-conversion-for-net-20-4-release-notes
url: conversion/net/groupdocs-conversion-for-net-20-4-release-notes
title: GroupDocs.Conversion for .NET 20.4 Release Notes
weight: 8
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 20.4{{< /alert >}}

## Major Features

There are 20+ features, improvements and bug-fixes in this release, most notable are:

*   Conversions from PST, OST - can convert each message, contact to different format
*   Now is possible to convert each email attachment to different format
*   Conversions from Oxps, Fods, Otg
*   Conversion to Fods
*   Improved caching
*   Introduced in-memory caching

## Full List of Issues Covering all Changes in this Release

| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-3225 | Feature | Support for auto page numbering while export to PDF |
| CONVERSIONNET-3710 | Feature | Convert each email attachment to different type |
| CONVERSIONNET-3778 | Feature | Convert from PST, OST |
| CONVERSIONNET-3812 | Feature | Implement conversion from Oxps |
| CONVERSIONNET-3816 | Feature | Implement conversion from Fods |
| CONVERSIONNET-3822 | Feature | Implement conversion to Fods |
| CONVERSIONNET-3823 | Feature | Implement conversion from Otg |
| CONVERSIONNET-2875 | Feature | Introduced in memory caching |
| CONVERSIONNET-3659 | Improvement | Improve font substitution when converting from PDF |
| CONVERSIONNET-3874 | Improvement | Improved caching |
| CONVERSIONNET-1702 | Bug | A generic error occurred in GDI+ while saving document to LZW TIFF |
| CONVERSIONNET-3699 | Bug | Exception while Converting PST to CSV using GroupDocs.Conversion .NET API v20.1.0 As The Not supported file type |
| CONVERSIONNET-3724 | Bug | Exception while Converting XLSB to XLS using GroupDocs.Conversion .NET API v20.1.0 |
| CONVERSIONNET-3729 | Bug | Exception while Converting XLSB to XLSX As The column index should not be inside the pivot table report |
| CONVERSIONNET-3745 | Bug | XLSB to XLS conversion issue  |
| CONVERSIONNET-3768 | Bug | "System.DllNotFoundException : Unable to load DLL 'libgdiplus': The specified module could not be found." exception on MacOS targeting .NET Standard |
| CONVERSIONNET-3770 | Bug | VSD to DOC conversion issue |
| CONVERSIONNET-3790 | Bug | Xps and Tex files are converted in trial mode when using venture licensing |
| CONVERSIONNET-3804 | Bug | PCL to DOT file conversion |
| CONVERSIONNET-3810 | Bug | XLSX to XLS conversion - The column index should not be inside the pivottable report |
| CONVERSIONNET-3821 | Bug | GroupDocs.Conversion.Exceptions.GroupDocsConversionException was unhandled |

## Public API and Backward Incompatible Changes

1.  **Converter class has new constructor overloads**
    ```csharp
    /// <summary>
    /// Initializes new instance of <see cref="Converter"/> class.
    /// </summary>
    /// <param name="document">The method that returns readable stream.</param>
    /// <param name="loadOptions">The methods that returns document load options.</param>
    public Converter(Func<Stream> document, Func<FileType, LoadOptions> loadOptions)
    
    
    /// <summary>
    /// Initializes new instance of <see cref="Converter"/> class.
    /// </summary>
    /// <param name="document">The method that returns readable stream.</param>
    /// <param name="loadOptions">The methods that returns document load options.</param>
    /// <param name="settings">The Converter settings.</param>
    public Converter(Func<Stream> document, Func<FileType, LoadOptions> loadOptions, Func<ConverterSettings> settings)
    
    /// <summary>
    /// Initializes new instance of <see cref="Converter"/> class.
    /// </summary>
    /// <param name="filePath">The file path to the source document.</param>
    /// <param name="loadOptions">The methods that returns document load options.</param>
    public Converter(string filePath, Func<FileType, LoadOptions> loadOptions)
    
    /// <summary>
    /// Initializes new instance of <see cref="Converter"/> class.
    /// </summary>
    /// <param name="filePath">The file path to the source document.</param>
    /// <param name="loadOptions">The methods that returns document load options.</param>
    /// <param name="settings">The Converter settings.</param>
    public Converter(string filePath, Func<FileType, LoadOptions> loadOptions, Func<ConverterSettings> settings) 
    ```
    
    Usage
    
    ```csharp
    LoadOptions LoadOptionsProvider(FileType sourceType)
    {
        if (sourceType == EmailFileType.Msg)
        {
            return new EmailLoadOptions {ConvertOwned = true, ConvertOwner = true};
        }
        return null;
    }
    
    var source = "sample.docx";
    using (var converter = new Converter(source, LoadOptionsProvider))
    {
    ....
    }
    ```
2.  **Convert method in Converter class has new overloads**
    ```csharp
    /// <summary>
    /// Converts source document. Saves the whole converted document.
    /// </summary>
    /// <param name="document">The delegate that saves converted document to a stream.</param>
    /// <param name="convertOptionsProvider">Convert options provider. Will be called for each conversion to provide specific convert options to desired target document type.</param>
    public void Convert(SaveDocumentStream document, ConvertOptionsProvider convertOptionsProvider) 
     
    /// <summary>
    /// Converts source document. Saves the whole converted document.
    /// </summary>
    /// <param name="document">The delegate that saves converted document to a stream.</param>
    /// <param name="documentCompleted">The delegate that receive converted document stream.</param>
    /// <param name="convertOptionsProvider">Convert options provider. Will be called for each conversion to provide specific convert options to desired target document type.</param>
    public void Convert(SaveDocumentStream document, ConvertedDocumentStream documentCompleted, ConvertOptionsProvider convertOptionsProvider)
    
    /// <summary>
    /// Converts source document. Saves the whole converted document.
    /// </summary>
    /// <param name="document">The delegate that saves converted document to a stream.</param>
    /// <param name="convertOptions">The convert options specific to desired target file type.</param>
    public void Convert(SaveDocumentStreamForFileType document, ConvertOptions convertOptions)
    
    /// <summary>
    /// Converts source document. Saves the whole converted document.
    /// </summary>
    /// <param name="document">The delegate that saves converted document to a stream.</param>
    /// <param name="documentCompleted">The delegate that receive converted document stream.</param>
    /// <param name="convertOptions">The convert options specific to desired target file type.</param>
    public void Convert(SaveDocumentStreamForFileType document, ConvertedDocumentStream documentCompleted, ConvertOptions convertOptions)
    
    /// <summary>
    /// Converts source document. Saves the whole converted document.
    /// </summary>
    /// <param name="document">The delegate that saves converted document to a stream.</param>
    /// <param name="convertOptionsProvider">Convert options provider. Will be called for each conversion to provide specific convert options to desired target document type.</param>
    public void Convert(SaveDocumentStreamForFileType document, ConvertOptionsProvider convertOptionsProvider)
    
    /// <summary>
    /// Converts source document. Saves the whole converted document.
    /// </summary>
    /// <param name="document">The delegate that saves converted document to a stream.</param>
    /// <param name="documentCompleted">The delegate that receive converted document stream.</param>
    /// <param name="convertOptionsProvider">Convert options provider. Will be called for each conversion to provide specific convert options to desired target document type.</param>
    public void Convert(SaveDocumentStreamForFileType document, ConvertedDocumentStream documentCompleted, ConvertOptionsProvider convertOptionsProvider)
    
    /// <summary>
    /// Converts source document. Saves the converted document page by page.
    /// </summary>        
    /// <param name="document">The delegate that saves converted document to a stream.</param>
    /// <param name="convertOptionsProvider">Convert options provider. Will be called for each conversion to provide specific convert options to desired target document type.</param>
    public void Convert(SavePageStream document, ConvertOptionsProvider convertOptionsProvider)
    
    /// <summary>
    /// Converts source document. Saves the converted document page by page.
    /// </summary>        
    /// <param name="document">The delegate that saves converted document page to a stream.</param>
    /// <param name="documentCompleted">The delegate that receive converted document page stream.</param>
    /// <param name="convertOptionsProvider">Convert options provider. Will be called for each conversion to provide specific convert options to desired target document type.</param>
    public void Convert(SavePageStream document, ConvertedPageStream documentCompleted, ConvertOptionsProvider convertOptionsProvider)
    
    /// <summary>
    /// Converts source document. Saves the converted document page by page.
    /// </summary>        
    /// <param name="document">The delegate that saves converted document to a stream.</param>
    /// <param name="convertOptions">The convert options specific to desired target file type.</param>
    public void Convert(SavePageStreamForFileType document, ConvertOptions convertOptions)
    
    /// <summary>
    /// Converts source document. Saves the converted document page by page.
    /// </summary>        
    /// <param name="document">The delegate that saves converted document page to a stream.</param>
    /// <param name="documentCompleted">The delegate that receive converted document page stream.</param>
    /// <param name="convertOptions">The convert options specific to desired target file type.</param>
    public void Convert(SavePageStreamForFileType document, ConvertedPageStream documentCompleted, ConvertOptions convertOptions)
    
    /// <summary>
    /// Converts source document. Saves the converted document page by page.
    /// </summary>        
    /// <param name="document">The delegate that saves converted document to a stream.</param>
    /// <param name="convertOptionsProvider">Convert options provider. Will be called for each conversion to provide specific convert options to desired target document type.</param>
    public void Convert(SavePageStreamForFileType document, ConvertOptionsProvider convertOptionsProvider)
    
    /// <summary>
    /// Converts source document. Saves the converted document page by page.
    /// </summary>        
    /// <param name="document">The delegate that saves converted document page to a stream.</param>
    /// <param name="documentCompleted">The delegate that receive converted document page stream.</param>
    /// <param name="convertOptionsProvider">Convert options factory. Will be called for each conversion to provide specific convert options to desired target document type.</param>
    public void Convert(SavePageStreamForFileType document, ConvertedPageStream documentCompleted, ConvertOptionsProvider convertOptionsProvider)
    ```
    
    Usage
    
    ```csharp
    LoadOptions LoadOptionsProvider(FileType sourceType)
    {
        if (sourceType == EmailFileType.Msg)
        {
            return new EmailLoadOptions {ConvertOwned = true, ConvertOwner = true};
        }
        return null;
    }
     
    Stream ConvertedStreamProvider(FileType targetType)
    {
        return new FileStream($"converted-{index++}.{targetType.Extension}", FileMode.Create);
    }
    
    ConvertOptions ConvertOptionsProvider(string sourceDocumentName, FileType sourceType)
    {
        if (sourceType == WordProcessingFileType.Doc)
        {
            return new ImageConvertOptions
            {
                Format = ImageFileType.Tiff
            };
        } else if (sourceType == EmailFileType.Msg)
        {
            return new PdfConvertOptions();
        } else if (sourceType == ImageFileType.Png)
        {
            return new ImageConvertOptions {Format = ImageFileType.Jpeg};
        }
        return new PdfConvertOptions();
    }
    
    var source = "sample.docx";
    using (var converter = new Converter(source, LoadOptionsProvider))
    {
        converter.Convert(ConvertedStreamProvider, ConvertOptionsProvider);
    }
    ```
3.  **New delegates are introduced**
    ```csharp
    /// <summary>
    /// Describes delegate for saving converted document into stream. 
    /// </summary>
    /// <param name="fileType">Converted document type</param>
    /// <returns>Must return a stream where the converted document will be saved</returns>
    public delegate Stream SaveDocumentStreamForFileType(FileType fileType);
    
    /// <summary>
    /// Describes delegate for saving converted document page into stream. 
    /// </summary>
    /// <param name="pageNumber">Converted page number</param>
    /// <param name="fileType">Converted document type</param>
    /// <returns>Must return a stream where the converted document page will be saved</returns>
    public delegate Stream SavePageStreamForFileType(int pageNumber, FileType fileType);
    
     
    /// <summary>
    /// Describes delegate to provide convert options for specific source document.
    /// The delegate will be called before each conversion and provide a chance to provide specific convert options for desired target conversion.
    /// The decision could be made based on provided source file name and source file type.
    /// </summary>
    /// <param name="sourceDocumentName">Source file name</param>
    /// <param name="sourceType">Source file type</param>
    /// <returns>Must return <see cref="ConvertOptions"/> to be used for conversion of <see cref="FileType">sourceType</see> document</returns>
    public delegate ConvertOptions ConvertOptionsProvider(string sourceDocumentName, FileType sourceType);
    ```
4.  **FormatingOptions in PdfOptions class is marked as obsolete**
    FormattingOptions must be used
5.  **DefaultFont in GroupDocs.Conversion.ConverterSettings class is marked as obsolete**
    DefaultFont in specific ConvertOptions instance must be used.
6.  **ConvertAttachments in EmailLoadOptions class is marked as obsolete**
    ConvertOwned must be used
