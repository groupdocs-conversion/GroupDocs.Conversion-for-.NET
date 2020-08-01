---
id: groupdocs-conversion-for-net-19-12-release-notes
url: conversion/net/groupdocs-conversion-for-net-19-12-release-notes
title: GroupDocs.Conversion for .NET 19.12 Release Notes
weight: 2
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 19.12{{< /alert >}}

## Major Features

There are 5+ features, improvements and bug-fixes in this release, most notable are:

*   XML documents can be converted to any format without transformation
*   Call ConvertedDocumentStream or ConvertedPageStream delegates providing converted stream for processing or storing.
*   Improved memory management

## Full List of Issues Covering all Changes in this Release

| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-3539 | Feature | Convert XML documents without transformation |
| CONVERSIONNET-3526 | Improvement | New overload Convert methods which accepts ConvertedDocumentStream or ConvertedPageStream delegates |
| CONVERSIONNET-2922 | Bug | Error converting RTL/HTML to PDF |
| CONVERSIONNET-3357 | Bug | Cross reference table or cross reference stream not found exception thrown when converting a particular PDF to image |
| CONVERSIONNET-3507 | Bug | Convert from XML to any format throw exception - The file is corrupt or damaged. |
| CONVERSIONNET-3508 | Bug | Exception "The process cannot access the file because it is being used by another process." when converting to file |
| CONVERSIONNET-3525 | Bug | Convert to image doesn't release the last image |
| CONVERSIONNET-3534 | Bug | Pages limit for TXT file adds additional empty page at the end |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 19.12. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

1.  ### GroupDocs.Conversion.Converter.Convert overloads
    
    Introduced new overloads of Convert method
    
    ```csharp
    /// <summary>
    /// Converts source document. Saves the whole converted document.
    /// </summary>
    /// <param name="document">The delegate that saves converted document to a stream.</param>
    /// <param name="documentCompleted">The delegate that receive converted document stream.</param>
    /// <param name="convertOptions">The convert options specific to desired target file type.</param>
    public void Convert<TFileType>(SaveDocumentStream document, ConvertedDocumentStream documentCompleted, ConvertOptions<TFileType> convertOptions) where TFileType : FileType
     
    /// <summary>
    /// Converts source document. Saves the converted document page by page.
    /// </summary>        
    /// <param name="document">The delegate that saves converted document page to a stream.</param>
    /// <param name="documentCompleted">The delegate that receive converted document page stream.</param>
    /// <param name="convertOptions">The convert options specific to desired target file type.</param>
    public void Convert<TFileType>(SavePageStream document, ConvertedPageStream documentCompleted, ConvertOptions<TFileType> convertOptions) where TFileType : FileType
    ```
    
    From v19.12 of GroupDocs,Conversion stream created from SaveDocumentStream/SavePageStream delegate is disposed automatically. In order to be able to store converted document stream to file system or database, each time when converted document stream is read the delegates ConvertedDocumentStream/ConvertedPageStream are invoked. 
    
    Usage:
    
    ```csharp
    const string fileName = "source.docx";
    using (var converter = new Converter(() => new FileStream(fileName, FileMode.Open)))
    {
        var options = new PdfConvertOptions();
        converter.Convert(()=> new MemoryStream(), converted =>
        {
            using (var fileStream = new FileStream("converted.pdf", FileMode.Create))
            {
                converted.CopyTo(fileStream);
            }
        }, options);
    }
    ```
    
2.  XML documents can be converted without transformations
    
    Usage:
    
    ```csharp
    using (var converter = new Converter("sitemap.xml"))
    {
        var options = new PdfConvertOptions();
        converter.Convert("converted.pdf", options);
    }
    ```
