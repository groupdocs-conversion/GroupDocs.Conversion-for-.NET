---
id: groupdocs-conversion-for-net-18-4-release-notes
url: conversion/net/groupdocs-conversion-for-net-18-4-release-notes
title: GroupDocs.Conversion for .NET 18.4 Release Notes
weight: 8
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 18.4{{< /alert >}}

## Major Features

There are 5+ new features, improvements and fixes in this regular monthly release. The most notable are:

*   Specify bookmark level, heading level and expanded level when converting Word to PDF and XPS
*   Linearize PDF Document for the Web when converting to PDF
*   Resource optimization options when converting to PDF
*   Option for applying image watermark
*   Create HTML5 compliant markup when converting to html
*   Bug fixes
    

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-2434 | Specify bookmark level, headings level and expanded level when converting from Words to PDF and XPS | New Feature |
| CONVERSIONNET-2457 | Implement option for creating linearized PDF when converting to PDF | New Feature |
| CONVERSIONNET-2458 | Implement option for converting to grayscale PDF | New Feature |
| CONVERSIONNET-2459 | Implement option for resource optimization when converting to PDF | New Feature |
| CONVERSIONNET-2471 | Implement option for applying image watermark | New Feature |
| CONVERSIONNET-2454 | Create HTML 5 compliant markup when converting to html | Improvement |
| CONVERSIONNET-2432 | Index was outside the bound of the array, when cache is enabled and watermarks are applied | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 18.4. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### Introduced new property in WatemarkOptions

```csharp
/// <summary>
/// Image watermark
/// </summary>
public byte[] Image { get; set; }
```

Usage

```csharp
byte[] image = System.IO.File.ReadAllBytes ( "image.jpg" );
var saveOptions = new PdfSaveOptions();
saveOptions.WatermarkOptions.Image = image;
```

### Introduced new property in PdfOptions

```csharp
/// <summary>
/// Convert a PDF from RGB colorspace to Grayscale
/// </summary>
public bool Grayscale { get; set; } 
```

Usage

```csharp
var saveOptions = new PdfSaveOptions();
saveOptions.PdfOptions.Grayscale = true;
```

### Introduced new property in PdfOptions

```csharp
/// <summary>
/// Linearize PDF Document for the Web
/// </summary>
public bool Linearize { get; set; } 
```

Usage

```csharp
var saveOptions = new PdfSaveOptions();
saveOptions.PdfOptions.Linearize = true;
```

### Introduced new property in PdfOptions

```csharp
/// <summary>
/// Pdf optimization options
/// </summary>
public PdfOptimizationOptions OptimizationOptions { get; }
```

Usage

```csharp
var saveOptions = new PdfSaveOptions();
 
// all images in the document are re-compressed. The compression is defined by the ImageQuality property.
saveOptions.PdfOptions.OptimizationOptions.CompressImages = true;
 
//  value in percent where 100% is unchanged quality and image size. To decrease the image size, use ImageQuality less than 100
saveOptions.PdfOptions.OptimizationOptions.ImageQuality = 50;
 
// Link duplcate streams
saveOptions.PdfOptions.OptimizationOptions.LinkDuplcateStreams = true;
 
// Remove unused objects
saveOptions.PdfOptions.OptimizationOptions.RemoveUnusedObjects = true;
 
// Remove unused streams
saveOptions.PdfOptions.OptimizationOptions.RemoveUnusedStreams = true;
 
// Make fonts not embedded if set to true
saveOptions.PdfOptions.OptimizationOptions.UnembedFonts = true;
```

### Introduced new property WordBookmarkOptions in PdfSaveOptions

```csharp
/// <summary>
/// If the input document is Word the conversion will handle the word bookmarks regarding this option.
/// </summary>
public WordBookmarksOptions WordBookmarkOptions { get; }
```

Usage

```csharp
var saveOptions = new PdfSaveOptions();
saveOptions.WordBookmarkOptions.BookmarksOutlineLevel = 5;
saveOptions.WordBookmarkOptions.HeadingsOutlineLevels = 5;
saveOptions.WordBookmarkOptions.ExpandedOutlineLevels = 9;
```
