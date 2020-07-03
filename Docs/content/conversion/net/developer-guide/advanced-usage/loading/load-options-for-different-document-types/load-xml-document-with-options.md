---
id: load-xml-document-with-options
url: conversion/net/load-xml-document-with-options
title: Load XML document with options
weight: 12
description: "Learn this article and check how to load and convert XML documents with advanced options using GroupDocs.Conversion for .NET API."
keywords: XML to Excel, XML to spreadsheet, XML as data source to XLSX
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
GroupDocs.Conversion provides [XmlLoadOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/xmlloadoptions) to give you control over how source xml document will be processed. The following options could be set: 

*   **[Format](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/xmlloadoptions/properties/format)** - input document file type
*   **[UseAsDataSource](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/xmlloadoptions/properties/useasdatasource)** - use source XML document as data source
*   **[XslFoFactory](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/xmlloadoptions/properties/xslfofactory)** - XSL document stream to convert XML-FO using XSL.

### Convert XML as data source to spreadsheet

The following code sample shows how to use XML as data source and convert it to spreadsheet:

```csharp
using (Converter converter = new Converter("data.xml", () => new XmlLoadOptions
{
    UseAsDataSource = true
}))
{
    SpreadsheetConvertOptions options = new SpreadsheetConvertOptions();
    converter.Convert("converted.xlsx", options);
}
```

{{< alert style="warning" >}}This functionality is introduced in v20.6{{< /alert >}}

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