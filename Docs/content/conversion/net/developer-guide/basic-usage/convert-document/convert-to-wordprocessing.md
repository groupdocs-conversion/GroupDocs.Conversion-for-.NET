---
id: convert-to-wordprocessing
url: conversion/net/convert-to-wordprocessing
title: Convert to WordProcessing
weight: 6
description: "Learn this article and check how to convert documents to Word DOCX, DOC, RTF or Open Document ODT, OTT formats with GroupDocs.Conversion for .NET."
keywords: Convert to Word, Convert to DOCX, Convert to DOC
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
[**GroupDocs.Conversion**](https://products.groupdocs.com/conversion/net) can convert any source document to the following WordProcessing formats: *Doc, Docm, Docx, Dot, Dotx, Rtf, Odt, Ott, Mobi, Txt*. When just instantiate the [WordProcessingConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/wordprocessingconvertoptions) class without specifying the target format explicitly, *Docx* will be used as a default format.

Conversion to WordProcessing format could be triggered by following below steps:

*   Create new instance of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class and pass source document path as a constructor parameter
*   Instantiate [WordProcessingConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/wordprocessingconvertoptions) class
*   Call [Convert](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter/methods/convert/2) method of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class instance and pass filename for the converted document and the instance of [WordProcessingConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/wordprocessingconvertoptions) from the previous step

The following code show how to convert any document to WordProcessing document. 

```csharp
using (Converter converter = new Converter("sample.pdf"))
{
    WordProcessingConvertOptions options = new WordProcessingConvertOptions();
    converter.Convert("converted.docx", options);
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