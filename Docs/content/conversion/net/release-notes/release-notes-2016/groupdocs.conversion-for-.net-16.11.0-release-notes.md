---
id: groupdocs-conversion-for-net-16-11-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-16-11-0-release-notes
title: GroupDocs.Conversion For .NET 16.11.0 Release Notes
weight: 2
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 16.11.0{{< /alert >}}

## Major Features

There are 12 new features, improvements and fixes in this regular monthly release. The most notable are:

*   Conversions from DjVu format
*   Conversions from EMF format
*   Conversions from WMF format
*   Conversions from DICOM format
*   Conversions from OTP format
*   Helper method to return possible conversions from file extension or stream
*   Helper method to return pages count of a document which will be converted
*   Improved progress reporting
*   Improved performance of Word to Pdf and Word to Epub conversions

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1387 | Implement OTP file format conversion | New Feature |
| CONVERSIONNET-1413 | Implement DICOM file format conversion | New Feature |
| CONVERSIONNET-1418 | Implement conversion from WMF | New Feature |
| CONVERSIONNET-1419 | Implement conversion from EMF | New Feature |
| CONVERSIONNET-1447 | Count total pages of a document | New Feature |
| CONVERSIONNET-1458 | Return all possible conversions from file extension or stream | New Feature |
| CONVERSIONNET-1425 | Implement conversion from DjVu | New Feature |
| CONVERSIONNET-1376 | Improve performance of Word to Pdf and Word to Epub conversions | Improvement |
| CONVERSIONNET-1400 | Improve progress reporting | Improvement |
| CONVERSIONNET-1399 | Progress report is not working | Bug |
| CONVERSIONNET-1424 | Mssing "Fixedlayout" Property while Updating VB Example | Bug |
| CONVERSIONNET-1414 | File name contains extra symbols | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 16.11.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

#### How to get pages count of a document which will be converted



```csharp
const string sourceFileName = "sample.docx"; //TODO: Put the source filename here
// Setup Conversion configuration \\
var conversionConfig = new ConversionConfig \\ {\\
 CachePath = "cache",\\
 StoragePath = "."\\
 };
var conversionHandler = new ConversionHandler(conversionConfig);

 var count = conversionHandler.GetDocumentPagesCount(sourceFileName);


```

#### How to get possible conversions from file extension



```csharp
const string sourceFileName = "sample.docx"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
 { CachePath = "cache",\ StoragePath = "." };
var conversionHandler = new ConversionHandler(conversionConfig);

string[] possibleConversions = conversionHandler.GetPossibleConversions(".docx");


```

#### How to get possible conversions from stream



```csharp
 const string sourceFileName = "./sample.docx"; //TODO: Put the source filename here |

// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
CachePath = "cache",
StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);

using (var fileStream = new FileStream(sourceFileName, FileMode.Open, FileAccess.Read))
{
string[] possibleConversions = conversionHandler.GetPossibleConversions(fileStream);
}


```
