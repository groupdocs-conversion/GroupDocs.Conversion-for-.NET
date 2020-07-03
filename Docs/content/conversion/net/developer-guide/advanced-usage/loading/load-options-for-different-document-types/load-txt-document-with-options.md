---
id: load-txt-document-with-options
url: conversion/net/load-txt-document-with-options
title: Load TXT document with options
weight: 10
description: "Learn this article and check how to load and convert text files with advanced options using GroupDocs.Conversion for .NET API."
keywords: Load and convert text file, Load and convert TXT
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
[**GroupDocs.Conversion**](https://products.groupdocs.com/conversion/net) provides [TxtLoadOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/txtloadoptions) to give you control over how source text document will be processed. The following options could be set: 

*   **[DetectNumberingWithWhitespaces](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/txtloadoptions/properties/detectnumberingwithwhitespaces)** - allows to specify how numbered list items are recognized when plain text document is converted. If this option is set to false, lists recognition algorithm detects list paragraphs, when list numbers ends with either dot, right bracket or bullet symbols (such as "•", "\*", "-" or "o"). If this option is set to true, white spaces are also used as list number delimiters: list recognition algorithm for Arabic style numbering (1., 1.1.2.) uses both white spaces and dot (".") symbols
*   **[LeadingSpacesOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/txtloadoptions/properties/leadingspacesoptions)** - specifies how leading spaces will be processed. The available options are: *ConvertToIdent, Preserve, Trim*
*   **[TrailingSpacesOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/txtloadoptions/properties/trailingspacesoptions)** - specifies how trailing spaces will be processed. The available options are: *Preserve, Trim*
*   **[Encoding](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/txtloadoptions/properties/encoding)** - specifies encoding to be used to load the document

### Control behavior of processing leading spaces

The following code sample shows how to convert txt document and control the way the leading spaces are processed:

```csharp
Contracts.Func<LoadOptions> getLoadOptions = () => new TxtLoadOptions
{
    LeadingSpacesOptions = TxtLeadingSpacesOptions.ConvertToIndent,
    DetectNumberingWithWhitespaces = true
};
using (Converter converter = new Converter("sample.txt", getLoadOptions))
{
    PdfConvertOptions options = new PdfConvertOptions();
    converter.Convert("converted.pdf", options);
}
```

### Control behavior of processing trailing spaces

The following code sample shows how to convert txt document and the way the trailing spaces are processed:

```csharp
Contracts.Func<LoadOptions> getLoadOptions = () => new TxtLoadOptions
{
    TrailingSpacesOptions = TxtTrailingSpacesOptions.Trim
};
using (Converter converter = new Converter("sample.txt", getLoadOptions))
{
    PdfConvertOptions options = new PdfConvertOptions();
    converter.Convert("converted.pdf", options);
}
```

### Specify encoding

The following code sample shows how to convert txt document and specify the encoding

```csharp
Contracts.Func<LoadOptions> getLoadOptions = () => new TxtLoadOptions
{
    Encoding = Encoding.GetEncoding("shift_jis")
};
using (Converter converter = new Converter("sample.txt", getLoadOptions))
{
    PdfConvertOptions options = new PdfConvertOptions();
    converter.Convert("converted.pdf", options);
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
