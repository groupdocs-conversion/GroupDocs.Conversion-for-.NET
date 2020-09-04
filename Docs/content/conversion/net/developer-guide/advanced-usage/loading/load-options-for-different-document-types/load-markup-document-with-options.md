---
id: load-markup-document-with-options
url: conversion/net/load-markup-document-with-options
title: Load Markup document with options
weight: 4
description: "Learn this article and check how to load and convert HTML documents with advanced options using GroupDocs.Conversion for .NET API."
keywords: Load document, Load HTML document
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
GroupDocs.Conversion provides [MarkupLoadOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/markuploadoptions) to give you control over how source Note document will be processed. The following options could be set:
*   **[PageNumbering](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/markuploadoptions/properties/pagenumbering)** - enable or disable generation of page numbering in converted document. Default: false  

## Enable page numbering when converting to Wordprocessing

The following code sample shows how to convert Note document and specify font substitution for missing fonts:

```csharp
var source = "sample.html";
var loadOptions = new MarkupLoadOptions
{
    PageNumbering = true
};
using (var converter = new Converter(source, () => loadOptions))
{
    var options = new WordProcessingConvertOptions();
    converter.Convert("converted.docx" , options);
}
```

{{< alert style="warning" >}}This functionality is introduced in v20.3{{< /alert >}}
