---
id: groupdocs-conversion-for-net-18-3-release-notes
url: conversion/net/groupdocs-conversion-for-net-18-3-release-notes
title: GroupDocs.Conversion for .NET 18.3 Release Notes
weight: 9
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 18.3{{< /alert >}}

## Major Features

There are 10+ new features, improvements and fixes in this regular monthly release. The most notable are:

*   Specific options for converting CSV documents
*   Default zoom setting for Cells, Words, Slides
*   Setting for default font to replace all missing fonts  when converting from Words and Cells
*   Bug fixes
    

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-2397 | Implement specific options for converting CSV documents | New Feature |
| CONVERSIONNET-2414 | Implement setting default zoom when converting to Cells | New Feature |
| CONVERSIONNET-2417 | Implement setting default zoom when converting to Words | New Feature |
| CONVERSIONNET-2418 | Implement setting default zoom when converting to Slides | New Feature |
| CONVERSIONNET-2423 | Implement configurable option for setting a watermark as background | New Feature |
| CONVERSIONNET-2395 | Set zoom when converting to Pdf document | Improvement |
| CONVERSIONNET-2406 | Update API for getting document info to detect page orientation for the supported formats | Improvement |
| CONVERSIONNET-2392 | Set default font to replace all missing fonts when converting Words document | Improvement |
| CONVERSIONNET-2394 | Set default font to replace all missing fonts when converting Cells document | Improvement |
| CONVERSIONNET-2421 | Conversion improvement when converting Psd and Odg to Pdf | Improvement |
| CONVERSIONNET-2304 | XPS to PDF conversion failed | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 18.3. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### Getting document info to detect page orientation for the supported formats

#### Introduced new property PageOrientation in DocumentInfo class

```csharp
/// <summary>
/// Get page orientation
/// </summary>
public PageOrientationType PageOrientation { get; }
```

Usage

```csharp
var documentInfo = conversionHandler.GetDocumentInfo("source.docx");
Console.Write(documentInfo.PageOrientation);
```

### Set default font to replace all missing fonts when converting Cells document

#### Introduced new property DefaultFont in CellsLoadOptions class

```csharp
/// <summary>
/// Default font for Cells document. The following font will be used if a font is missing.
/// </summary>
public string DefaultFont { get; set; }
```

Usage

```csharp
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
 
var loadOptions = new CellsLoadOptions();
loadOptions.DefaultFont = "Verdana";
 
var saveOptions = new PdfSaveOptions();
 
var convertedDocument = conversionHandler.Convert("source.xlsx", loadOptions, saveOptions);
```

### Set default font to replace all missing fonts when converting Words document

#### Introduced new property DefaultFont in WordsLoadOptions class

```csharp
/// <summary>
/// Default font for Words document. The following font will be used if a font is missing.
/// </summary>
public string DefaultFont { get; set; }
```

Usage

```csharp
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
 
var loadOptions = new WordsLoadOptions();
loadOptions.DefaultFont = "Verdana";
 
var saveOptions = new PdfSaveOptions();
 
var convertedDocument = conversionHandler.Convert("source.docx", loadOptions, saveOptions);
```

### Show watermark behind the text

#### Introduced new property Background in WatermarkOptions class

```csharp
/// <summary>
/// Indicates that the watermark is stamped as background. If the value is true, the watermark is layed at the bottom. By default is false and the watermark is layed on top.
/// </summary>
public bool Background { get; set; }
```

Usage

```csharp
var saveOptions = new PdfSaveOptions();
saveOptions.WatermarkOptions.Background = true;
```
