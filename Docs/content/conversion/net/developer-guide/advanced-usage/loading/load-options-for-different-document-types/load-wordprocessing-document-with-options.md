---
id: load-wordprocessing-document-with-options
url: conversion/net/load-wordprocessing-document-with-options
title: Load WordProcessing document with options
weight: 11
description: "Learn this article and check how to convert Microsoft Word DOC/DOCX and Open Document ODT/OTT files hiding comments and tracked changes panel, setting default font and applying font substitution using features of GroupDocs.Conversion for .NET API."
keywords: Convert Word document in C#, Convert DOC in C#, Convert DOCX C#, Convert ODT file C#, Convert OTT file C#
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
[**GroupDocs.Conversion**](https://products.groupdocs.com/conversion/net) provides [WordProcessingLoadOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/wordprocessingloadoptions) to give you control over how original Microsoft Word document will be converted. The following options could be set: 

*   **[Format](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/wordprocessingloadoptions/properties/format)** - the document type is auto detected during load, however you can specify explicitly the type of the source WordProcessing document. Available options are: *Doc, Docm, Docx, Dot, Dotm, Dotx, Rtf, Odt, Ott, Mobi, Txt*
*   **[AutoFontSubstitution](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/wordprocessingloadoptions/properties/autofontsubstitution)** - if false, GroupDocs.Conversion uses the DefaultFont for the substitution of missing fonts. If true, GroupDocs.Conversion evaluates all the related fields in FontInfo (Panose, Sig etc) for the missing font and finds the closest match among the available font sources  
    Note: that font substitution mechanism will override the DefaultFont in cases when FontInfo for the missing font is available in the document
*   **[DefaultFont](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/wordprocessingloadoptions/properties/defaultfont)** - default font. The following font will be used if a document font is missing
*   **[FontSubstitutes](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/wordprocessingloadoptions/properties/fontsubstitutes)** - substitute specific fonts from the source document
*   **[Password](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/wordprocessingloadoptions/properties/password)** -  password to unlock protected document
*   **[HideWordTrackedChanges](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/wordprocessingloadoptions/properties/hidewordtrackedchanges)** - specifies that tracked changes should not included in converted document
*   **[HideComments](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/wordprocessingloadoptions/properties/hidecomments)** - specifies that comments from source document must be hidden during conversion

## Hide comments

Microsoft Word provides a Comment feature that allows multiple authors or reviewers to discuss a document when they are not working at it simultaneously. All added comments are displayed in an area from the right of document text. After DOCX document with comments is converted to another format Comments pane is also present in a resultant document. If it's required to hide comments in a converted document programmatically you can use the following code sample that shows how to do this in a couple lines of C# code:

```csharp
Contracts.Func<LoadOptions> getLoadOptions = () => new WordProcessingLoadOptions
{
    HideComments = true
};
using (Converter converter = new Converter("sample.docx", getLoadOptions))
{
    PdfConvertOptions options = new PdfConvertOptions();
    converter.Convert("converted.pdf", options);
}
```

## Hide tracked changes

Track Changes is another feature of Microsoft Word that provides a handy way to collaborate during document proofread and review - it's like you're marking errors with a pen and making some notes in the margins. All changes made by coworkers are highlighted and may be rejected or accepted and become permanent. By default Track Changes panel will also be displayed when converting a DOCX document to another format, however there is an option to hide it completely using GroupDocs.Conversion for .NET API. 

The following code sample shows how to convert DOCX document to PDF and hide tracked changes pane:

```csharp
Contracts.Func<LoadOptions> getLoadOptions = () => new WordProcessingLoadOptions
{
    HideWordTrackedChanges = true
};
using (Converter converter = new Converter("sample.docx", getLoadOptions))
{
    PdfConvertOptions options = new PdfConvertOptions();
    converter.Convert("converted.pdf", options);
}
```

## Specify font substitution

Microsoft Word document content is often formatted with different fonts like Arial, Calibri, Times New Roman etc., and these fonts are usually stored at the computer where the document is originally created or edited. Sometimes it happens that during DOCX document conversion to another format some fonts used by a particular document are not present at the computer where conversion is performed. So the resulting converted document may look too different from the original file.

Of course GroupDocs.Conversion for .NET will try to select the most appropriate font substitution from available font sources and fonts embedded in the original document, but it also has an ability to specify font substitution explicitly. For doing this it is just needed to call the [Create](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.contracts/fontsubstitute/methods/create) method of [FontSubstitute](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.contracts/fontsubstitute) class and provide names for original and substitute fonts.

The following code sample shows how to convert DOCX document with font substitution for missing fonts:

```csharp
Contracts.Func<LoadOptions> getLoadOptions = () => new WordProcessingLoadOptions
{
    AutoFontSubstitution = false,
	DefaultFont = "Helvetica",
    FontSubstitutes = new List<FontSubstitute>
    {
        FontSubstitute.Create("Tahoma", "Arial"),
        FontSubstitute.Create("Times New Roman", "Arial"),
    }
};
using (Converter converter = new Converter("sample.docx", getLoadOptions))
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