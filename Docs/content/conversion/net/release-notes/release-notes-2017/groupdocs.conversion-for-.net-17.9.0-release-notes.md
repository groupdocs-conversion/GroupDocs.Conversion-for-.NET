---
id: groupdocs-conversion-for-net-17-9-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-17-9-0-release-notes
title: GroupDocs.Conversion for .NET 17.9.0 Release Notes
weight: 4
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 17.9.0{{< /alert >}}

## Major Features

There are 8 new features, improvements and fixes in this regular monthly release. The most notable are:

*   Major improvements in the public API. Note: no braking changes. The redundant methods are marked as obsolete and will be removed after 17.12.0 release
*   Improvement in diagram to HTML conversion
*   Improved conversion from SVG
*   Email to HTML conversion improvements
*   4 bugs fixed  
      
    

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1841 | Convert Diagram to Html improvements | Improvement |
| CONVERSIONNET-2044 | Conversion from SVG improvement | Improvement |
| CONVERSIONNET-2056 | Email to Html conversion improvement | Improvement |
| CONVERSIONNET-2072 | Improved public API | Improvement |
| CONVERSIONNET-1754 | PPTX to HTML Conversion - While converting pptx to html found improper text formatting of Header or missing text | Bug |
| CONVERSIONNET-2042 | ImageSaveOptions.TiffOptions.Compression does not seem to work | Bug |
| CONVERSIONNET-1755 | PPTX to HTML Conversion - Image without background converted with white background also white dot is added near Header Text | Bug |
| CONVERSIONNET-809 | Images are missing when PDF is saved to EPUB | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 17.9.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### GroupDocs.Conversion.Handler.ConversionHandler.Convert<T>

#### Convert a document to file



```csharp
const string sourceFileName = "sample.docx"; //TODO: Put the source filename here with more than 5 pages
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new PdfSaveOptions();
var convertedDocument = conversionHandler.Convert(sourceFileName, options);
convertedDocument.Save("result.pdf");
```

#### Convert a document to stream



```csharp
const string sourceFileName = "sample.docx"; //TODO: Put the source filename here with more than 5 pages
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var options = new PdfSaveOptions();
var convertedDocument = conversionHandler.Convert(sourceFileName, options);
using(MemoryStream targetStream = new MemoryStream) {
    convertedDocument.Save(targetStream);
} 
```

### GroupDocs.Conversion.Handler.ConversionHandler.GetDocumentPagesCount



```csharp
const string sourceFileName = "sample.docx"; //TODO: Put the source filename here with more than 5 pages
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var documentInfo = conversionHandler.GetDocumentInfo(sourceFileName);
var result = documentInfo.PageCount 
```

### GroupDocs.Conversion.Handler.ConversionHandler.GetDocumentType



```csharp
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
//sourceStream should contain the document content
var documentInfo = conversionHandler.GetDocumentInfo(sourceStream);
var result = documentInfo.FileType
```
