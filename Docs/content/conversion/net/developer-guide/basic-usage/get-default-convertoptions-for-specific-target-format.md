---
id: get-default-convertoptions-for-specific-target-format
url: conversion/net/get-default-convertoptions-for-specific-target-format
title: Get default ConvertOptions for specific target format
weight: 4
description: "Learn this article and check how to obtain default convert options for specific conversion format with GroupDocs.Conversion for .NET API. "
keywords: Convert settings, Convert options, Convert with GroupDocs.Conversion
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
[**GroupDocs.Conversion**](https://products.groupdocs.com/conversion/net) allows to get default convert options for specific target format by following the below steps:

*   Create new instance of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class by passing source document path as constructor's parameter
*   Call [GetPossibleConversions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter/methods/getpossibleconversions) method of converter object
*   Use the file extension or FileType as key to indexer of object received as value in previous step  

The following code sample demonstrates how to get possible conversions of the source document:

```csharp
using (var converter = new Converter("source.docx"))
{
    var possibleConversions = converter.GetPossibleConversions();
    var targetConversion = possibleConversions["pdf"];
    var convertOptions = targetConversion?.ConvertOptions;
    if (convertOptions != null)
    {
        converter.Convert("converted.pdf", convertOptions);
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