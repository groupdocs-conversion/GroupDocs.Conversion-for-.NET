---
id: convert-to-html-with-advanced-options
url: conversion/net/convert-to-html-with-advanced-options
title: Convert to HTML with advanced options
weight: 3
description: "Follow this guide and learn how to convert documents to HTML format with fixed layout, zoom and other customizations using GroupDocs.Conversion for .NET."
keywords: Convert to HTML, Convert HTML
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
GroupDocs.Conversion provides [MarkupConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/markupconvertoptions) to give you control over conversion result. The following options could be set:

*   [FixedLayout](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/markupconvertoptions/properties/fixedlayout) - controls the html generation. If it's set to *true*, fixed layout will be used e.g. absolutely positioned html element
*   [Zoom](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/markupconvertoptions/properties/zoom) - specifies the zoom level in percentage. Default is 100  
*   [UsePdf](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/markupconvertoptions/properties/usepdf) - in some cases, for better rendering and elements positioning the source document should be converted to PDF first. If this property is set to *true*, the input firstly is converted to PDF and after that to desired format

Following code snippet shows how to convert to HTML with advanced options

```csharp
using (Converter converter = new Converter("sample.docx"))
{
    MarkupConvertOptions options = new MarkupConvertOptions
    {
        PageNumber = 2,
        PagesCount = 1,
        FixedLayout = true
    };
    converter.Convert("converted.html", options);
}
```

### Control page borders visibility

The following code sample shows how to convert to Html and control page borders visibility

```csharp
var source = "sample.docx";
using (var converter = new Converter(source))
{
    var options = new MarkupConvertOptions
    {
        FixedLayoutShowBorders = false
    };
    converter.Convert("converted.html" , options);
}
```

{{< alert style="warning" >}}This functionality is introduced in v20.3{{< /alert >}}

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
