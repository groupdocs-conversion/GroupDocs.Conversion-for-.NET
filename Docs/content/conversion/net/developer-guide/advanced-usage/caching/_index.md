---
id: caching
url: conversion/net/caching
title: Caching
weight: 2
description: "Learn this article and check how to improve conversion speed and performance when convert document with GroupDocs.Conversion for .NET API."
keywords: Caching conversion results, Cache conversion, Improve conversion speed
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
In some cases document conversion may be a time-consuming operation (dependent on source document content, structure and complexity). For such situations caching can be a solution - converted document is stored into cache (for example at the local drive) and in a case of repetitive conversions of the document, **[GroupDocs.Conversion](https://products.groupdocs.com/conversion/net)** uses cached representation. 

To enable caching you have to:

*   Instantiate desired cache object (for example [FileCache](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.caching/filecache) will store converted document results at the local drive)
*   Pass [ConverterSettings](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/convertersettings) object factory to constructor of a [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class
*   Call [Convert](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter/methods/convert/2) method of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class

Here is a code that demonstrates how to enable caching for GroupDocs.Conversion.

```csharp
string cachePath = "c:\output\cache";
FileCache cache = new FileCache(cachePath);
Contracts.Func<ConverterSettings> settingsFactory = () => new ConverterSettings
{
    Cache = cache
};
using (Converter converter = new Converter("sample.docx", settingsFactory))
{
    PdfConvertOptions options = new PdfConvertOptions();
    Stopwatch stopWatch = Stopwatch.StartNew();
    converter.Convert("converted.pdf", options);
    stopWatch.Stop();
    Console.WriteLine("Time taken on first call to Convert method {0} (ms).", stopWatch.ElapsedMilliseconds);
    stopWatch.Restart();
    converter.Convert("converted-1.pdf", options);
    stopWatch.Stop();
    Console.WriteLine("Time taken on second call to Convert method {0} (ms).", stopWatch.ElapsedMilliseconds);
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
