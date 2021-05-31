---
id: convert-to-data-with-advanced-options
url: conversion/net/convert-to-data-with-advanced-options
title: Convert to data (xml/json) with advanced options
weight: 9
description: "Follow this guide and learn how to convert documents to data (xml/json) using GroupDocs.Conversion for .NET."
keywords: Convert to JSON, Convert to XML
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
GroupDocs.Conversion provides [DataConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/dataconvertoptions) to give you control over conversion result when convert to data format. Along with [common convert options]({{< ref "conversion/net/developer-guide/advanced-usage/converting/common-conversion-options/_index.md" >}}) [DataConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/dataconvertoptions) has the following additional options:

*   [Format](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert.convertoptions/1/properties/format) - desired result document type. Available options are: *Json, Xml*

Following code snippet shows how to convert to JSON with advanced options.

```csharp
using (Converter converter = new Converter("sample.csv"))
{
    DataConvertOptions options = new DataConvertOptions
    {
        Format = DataFileType.Json
    };
    converter.Convert("converted.json", options);
}
```

{{< alert style="warning" >}}This functionality is introduced in v21.5{{< /alert >}}

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