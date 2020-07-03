---
id: groupdocs-conversion-for-net-17-7-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-17-7-0-release-notes
title: GroupDocs.Conversion for .NET 17.7.0 Release Notes
weight: 6
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 17.7.0{{< /alert >}}

## Major Features

There are 4 new features, improvements and fixes in this regular monthly release. The most notable are:

*   Returning available layouts for a CAD document
*   Option to hide PDF annotations when converting from PDF
*   Option to specify exact layout to convert from a CAD document
*   Option to specify Width and Height for the result document when converting From CAD document  
      
    

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1968 | Update DocumentInfo class to return all layouts for CAD document types | New Feature |
| CONVERSIONNET-1969 | Implement possibility to convert specific layouts when converting from CAD document | New Feature |
| CONVERSIONNET-1970 | Convert Pdf documents without annotations | New Feature |
| CONVERSIONNET-1962 | Implement possibility to set Width and Height when converting from CAD document | Improvement |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 17.7.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### How to get available layouts in a CAD document



```csharp
const string sourceFileName = "sample.dwg"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var result = conversionHandler.GetDocumentInfo(sourceFileName);
foreach (var layer in result.Layers)
{
    Console.WriteLine(layer);
}
```

### How to convert specific layout from a CAD document



```csharp
const string sourceFileName = "sample.dwg"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new PdfSaveOptions
{
    OutputType = OutputType.String
};
options.CadOptions.LayoutNames = new[] {"layout-1"};
var result = conversionHandler.Convert<string>(sourceFileName, options);
```

### How to set specific width and height for each layout from a CAD document



```csharp
const string sourceFileName = "sample.dwg"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new PdfSaveOptions
{
    OutputType = OutputType.String
};
options.CadOptions.Width = 800;
options.CadOptions.Height = 600;
var result = conversionHandler.Convert<string>(sourceFileName, options);
```

### How to hide annotations when converting from PDF



```csharp
const string sourceFileName = "sample.pdf"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new WordsSaveOptions
{
    OutputType = OutputType.String,
    HidePdfAnnotations = true
};
var result = conversionHandler.Convert<string>(sourceFileName, options);
```
