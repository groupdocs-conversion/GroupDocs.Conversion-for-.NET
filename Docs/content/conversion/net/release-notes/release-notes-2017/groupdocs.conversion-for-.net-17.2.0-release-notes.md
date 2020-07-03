---
id: groupdocs-conversion-for-net-17-2-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-17-2-0-release-notes
title: GroupDocs.Conversion for .NET 17.2.0 Release Notes
weight: 10
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 17.2.0{{< /alert >}}

## Major Features

There are 9 new features, improvements and fixes in this regular monthly release. The most notable are:

*   Conversions to specific PDF format
*   Conversions from PDF-A
*   Conversions from Mobi
*   Setting different horizontal and vertical resolution when converting to image
*   Fixed 5 bugs

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1685 | Implement conversion to PDF with setting PDF file format | New Feature |
| CONVERSIONNET-1693 | Conversion of PDF-A file to PDF | New Feature |
| CONVERSIONNET-1697 | Implement conversion from Mobi | New Feature |
| CONVERSIONNET-1722 | Horizontal and Vertical resolutions for conversions to Image | New Feature |
| CONVERSIONNET-1692 | When converting a Cell to Pdf, the sheet is split into multiple pdf pages | Bug |
| CONVERSIONNET-1581 | System.ArgumentOutOfRangeException when adding shape to slide and saving | Bug |
| CONVERSIONNET-1709 | Converting TXT to any format with limiting pages produces wrong output | Bug |
| CONVERSIONNET-1684 | Exception when trying to access SaveOptions.ConvertFileType | Bug |
| CONVERSIONNET-1696 | .tif to .png conversion is not as expected | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 17.2.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### ImageSaveOptions.Dpi is marked as obsolete



```csharp
var storagePath = @"c:\Worx\aspose\sources\GroupDocs.Conversion.Test\SampleFiles";
// Setup Conversion configuration
var conversionConfig = new ConversionConfig {StoragePath = storagePath};
//instantiating the conversion handler
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new ImageSaveOptions
{
    ConvertFileType = ImageSaveOptions.ImageFileType.Tiff,
	// Dpi is obsolete, now horizontal and vertical resolutions can be set independently
    HorizontalResolution = 96,
	VerticalResolution = 96
};
var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>("sample.docx", options);
```
