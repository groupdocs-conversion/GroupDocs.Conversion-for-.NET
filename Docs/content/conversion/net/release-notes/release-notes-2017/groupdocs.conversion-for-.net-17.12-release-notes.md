---
id: groupdocs-conversion-for-net-17-12-release-notes
url: conversion/net/groupdocs-conversion-for-net-17-12-release-notes
title: GroupDocs.Conversion for .NET 17.12 Release Notes
weight: 1
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 17.12{{< /alert >}}

## Major Features

There are 5+ new features, improvements and fixes in this regular monthly release. The most notable are:

*   Conversion from/to Jpeg 2000
*   Option to convert one sheet per page depending from print area when converting Cells to PDF
*   Option to optimize resulting PDF to minimum file size
*   Improved image to SVG conversion
*   Improved word to GIF conversion
*   Bug fixes

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-2277 | Implement conversion from/to Jpeg2000 | New Feature |
| CONVERSIONNET-2257 | Implement possibility to convert one sheet per page or depending on print area when converting Cells to Pdf | Improvement |
| CONVERSIONNET-2258 | Implement possibility to optimize target Pdf for minimum file size when converting Cells to Pdf | Improvement |
| CONVERSIONNET-2262 | Image to SVG conversion improvement | Improvement |
| CONVERSIONNET-2266 | Words to Gif conversion improvement | Improvement |
| CONVERSIONNET-2240 | PDF to TIF conversion, InvalidValueFormatException | Bug |
| CONVERSIONNET-2234 | Index was outside the bounds of the array, while Converting .xlsx File To PDF | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 17.12. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### GroupDocs.Conversion.Converter.Option.CellsOptions

#### Introduced new property OnePagePerSheet 

```csharp
/// <summary>
/// If true the content of the sheet will be converted to one page in the PDF document. Default value is true.
/// </summary>
public bool OnePagePerSheet { get; set; }
```

#### Usage

```csharp
var saveOptions = new PdfSaveOptions();
saveOptions.CellsOptions.OnePagePerSheet = false;
```

#### Introduced new property OptimizedPdfSize

```csharp
/// <summary>
/// If True and converting to Pdf the conversion is optimized for better file size than print quality
/// </summary>
public bool OptimizePdfSize { get; set; }
```

#### Usage

```csharp
var saveOptions = new PdfSaveOptions();
saveOptions.CellsOptions.OptimizePdfSize= false;
```
