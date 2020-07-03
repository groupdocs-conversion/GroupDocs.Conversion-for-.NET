---
id: groupdocs-conversion-for-net-17-1-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-17-1-0-release-notes
title: GroupDocs.Conversion For .NET 17.1.0 Release Notes
weight: 11
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 17.1.0.{{< /alert >}}

## Major Features

There are 11 new features, improvements and fixes in this regular monthly release. The most notable are:

*   Conversions to XPS format
*   Conversions to SVG format
*   Conversions from OTS format
*   Reduced memory usage
*   Fixed 4 bugs

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1683 | Metered licensing | New Feature |
| CONVERSIONNET-1585 | Implement conversion from OTS | New Feature |
| CONVERSIONNET-1598 | Implement conversion to grayscale image | New Feature |
| CONVERSIONNET-1619 | Implement conversion to XPS | New Feature |
| CONVERSIONNET-1624 | Implement conversion to SVG | New Feature |
| CONVERSIONNET-1645 | Improving memory handling on save | Improvement |
| CONVERSIONNET-1646 | Improving output file name if converting from/to page | Improvement |
| CONVERSIONNET-1648 | Improve memory handling in documents | Improvement |
| CONVERSIONNET-1580 | Multipage Tiff is not converted properly to Pdf | Bug |
| CONVERSIONNET-1615 | Page mode conversions do not work | Bug |
| CONVERSIONNET-1643 | HideWordTrackedChanges not respected when converting from word | Bug |
| CONVERSIONNET-1644 | Dpi resolution not respected when converting Cells to Image | Bug |

  

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 17.1.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

#### Metered licensing



```csharp
var storagePath = @"c:\Worx\aspose\sources\GroupDocs.Conversion.Test\SampleFiles";
// Setup Conversion configuration
var conversionConfig = new ConversionConfig {StoragePath = storagePath};

// Create new instance of GroupDocs.Conversion.Metered classs
GroupDocs.Conversion.Metered metered = new GroupDocs.Conversion.Metered();

// Set public and private key to metered instance
metered.SetMeteredKey("***", "***");

// Get metered value before usage of the conversion
decimal amountBefore = GroupDocs.Conversion.Metered.GetConsumptionQuantity();

Console.WriteLine("Amount consumed  before: " + amountBefore);

//instantiating the conversion handler
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new PdfSaveOptions
{
    ConvertFileType = PdfSaveOptions.PdfFileType.Pdf
};
var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>("sample.docx", options);

// Get metered value after usage of the conversion
decimal amountAfter = GroupDocs.Conversion.Metered.GetConsumptionQuantity();

Console.WriteLine("Amount consumed  after: " + amountAfter);


```

#### How to convert to grayscale image



```csharp
var storagePath = @"c:\Worx\aspose\sources\GroupDocs.Conversion.Test\SampleFiles";
// Setup Conversion configuration
var conversionConfig = new ConversionConfig {StoragePath = storagePath};
//instantiating the conversion handler
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new ImageSaveOptions
{
    ConvertFileType = ImageSaveOptions.ImageFileType.Jpg,
    Grayscale = true
};
var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>("sample.docx", options);


```

#### How to convert to SVG



```csharp
var storagePath = @"c:\Worx\aspose\sources\GroupDocs.Conversion.Test\SampleFiles";
// Setup Conversion configuration
var conversionConfig = new ConversionConfig {StoragePath = storagePath};
//instantiating the conversion handler
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new ImageSaveOptions
{
    ConvertFileType = ImageSaveOptions.ImageFileType.Svg
};
var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>("sample.docx", options);

```

#### How to convert to XPS



```csharp
 var storagePath = @"c:\Worx\aspose\sources\GroupDocs.Conversion.Test\SampleFiles";
// Setup Conversion configuration
var conversionConfig = new ConversionConfig {StoragePath = storagePath};
//instantiating the conversion handler
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new PdfSaveOptions
{
    ConvertFileType = PdfSaveOptions.PdfFileType.Xps
};
var convertedDocumentStream = conversionHandler.Convert<IList<Stream>>("sample.docx", options);


```
