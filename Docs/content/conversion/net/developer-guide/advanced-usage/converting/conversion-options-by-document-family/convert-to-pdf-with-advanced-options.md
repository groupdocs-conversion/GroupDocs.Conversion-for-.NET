---
id: convert-to-pdf-with-advanced-options
url: conversion/net/convert-to-pdf-with-advanced-options
title: Convert to PDF with advanced options
weight: 5
description: "Follow this guide and learn how to convert documents to PDF with height, width, DPI, margins and other customizations using GroupDocs.Conversion for .NET."
keywords: Convert PDF, Convert to PDF/A
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
GroupDocs.Conversion provides [PdfConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions) to give you control over conversion result when convert to PDF. Along with [common convert options]({{< ref "conversion/net/developer-guide/advanced-usage/converting/common-conversion-options/_index.md" >}}) [PdfConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions) has the following additional options:

*   [Format](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert.convertoptions/1/properties/format) - desired result document type. Available options are: *Pdf, Epub, Xps, Tex, Ps, Pcl*
*   [Width](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions/properties/width) - desired image width after conversion
*   [Height](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions/properties/height) - desired image height after conversion
*   [Dpi](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions/properties/dpi) - desired page DPI after conversion
*   [Password](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions/properties/password) - if set the converted document will be protected with specified password
*   [MarginTop](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions/properties/margintop) - desired page top margin after conversion
*   [MarginBottom](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions/properties/marginbottom) - desired page bottom margin after conversion
*   [MarginLeft](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions/properties/marginleft) - desired page left margin after conversion
*   [MarginRight](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions/properties/marginright) - desired page right margin after conversion
*   [PdfOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.convert/pdfoptions) - PDF specific convert options
*   [Rotate](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfconvertoptions/properties/rotate) - page rotation. Available options are: *None, On90, On180, On270*

Following code snippet shows how to convert to PDF with advanced options.

```csharp
using (Converter converter = new Converter("sample.docx"))
{
    PdfConvertOptions options = new PdfConvertOptions
    {
        PageNumber = 2,
        PagesCount = 1,
        Rotate = Rotation.On180,
        Dpi = 300,
        Width = 1024,
        Height = 768
    };
    converter.Convert("converted.pdf", options);
}
```

### PdfOptions

[PdfOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptions) class provides specific options when converting document to different versions of PDF format.

*   [PdfFormat](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptions/properties/pdfformat) - sets pdf format of the converted document. Available options are: *Default, PdfA\_1A, PdfA\_1B, PdfA\_2A, PdfA\_3A, PdfA2B, PdfA\_2U, PdfA\_3B, PdfA\_3U, v1\_3, v1\_4, v1\_5, v1\_6, v1\_7, PdfX\_1A, PdfX\_3*
*   [RemovePdfACompliance](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptions/properties/removepdfacompliance) - removes Pdf-A compliance
*   [Zoom](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptions/properties/zoom) - specifies the zoom level in percentage
*   [Linearize](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptions/properties/linearize) - linearizes PDF document for web
*   [Grayscale](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptions/properties/grayscale) - convert to grayscale PDF
*   [OptimizationOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.convert/pdfoptions/properties/optimizationoptions) - PDF optimization options
*   [FormattingOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.convert/pdfoptions/properties/formattingoptions) - PDF formatting options

### PdfOptimizationOptions

[PdfOptimizationOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptimizationoptions) class allows to specify options for adjusting PDF conversion process and improve its speed.

*   [LinkDuplicateStreams](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptimizationoptions/properties/linkduplicatestreams) - link duplicate streams
*   [RemoveUnusedObjects](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptimizationoptions/properties/removeunusedobjects) - remove unused objects
*   [CompressImages](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptimizationoptions/properties/compressimages) - if set to *true*, all images in the document are re-compressed. The amount of compression and image quality are defined by the [ImageQuality](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptimizationoptions/properties/imagequality)
*   [ImageQuality](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptimizationoptions/properties/imagequality) - value in percent where 100% is unchanged quality and image size. To decrease the image size set this property to less than 100
*   [UnembedFonts](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfoptimizationoptions/properties/unembedfonts) - make fonts not embedded

### PdfFormattingOptions

[PdfFormattingOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfformattingoptions) class provides different options to change PDF document look.

*   [CenterWindow](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfformattingoptions/properties/centerwindow) - specifies whether position of the document's window will be centered on the screen
*   [Direction](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfformattingoptions/properties/direction) - sets reading order of text: L2R (left to right) or R2L (right to left). Available options are: *L2R, R2L*
*   [DisplayDocTitle](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfformattingoptions/properties/displaydoctitle) - specifies whether document's window title bar should display document title
*   [FitWindow](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfformattingoptions/properties/fitwindow) - specifies whether document window must be resized to fit the first displayed page
*   [HideMenuBar](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfformattingoptions/properties/hidemenubar) - specifies whether menu bar should be hidden when document is active
*   [HideToolBar](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfformattingoptions/properties/hidetoolbar) - specifies whether toolbar should be hidden when document is active
*   [HideWindowUI](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfformattingoptions/properties/hidewindowui) - specifies whether user interface elements should be hidden when document is active
*   [NonFullScreenPageMode](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfformattingoptions/properties/nonfullscreenpagemode) - specifying how to display the document on exiting full-screen mode. Available options are: *UseNone, UseOutlines, UseThumbs, FullScreen, UseOC, UseAttachments*
*   [PageLayout](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfformattingoptions/properties/pagelayout) - sets page layout which shall be used when the document is opened. Available options are: *Default, SinglePage, OneColumn, TwoColumnLeft, TwoColumnRight, TwoPagesLeft, TwoPagesRight*
*   [PageMode](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/pdfformattingoptions/properties/pagemode) - specifying how document should be displayed when opened. Available options are: *UseNone, UseOutlines, UseThumbs, FullScreen, UseOC, UseAttachments*

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