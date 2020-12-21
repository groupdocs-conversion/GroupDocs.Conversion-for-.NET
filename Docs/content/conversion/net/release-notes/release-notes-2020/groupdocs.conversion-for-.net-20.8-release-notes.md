---
id: groupdocs-conversion-for-net-20-8-release-notes
url: conversion/net/groupdocs-conversion-for-net-20-8-release-notes
title: GroupDocs.Conversion for .NET 20.8 Release Notes
weight: 5
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 20.8{{< /alert >}}

## Major Features

There are 10 features, improvements and bug-fixes in this release, most notable are:

*   Conversions from LOG file format
*   Extended meta data for word processing documents with TableOfContent
*   Extended meta data for pdf documents with TableOfContent

## Full List of Issues Covering all Changes in this Release


| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-4054 | Feature     | LOG file format support |
| CONVERSIONNET-4095 | Improvement | Extend WordprocessingDocumentInfo with TableOfContents property |
| CONVERSIONNET-4096 | Improvement | Extend PdfDocumentInfo with TableOfContents property |
| CONVERSIONNET-3772 | Bug         | XLSB to XLS conversion - The column index should not be inside the pivottable report |
| CONVERSIONNET-3826 | Bug         | PDF to HTML conversion taking too long |
| CONVERSIONNET-3851 | Bug         | PDF to HTML conversion issue, additional space in a word |
| CONVERSIONNET-3936 | Bug         | ODG to PPT conversion issue |
| CONVERSIONNET-3985 | Bug         | Could not load the file \'Aspose.Slides\'. exception when targeting Xamarin.Mac Full / .NET Framework 4.5 |
| CONVERSIONNET-3999 | Bug         | XLSM to PDF - The row index should not be inside the pivottable report |
| CONVERSIONNET-4124 | Bug         | JPG to BMP conversion throws an exception |


## Public API and Backward Incompatible Changes

1.  **Introduced new property in class WordprocessingDocumentInfo**
    
    ```csharp
    /// <summary>
    /// Table of contents
    /// </summary>
    public IEnumerable<TableOfContentsItem> TableOfContents { get; private set; } 
    ```
    
2.  **Introduced new property in class PdfDocumentInfo**
    
    ```csharp
    /// <summary>
    /// Table of contents
    /// </summary>
    public IEnumerable<TableOfContentsItem> TableOfContents { get; private set; } 
    ```
    
3.  **Introduced new class GroupDocs.Conversion.Contracts.TableOfContentsItem**
    
    ```csharp
    /// <summary>
    /// Contains Table of contents item metadata
    /// </summary>
    public class TableOfContentsItem
    {
        /// <summary>
        /// Bookmark title
        /// </summary>
        public string Title { get; }
        /// <summary>
        /// Bookmark page
        /// </summary>
        public int Page { get; }
    }
    ```
    Usage
    ```csharp
    const string source = "sample-toc.docx";
    using (var converter = new Converter(source))
    {
        var documentInfo = (WordprocessingDocumentInfo) converter.GetDocumentInfo();
        foreach (var tocItem in documentInfo.TableOfContents)
        {
            Console.WriteLine($"{tocItem.Title}: {tocItem.Page}");
        }
    }
    ```
