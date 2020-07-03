---
id: convert-each-email-attachment-to-different-format
url: conversion/net/convert-each-email-attachment-to-different-format
title: Convert each email attachment to different format
weight: 2
description: "Follow this guide and learn how to convert email attachments to different format based on attachment type using GroupDocs.Conversion for .NET."
keywords: Convert email attachments, Convert MSG attachements, Convert EML attachments
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
GroupDocs.Conversion provides flexible API to control conversion of documents that contains other documents. The following code snippet shows how to convert each attachment to different format based on attachment type:

```csharp
var index = 1;
LoadOptions LoadOptionsProvider(FileType sourceType)
{
    if (sourceType == EmailFileType.Eml)
    {
        return new EmailLoadOptions
        {
            ConvertOwned = true, 
            ConvertOwner = true,
            Depth = 2
        };
    }
    return null;
}
Stream ConvertedStreamProvider(FileType targetType)
{
    string outputFile = $"converted-{index++}.{targetType.Extension}";
    return new FileStream(outputFile, FileMode.Create);
}
ConvertOptions ConvertOptionsProvider(string sourceDocumentName, FileType sourceType)
{
    if (sourceType == EmailFileType.Eml)
    {
        return new WordProcessingConvertOptions();
    }
    
    if (sourceType == WordProcessingFileType.Txt)
    {
        return new PdfConvertOptions();
    }
    return new ImageConvertOptions();
}

using (var converter = new Converter("sample_with_attachments.eml", LoadOptionsProvider))
{
    converter.Convert(ConvertedStreamProvider, ConvertOptionsProvider);
}


```

{{< alert style="warning" >}}This functionality is introduced in v20.6{{< /alert >}}

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