---
id: get-default-convert-options-for-target-format
url: conversion/net/get-default-convert-options-for-target-format
title: Get default convert options for a target format
weight: 1
description: "Following this article you will learn how to get predefined default convert options for desired target format with GroupDocs.Conversion for .NET API."
keywords: Get default convert options, Convert options
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
**[GroupDocs.Conversion](https://products.groupdocs.com/conversion/net)** allows you to get default predefined convert options for a desired target document format. This will allow you to get predefined convert options runtime, knowing the desired target format.

Here are the steps to follow:

*   Create new instance of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class and pass source document path as a constructor parameter
*   Invoke converter [GetPossibleConversions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion/converter/methods/getpossibleconversions) method
*   Use [file type](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.contracts/possibleconversions/properties/item) or [file extension](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.contracts.possibleconversions/item/properties/1) indexer of the received possible conversion and read the [ConvertOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.contracts/targetconversion/properties/convertoptions) property.
*   Call [Convert](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter/methods/convert/2) method of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class instance and pass filename for the converted document and the instance of [ConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/convertoptions) from the previous step

Following code snippet shows how to get predefined convert options for a desired target format:

```csharp
using (Converter converter = new Converter("sample.docx"))
{
    var possibleConversion = converter.GetPossibleConversions();
    var convertOptions = possibleConversion["pdf"].ConvertOptions;
    converter.Convert(outputFile, convertOptions);
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
