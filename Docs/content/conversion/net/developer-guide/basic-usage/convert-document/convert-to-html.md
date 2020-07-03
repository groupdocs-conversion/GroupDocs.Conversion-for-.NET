---
id: convert-to-html
url: conversion/net/convert-to-html
title: Convert to Html
weight: 1
description: "Following this article you will learn how to convert documents to HTML format with couple C# code lines and GroupDocs.Conversion for .NET."
keywords: Convert to HTML, Convert to HTM
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
**[GroupDocs.Conversion](https://products.groupdocs.com/conversion/net)** can convert any source document to a markup format which in general is a HTML conformable format. You can control either to generate fixed positioned DOM elements or flow positioned DOM elements.

Conversion to markup format could be triggered by following below steps:

*   Create new instance of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class and pass source document path as a constructor parameter
*   Instantiate [MarkupConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/markupconvertoptions) class
*   Call [Convert](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter/methods/convert/2) method of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class instance and pass filename for the converted document and the instance of [MarkupConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/markupconvertoptions) from the previous step

The following code show how to convert any document to HTML. 

```csharp
using (Converter converter = new Converter("sample.docx"))
{
    MarkupConvertOptions options = new MarkupConvertOptions();
    converter.Convert("converted.html", options);
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