---
id: groupdocs-conversion-for-net-3-3-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-3-3-0-release-notes
title: GroupDocs.Conversion For .NET 3.3.0 Release Notes
weight: 6
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 3.3.0{{< /alert >}}

## Major Features

There are 16 improvements and fixes in this regular monthly release. The most notable are:

*   Conversion of SVG documents
*   Conversion of XPS documents
*   Conversion of ICO files
*   When converting to Slides, option for removing slides comments
*   Fixed XLSX to PNG/JPG/HTML conversion
*   Respecting DPI option when converting to image

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-834 | Option for removing comments when converting slides documents | New Feature |
| CONVERSIONNET-835 | Implement SVG document conversion | New Feature |
| CONVERSIONNET-846 | Implement XPS document conversion | New Feature |
| CONVERSIONNET-886 | Implement conversion to ICO | New Feature |
| CONVERSIONNET-844 | xlsx to png Object null Reference exception | Bug |
| CONVERSIONNET-889 | Conversion from XLSX to PNG/JPG/HTML not Working Properly | Bug |
| CONVERSIONNET-890 | Converted File Name issue in Excel file to PNG | Bug |
| CONVERSIONNET-897 | Converting large XLS file to image with UsePdf=false is producing blurred images | Bug |
| CONVERSIONNET-898 | Missing pages when converting XLS file to image with UsePdf=true | Bug |
| CONVERSIONNET-899 | Excel to PNG/JPG/JPEG Low Image Quality Dpi not effecing | Bug |
| CONVERSIONNET-907 | PDF to Image conversion - target resolution is not changed when setting Dpi | Bug |
| CONVERSIONNET-908 | Words to Image conversion - target resolution is not changed when setting Dpi | Bug |
| CONVERSIONNET-909 | Slides to Image conversion - target resolution is not changed when setting Dpi | Bug |
| CONVERSIONNET-910 | Tasks to Image conversion - target resolution is not changed when setting Dpi | Bug |
| CONVERSIONNET-911 | Image to Image conversion - target resolution is not changed when setting Dpi | Bug |
| CONVERSIONNET-912 | Diagram to Image conversion - target resolution is not changed when setting Dpi | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 3.3.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

##### How to remove slides comments when converting to Slides



```csharp
const string sourceFileName = "sample.pptx"; //TODO: Put the source filename here
// Setup Conversion configuration

var conversionConfig = new ConversionConfig
 {
 CachePath = "cache",
 StoragePath = "."
 }

var conversionHandler = new ConversionHandler(conversionConfig);

// Save options
SaveOptions saveOptions = new SlidesSaveOptions
{
OutputType = OutputType.String,
RemoveSlidesComments = true
};

var result = conversionHandler.Convert<string>(sourceFileName, saveOptions);

```
