---
id: groupdocs-conversion-for-net-19-1-release-notes
url: conversion/net/groupdocs-conversion-for-net-19-1-release-notes
title: GroupDocs.Conversion for .NET 19.1 Release Notes
weight: 10
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 19.1{{< /alert >}}

## Major Features

This regular monthly release contains 5+ improvements and bug fixes. Most notable are: 

*   Conversions from Vcf
*   Improved conversion of Svg to Slides
*   Set watermark as background when converting to image
*   Save converted document return saved file size and file name

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-2862 | Implement conversion from Vcf | Feature |
| CONVERSIONNET-2830 | Implement conversion improvement when converting Svg to Slides | Improvement |
| CONVERSIONNET-2878 | Add support for setting watermark as background when converting to image | Improvement |
| CONVERSIONNET-2881 | Save converted document to file should return the file name and size | Improvement |
| CONVERSIONNET-2837 | Spreadsheets sometimes show incorrect graph data | Bug |
| CONVERSIONNET-2863 | Issue with conversion .docx (with table of content) to .html | Bug |
| CONVERSIONNET-2864 | Conversion .pdf to .png (or .jpeg) with watermark as background issue | Bug |
| CONVERSIONNET-2871 | Inconsistent conversion from email file formats when converting to Cells | Bug |
| CONVERSIONNET-2876 | Receiving Aspose.Pdf.InvalidValueFormatException when converting a PDF file | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 19.1. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### Removed obsolete namespace GroupDocs.Conversion.Converter.Option

1.  All **LoadOptions** and **SaveOptions** classes removed from namespace *GroupDocs.Conversion.Converter.Option*.  
    *LoadOptions* classes are now in *GroupDocs.Conversion.Options.Load* namespace and *SaveOptions* classes are now in *GroupDocs.Conversion.Options.Save* namespace.

### Save converted document returns saved file name and size

```csharp
/// <summary>
/// Class for handling converted document
/// </summary>
public sealed class ConvertedDocument
{
    ...
    /// <summary>
    /// Save converted document to custom named file
    /// </summary>
    /// <param name="fileName"></param>
    public SaveInfo Save(string fileName)
 
    /// <summary>
    /// Save specific page from converted document to custom named file
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="page"></param>
    public SaveInfo Save(string fileName, int page)
    ...
}
```

Usage

```csharp
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
const string source = "source.docx";
var saveOptions = new PdfSaveOptions();
var convertedDocument = conversionHandler.Convert(source, saveOptions);
var saveInfo = convertedDocument.Save("converted", 1);
Console.WriteLine("Page 1 file size: {0}", saveInfo.Size);
Console.WriteLine("Page 1 saved path: {0}", saveInfo.FileName);
```
