---
id: load-personal-storage-pst-or-ost-with-options
url: conversion/net/load-personal-storage-pst-or-ost-with-options
title: Load personal storage PST or OST with options
weight: 7
description: "Learn this article and check how to load and convert PDF documents with advanced options using GroupDocs.Conversion for .NET API."
keywords: Load PST, Load OST, Convert PST content, Convert OST content
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
GroupDocs.Conversion provides [PersonalStorageLoadOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/personalstorageloadoptions) to give you control over how source personal storage (PST/OST) document will be processed. The following options could be set:

*   **[ConvertOwned](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/personalstorageloadoptions/properties/convertowned)** - controls whether the owned documents in the documents container must be converted
*   **[ConvertOwner](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/personalstorageloadoptions/properties/convertowner)** - controls whether the documents container itself must be converted If this property is true the documents container will be the first converted document  
*   **[Depth](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/personalstorageloadoptions/properties/depth)** - controls how many levels in depth to perform conversion
*   **[Folder](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/personalstorageloadoptions/properties/folder)** -  folder which to be processed Default is Inbox

### Get folders from personal storage

The following code sample shows how to get folders within personal storage document:

```csharp
using (Converter converter = new Converter("sample.pst"))
{
    var documentInfo = converter.GetDocumentInfo();
    var ostInfo = (PersonalStorageDocumentInfo) documentInfo;
    Console.WriteLine(ostInfo.RootFolderName);
    foreach (var folder in ostInfo.Folders)
    {
        Console.WriteLine(folder);
    }
}
```

{{< alert style="warning" >}}This functionality is introduced in v20.6{{< /alert >}}

### Convert each personal storage content to different formats

The following code sample shows how to convert each personal storage content to different format based on the content type.  

*   JPG attachments will be converted to PNG
*   DOCX attachments will be converted to PDF
*   Emails and all other types will be converted to HTML


```csharp
using (Converter converter = new Converter("sample.pst", (FileType fileType) =>
{
    if (fileType == PersonalStorageFileType.Ost)
    {
        return new PersonalStorageLoadOptions
        {
            Folder = "ROOT/Inbox",
        };
    }
    if (fileType == EmailFileType.Msg)
    {
        return new EmailLoadOptions
        {
            ConvertOwner = true,
            ConvertOwned = true,
            Depth = 2
        };
    }
    return null;
}))
{
    int index = 0;
    converter.Convert((FileType fileType) =>
    {
        string fileName = $"converted_{++index}.{fileType.Extension}";
        return new FileStream(fileName, FileMode.Create);
    }, (string sourceFileName, FileType fileType) =>
    {
        if (fileType == ImageFileType.Jpg)
        {
            return new ImageConvertOptions
            {
                Format = ImageFileType.Png
            };
        }
        if (fileType == WordProcessingFileType.Docx)
        {
            return new PdfConvertOptions();
        }
        return new MarkupConvertOptions();
    });
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