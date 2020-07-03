---
id: groupdocs-conversion-for-net-3-1-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-3-1-0-release-notes
title: GroupDocs.Conversion For .NET 3.1.0 Release Notes
weight: 8
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 3.1.0{{< /alert >}}

## Major Features

There are 4 new features in this regular monthly release. The most notable are:

*   Detecting document type from streams.
*   Document conversion progress.

## All Changes

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-680 | Implement document conversion from stream with auto detect source file type | New Feature |
| CONVERSIONNET-662 | Autodetect source document type when converting from stream | New Feature |
| CONVERSIONNET-655 | Report conversion progress | New Feature |
| CONVERSIONNET-654 | Return all supported conversions types with single method | New Feature |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 3.1.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### How to get available save options for a document by file extension



```csharp
const string sourceDocument = "source.docx";
// Setup Conversion configuration
var conversionConfig = new ConversionConfig();
var conversionHandler = new ConversionHandler(conversionConfig);
var documentExtension = Path.GetExtension(sourceDocument).TrimStart('.');
//returns IDictionary<string, SaveOptions>
var availableConversions = conversionHandler.GetSaveOptions(documentExtension);
//list all available conversions
foreach (var name in availableConversions.Keys)
{
Console.WriteLine(name);
}
//use prepared save option for ToPdf conversion
var result = conversionHandler.Convert<string>("test.doc", availableConversions["pdf"]);
 
```

#### How to get available save options for a document stream



```csharp
const string sourceDocument = "source.docx";
// Setup Conversion configuration
var conversionConfig = new ConversionConfig();
var conversionHandler = new ConversionHandler(conversionConfig);
var sourceStream = new FileStream(sourceDocument, FileMode.Open);
//returns IDictionary<string, SaveOptions>
var availableConversions = conversionHandler.GetSaveOptions(sourceStream);
//list all available conversions
foreach (var name in availableConversions.Keys)
{
Console.WriteLine(name);
}
//use prepared save option for ToPdf conversion
var result = conversionHandler.Convert<string>(sourceStream, availableConversions["pdf"]);
 
```

#### How to get conversion progress



```csharp
const string sourceFileName = "sample.doc"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
CachePath = "cache",
StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
conversionHandler.ConversionProgress += ConversionProgressHandler;
var resultPath = conversionHandler.Convert<string>(sourceFileName,
new PdfSaveOptions { OutputType = OutputType.String });
Console.WriteLine("The conversion finished. The result can be located here: {0}. Press <<ENTER>> to exit.",
resultPath);
Console.ReadLine();
 
```

#### Conversion progress handler



```csharp
private static void ConversionProgressHandler(object sender,
ConversionProgressEventArgs args)
{
Console.WriteLine("Conversion progress: {0}", args.Progress);
}
 
```
