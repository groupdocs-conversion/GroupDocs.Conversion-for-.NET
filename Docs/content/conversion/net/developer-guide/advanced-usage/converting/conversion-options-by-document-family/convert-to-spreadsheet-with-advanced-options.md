---
id: convert-to-spreadsheet-with-advanced-options
url: conversion/net/convert-to-spreadsheet-with-advanced-options
title: Convert to Spreadsheet with advanced options
weight: 7
description: "Follow this guide and learn how to convert documents to Excel and Open Document spreadsheets of XLS, XLSX, ODS, OTS formats  with zoom and other customizations using GroupDocs.Conversion for .NET."
keywords: Convert Excel, Convert to Excel, Convert to spreadsheet, Convert to XLS, Convert to XLSX
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
GroupDocs.Conversion provides [SpreadsheetConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/spreadsheetconvertoptions) to give you control over conversion result when convert to spreadsheet format. Along with [common convert options]({{< ref "conversion/net/developer-guide/advanced-usage/converting/common-conversion-options/_index.md" >}}) from base class [SpreadsheetConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/spreadsheetconvertoptions) has the following additional options:

*   **[Format](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert.convertoptions/1/properties/format)** - desired result document type. Available options are: *Xls, Xlsx, Xlsm, Xlsb, Ods, Ots, Xltx, Xlt, Xltm, Tsc, Xlam, Csv*
*   **[Password](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/spreadsheetconvertoptions/properties/password)** - if set, the converted document will be password protected with the specified password
*   **[Zoom](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/spreadsheetconvertoptions/properties/zoom)** - specifies the zoom level in percentage

Following code snippet shows how to convert to Spreadsheet with advanced options.

```csharp
using (Converter converter = new Converter("sample.docx", getLoadOptions))
{
    SpreadsheetConvertOptions options = new SpreadsheetConvertOptions
    {
        PageNumber = 2,
        PagesCount = 1,
        Format = SpreadsheetFileType.Xls,
        Zoom = 150
    };
    converter.Convert("converted.xls", options);
}
```

## More resources

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