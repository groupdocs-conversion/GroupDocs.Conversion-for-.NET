---
id: groupdocs-conversion-for-net-18-10-release-notes
url: conversion/net/groupdocs-conversion-for-net-18-10-release-notes
title: GroupDocs.Conversion for .NET 18.10 Release Notes
weight: 2
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 18.10{{< /alert >}}

## Major Features

This regular monthly release contains several improvements and bug fixes. Most notable are: 

*   Fixed bug where image inside presentation isn't the same in ODP output
*   Fixed bug where border are missing in ODS Excel output
*   Fixed bug XLSX file eats almost 2 GB RAM while converting and the process never completes
*   Introduced option for removing embedded files in Pdf

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1957 | Implement option for removing embedded files in Pdf | Improvement |
| CONVERSIONNET-1873 | The image inside presentation isn't the same in ODP output | Bug |
| CONVERSIONNET-1874 | Missing border in ODS Excel output | Bug |
| CONVERSIONNET-1923 | XLSX file eats almost 2 GB RAM while converting and the process never completes | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 18.10. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### Introduced PdfLoadOptions when converting from PDF

```csharp
/// <summary>
/// Pdf document load options
/// </summary>
public class PdfLoadOptions : LoadOptions
{
     /// <summary>
     /// Remove embedded files
     /// </summary>
     public bool RemoveEmbeddedFiles { get; set; }
}
```

Usage

```csharp
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
             
const string source = "source.pdf";
var loadOptions = new PdfLoadOptions{
    RemoveEmbeddedFiles = true
}
var saveOptions = new PdfSaveOptions();
saveOptions.PdfOptions.FormatingOptions.PageMode = PdfFormatingOptions.PdfPageMode.FullScreen;
saveOptions.PdfOptions.FormatingOptions.PageLayout = PdfFormatingOptions.PdfPageLayout.SinglePage;
var convertedDocument = conversionHandler.Convert(source, loadOptions, saveOptions);
convertedDocument.Save("result");
```
