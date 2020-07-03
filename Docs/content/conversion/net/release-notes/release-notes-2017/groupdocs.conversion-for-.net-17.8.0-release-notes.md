---
id: groupdocs-conversion-for-net-17-8-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-17-8-0-release-notes
title: GroupDocs.Conversion for .NET 17.8.0 Release Notes
weight: 5
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 17.8.0{{< /alert >}}

## Major Features

There are 4 new features, improvements and fixes in this regular monthly release. The most notable are:

*   Hide comments from Cells documents
*   Option to convert specific pages (e.g. 1,3,5) from source document
*   Simplifying the generated HTML markup
*   Fixed bug with fixed layout when converting to HTML  
      
    

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1999 | Hide comments for Cells documents | New Feature |
| CONVERSIONNET-1984 | Implement possibility to convert specific pages | New Feature |
| CONVERSIONNET-2003 | Simplify the generated HTML markup | Improvement |
| CONVERSIONNET-2020 | Converting to Html with SaveOptions.FixedLayout=false always produce fixed layout html conversion | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 17.8.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### How to hide comments when converting from Cells



```csharp
const string sourceFileName = "sample.xlsx"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new PdfSaveOptions
{
    OutputType = OutputType.String,
    HideComments = true
};
var result = conversionHandler.Convert<string>(sourceFileName, options);

```

### How to convert specific pages from source document



```csharp
const string sourceFileName = "sample.docx"; //TODO: Put the source filename here with more than 5 pages
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new PdfSaveOptions
{
    OutputType = OutputType.String,
    ConvertPages = new List<int> { 1, 3, 5}
};
var result = conversionHandler.Convert<string>(sourceFileName, options);
```

### How to get simplified markup when converting to HTML



```csharp
const string sourceFileName = "sample.docx"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new HtmlSaveOptions
{
    OutputType = OutputType.String,
    FixedLayout = false
};
var result = conversionHandler.Convert<string>(sourceFileName, options);

```
