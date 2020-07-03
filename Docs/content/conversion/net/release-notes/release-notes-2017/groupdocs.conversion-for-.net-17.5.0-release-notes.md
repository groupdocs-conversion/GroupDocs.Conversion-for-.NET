---
id: groupdocs-conversion-for-net-17-5-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-17-5-0-release-notes
title: GroupDocs.Conversion for .NET 17.5.0 Release Notes
weight: 7
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 17.5.0{{< /alert >}}

## Major Features

There are 9 new features, improvements and fixes in this regular monthly release. The most notable are:

*   Conversion from XML-FO/XSL to PDF
*   New option to set zoom when converting to HTML
*   Conversion from Vsdm, Vssm, Vstm
*   Conversion from LaTex
*   Improved speed when converting from cells.
*   Improved memory usage
*   Fixed 1 bug

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1892 | Implement conversion from XML-FO/XSL | New Feature |
| CONVERSIONNET-1910 | Option to set zoom when converting to HTML | New Feature |
| CONVERSIONNET-1917 | Conversion from Vsdm, Vssm, Vstm | New Feature |
| CONVERSIONNET-1928 | Implement conversion from LaTex | New Feature |
| CONVERSIONNET-1756 | PPTX to HTML Conversion - Slide zoom level property | New Feature |
| CONVERSIONNET-1881 | Improve SlidesToHtml saver | Improvement |
| CONVERSIONNET-1885 | Update CellsToImageSaver and CellsToPdfSaver to remove empty rows and columns before saving document | Improvement |
| CONVERSIONNET-1884 | PPt to PDF Conversion - Tables borders are showing - showgridline property is also not working for this | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 17.5.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### How to convert XML-FO/XSL to PDF



```csharp
const string sourceFileName = "sample.xml"; //TODO: Put the source filename here
const string foFileName = "sample.xslt";
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
using (var foStream = new FileStream(foFileName, FileMode.Open, FileAccess.Read))
{
    var pdfSaveOptions = new PdfSaveOptions{
       OutputType = OutputType.String
    };
    var xmlLoadOptions = new XmlLoadOptions
    {
        XslFo = foStream
    };
    var result = conversionHandler.Convert<string>(sourceFileName, xmlLoadOptions, pdfSaveOptions);
}
```

### How to set zoom when converting slides to HTML



```csharp
const string sourceFileName = "sample.pptx"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var saveOptions = new HtmlSaveOptions
{
    OutputType = OutputType.String,
    Zoom = 150,
};

var resultPath = conversionHandler.Convert<string>(sourceFileName, saveOptions);
```
