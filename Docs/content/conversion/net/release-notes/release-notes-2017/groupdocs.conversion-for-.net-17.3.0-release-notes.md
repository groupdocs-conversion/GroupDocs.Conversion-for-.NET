---
id: groupdocs-conversion-for-net-17-3-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-17-3-0-release-notes
title: GroupDocs.Conversion for .NET 17.3.0 Release Notes
weight: 9
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 17.3.0{{< /alert >}}

## Major Features

There are 7 new features, improvements and fixes in this regular monthly release. The most notable are:

*   Conversions from DNG
*   Conversions from DGN
*   Conversions from VSSX and VSTX
*   Conversions from ONE
*   Option to hide WORD comments when converting from word
*   Improved performance of HTML to PDF conversions
*   Fixed 1 bug

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1729 | Implement conversion from DNG | New Feature |
| CONVERSIONNET-1737 | Implement conversion from DGN | New Feature |
| CONVERSIONNET-1745 | Implement conversion from VSSX and VSTX | New Feature |
| CONVERSIONNET-1761 | Ability to hide words comments when converting from word | New Feature |
| CONVERSIONNET-1760 | Implement conversion from ONE | New Feature |
| CONVERSIONNET-1719 | Convert Html to Pdf improvements | Improvement |
| CONVERSIONNET-1597 | Memory leak when converting CAD stream to image | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 17.3.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### How to hide comments when converting from Words 



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
    HideWordComments = false
};
 
var result = conversionHandler.Convert<string>(sourceFileName, saveOptions);
```
