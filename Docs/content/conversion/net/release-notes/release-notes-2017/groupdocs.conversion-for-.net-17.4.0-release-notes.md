---
id: groupdocs-conversion-for-net-17-4-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-17-4-0-release-notes
title: GroupDocs.Conversion for .NET 17.4.0 Release Notes
weight: 8
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 17.4.0{{< /alert >}}

## Major Features

There are 11 new features, improvements and fixes in this regular monthly release. The most notable are:

*   Introduced new method for retrieving basic metadata of the source document
*   Improved handling of extension-less urls
*   Improved to HTML conversions
*   Improved HTML to Cells conversions
*   Fixed 3 bugs

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1810 | Implement method for getting extended document information | New Feature |
| CONVERSIONNET-1835 | Convert Html to Cells improvements | Improvement |
| CONVERSIONNET-1845 | Convert Cad to Html improvements | Improvement |
| CONVERSIONNET-1846 | Convert Note to Html improvements | Improvement |
| CONVERSIONNET-1840 | Convert Slides to Html improvements | Improvement |
| CONVERSIONNET-1847 | Convert Tasks to Html improvements | Improvement |
| CONVERSIONNET-1851 | Convert Words to Html improvements with UsePdf=true option set | Improvement |
| CONVERSIONNET-1871 | Improved handling of extension-less urls | Improvement |
| CONVERSIONNET-1678 | Failed to validate PDF\_X\_3 and PDF\_X\_1A | Bug |
| CONVERSIONNET-1844 | Converting Image to Html with UsePdf=true always use direct conversion instead converting through Pdf | Bug |
| CONVERSIONNET-1676 | Loading Latex document from stream requires FileStream | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 17.4.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### How to get source document metadata 



```csharp
const string sourceFileName = "sample.docx"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
DocumentInfo documentInfo = conversionHandler.GetDocumentInfo(sourceFileName);
 
Console.WriteLine("Size: {0}", documentInfo.Size);
Console.WriteLine("File type: {0}", documentInfo.FileType);
Console.WriteLine("Pages count: {0}", documentInfo.PageCount);
Console.WriteLine("Last modified: {0}", documentInfo.ModifiedDate);
```
