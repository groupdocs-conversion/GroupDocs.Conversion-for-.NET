---
id: migration-notes
url: conversion/net/migration-notes
title: Migration Notes
weight: 4
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
### Why To Migrate?
  
Here are the key reasons to use the new updated API provided by GroupDocs.Conversion for .NET since version 19.9:

*   **Converter** class introduced as a **single entry point** to manage the document conversion process to any supported file format (instead of **ConversionHander** class from previous versions). 
*   The overall **conversion speed improved** dramatically by saving each page as soon as it was converted, not when all pages list were converted.
*   Product architecture was redesigned from scratch in order to **decreased memory usage** (from 10% to 400% approx. depending on document type).
*   Document **convert options simplified** for easy control over document conversion and saving processes.  
    

### How To Migrate?

Here is a brief comparison of how to convert document into PDF format using old and new API.  

**Old coding style**

```csharp
string documentPath = "sample.docx";
string outputPath = @"C:\output\converted.pdf";

//Instantiating the conversion handler
ConversionHandler conversionHandler = Common.getConversionHandler();

var saveOptions = new GroupDocs.Conversion.Converter.Option.PdfSaveOptions();
saveOptions.ConvertFileType = PdfSaveOptions.PdfFileType.Pdf;
 
var convertedDocumentPath = conversionHandler.Convert(documentPath , saveOptions);
convertedDocumentPath.Save(@"C:\output\converted.pdf");
```

**New coding style**

```csharp
string documentPath = @"C:\sample.docx"; 
string outputPath = @"C:\output\converted.pdf";
 
using (Converter converter = new Converter(documentPath))
{
    PdfConvertOptions convertOptions = new PdfConvertOptions();
    converter.Convert(outputPath, convertOptions);
}
```

For more code examples and specific use cases please refer to our [Developer Guide]({{< ref "conversion/net/developer-guide/_index.md" >}}) documentation or [GitHub](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET) samples and showcases.
