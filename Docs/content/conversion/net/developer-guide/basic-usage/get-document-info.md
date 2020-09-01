---
id: get-document-info
url: conversion/net/get-document-info
title: Get document info
weight: 2
description: "This article explains how to detect document file type and calculate pages count when convert file with GroupDocs.Conversion for .NET."
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
[**GroupDocs.Conversion**](https://products.groupdocs.com/conversion/net) allows to get basic document information (like pages count) for every supported document type, which may be useful for converting part of source document or per-page conversion.  
Along with this GroupDocs.Conversion provides additional information for the following document types:

*   CAD drawings - collection of layouts and layers;
*   Email - attachments count, is html body, is encrypted, is signed;
*   PDF document - pages count, is landscaped, is encrypted, author and creation date;
*   Image - width, height, image format;
*   Presentation document - slides count, author, creation date and presentation format;
*   Spreadsheet document - worksheets count, author and creation date;
*   Wordprocessing document - pages count, lines count, words count, author and creation date.

Here is a code snippet to demonstrate how to obtain document info for PDF document.

```csharp
using (Converter converter = new Converter("sample-toc.pdf"))
{
    IDocumentInfo info = converter.GetDocumentInfo();
    PdfDocumentInfo pdfInfo = (PdfDocumentInfo) info;
    Console.WriteLine("Author: {0}", pdfInfo.Author);
    Console.WriteLine("Creation date: {0}", pdfInfo.CreationDate);
    Console.WriteLine("Title: {0}", pdfInfo.Title);
    Console.WriteLine("Version: {0}", pdfInfo.Version);
    Console.WriteLine("Pages count: {0}", pdfInfo.PagesCount);
    Console.WriteLine("Width: {0}", pdfInfo.Width);
    Console.WriteLine("Height: {0}", pdfInfo.Height);
    Console.WriteLine("Is landscaped: {0}", pdfInfo.IsLandscape);
    Console.WriteLine("Is Encrypted: {0}", pdfInfo.IsEncrypted);
    foreach (var tocItem in pdfInfo.TableOfContents)
    {
        Console.WriteLine($"{tocItem.Title}: {tocItem.Page}");
    }
}
```

## More resources
### Advanced Usage Topics
To learn more about document viewing features, please refer to the [advanced usage section]({{< ref "conversion/net/developer-guide/advanced-usage/_index.md" >}}).

### GitHub Examples
You may easily run the code above and see the feature in action in our GitHub examples:
*   [GroupDocs.Conversion for .NET examples, plugins, and showcase](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET)
*   [GroupDocs.Conversion for Java examples, plugins, and showcase](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java)
*   [Document Conversion for .NET MVC UI Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC)
*   [Document Conversion for .NET App WebForms UI Modern Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-WebForms)
*   [Document Conversion for Java App Dropwizard UI Modern Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java-Dropwizard)
*   [Document Conversion for Java Spring UI Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java-Spring)

### Free Online Document Converter Apps
Along with full-featured .NET library we provide free Apps and free services for document conversion.
In order to see a full potential of GroupDocs.Conversion, you are welcome to convert DOC to PDF, DOC to XLSX, PDF to DOC, PDF to XLSX, PPT to DOC and more with **[Free Online Document Converter App](https://products.groupdocs.app/conversion)** or get a full advantage of **[Free Online Document Converter Suite](https://conholdate.app/features/document-converter-online)** with advanced conversion settings and many more enterprise built-in features.

**Please note** that more [premium features](https://conholdate.app/features), advanced options and enhanced document management experience is available for signed-in users at [conholdate.app](https://conholdate.app) for **FREE**.  
If you don't own an account yet, register it now for free! No credit card is required!
