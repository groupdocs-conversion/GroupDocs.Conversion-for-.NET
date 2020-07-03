---
id: groupdocs-conversion-for-net-16-12-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-16-12-0-release-notes
title: GroupDocs.Conversion For .NET 16.12.0 Release Notes
weight: 1
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 16.12.0{{< /alert >}}

## Major Features

There are 12 new features, improvements and fixes in this regular monthly release. The most notable are:

*   Conversions from and to Webp format
*   Improved memory handling
*   Improved performance
*   Fixed 5+ bugs

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1480 | Implement conversion from Webp | New Feature |
| CONVERSIONNET-1483 | Implement conversion to Webp | New Feature |
| CONVERSIONNET-1485 | Use LZW compression for internal tiff compression | Improvement |
| CONVERSIONNET-1484 | Improve memory handling | Improvement |
| CONVERSIONNET-1518 | Converting to image with set DPI options without setting image width and height is producing invalid image | Bug |
| CONVERSIONNET-1557 | HideWordTrackedChanges set to 'true' but still its showing track chnages and markup | Bug |
| CONVERSIONNET-1564 | Exception when loading EPUB in multithread | Bug |
| CONVERSIONNET-1566 | Exception when converting DWG to PNG in multithread | Bug |
| CONVERSIONNET-1567 | Exception is thrown when resizing specific Pdf file | Bug |
| CONVERSIONNET-1158 | Convert to HTML from PDF - Words in Bold Letters are not properly displayed | Bug |
| CONVERSIONNET-845 | Pdf to Html conversion formatting issue | Bug |
| CONVERSIONNET-1568 | Wrong characters when saving in HTML | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 16.12.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

#### How to convert to WebP



```csharp
var storagePath = @"c:\Worx\aspose\sources\GroupDocs.Conversion.Test\SampleFiles";
// Setup Conversion configuration
var conversionConfig = new ConversionConfig {StoragePath = storagePath};
//instantiating the conversion handler
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new ImageSaveOptions
{
    ConvertFileType = ImageSaveOptions.ImageFileType.Webp,
    WebpOptions =
    {
        Lossless = true
    }
};
var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>("sample.docx", options);


```
