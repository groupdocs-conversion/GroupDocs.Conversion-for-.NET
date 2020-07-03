---
id: groupdocs-conversion-for-net-3-4-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-3-4-0-release-notes
title: GroupDocs.Conversion For .NET 3.4.0 Release Notes
weight: 5
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 3.4.0{{< /alert >}}

## Major Features

There are 5 improvements and fixes in this regular monthly release. The most notable are:

*   Conversion of Html to image
*   When converting from word, option for hide/show tracked changes in the converted document
*   Fixed respecting dpi setting when converting image to image
*   Fixed respecting dpi setting when converting diagram to image

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-924 | Option when converting from Words for show/hide markup and tack changes | New Feature |
| CONVERSIONNET-979 | Html to image conversion | New Feature |
| CONVERSIONNET-911 | Image to Image conversion - target resolution is not changed when setting Dpi | Bug |
| CONVERSIONNET-912 | Diagram to Image conversion - target resolution is not changed when setting Dpi | Bug |
| CONVERSIONNET-1072 | Txt to Pdf is causing "Unknown format" exception | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 3.4.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

##### How to hide tracked changes when converting from words



```csharp
const string sourceFileName = "sample.docx"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);

// Save options
SaveOptions saveOptions = new PdfSaveOptions
{
    OutputType = OutputType.String,
    HideWordTrackedChanges = true
};

var result = conversionHandler.Convert<string>(sourceFileName, saveOptions);

```

##### How to convert html to image



```csharp
const string sourceFileName = "sample.html"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);

// Save options
SaveOptions saveOptions = new ImageSaveOptions
{
    OutputType = OutputType.String,
    Dpi = 300
};

var result = conversionHandler.Convert<IList<string>>(sourceFileName, saveOptions);

```
