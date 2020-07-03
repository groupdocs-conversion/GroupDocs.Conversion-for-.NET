---
id: load-document-from-azure-blob-storage
url: conversion/net/load-document-from-azure-blob-storage
title: Load document from Azure Blob Storage
weight: 2
description: "This article demonstrates how to convert document stored in Azure Blob storage using GroupDocs.Conversion for .NET API."
keywords: Convert document from Azure Blob storage, Convert file
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
Following code snippet shows how to convert a document from Azure Blob Storage:

```csharp
public static void Run()
{
    string blobName = "sample.docx";
    string outputFile = Path.Combine("c:\output", "converted.pdf");
    using (Converter converter = new Converter(() => DownloadFile(blobName)))
    {
        PdfConvertOptions options = new PdfConvertOptions();
        converter.Convert(outputFile, options);
    }
}
        
public static Stream DownloadFile(string blobName)
{
    CloudBlobContainer container = GetContainer();
    CloudBlob blob = container.GetBlobReference(blobName);
    MemoryStream memoryStream = new MemoryStream();
    blob.DownloadToStream(memoryStream);
    memoryStream.Position = 0;
    return memoryStream;
}
private static CloudBlobContainer GetContainer()
{
    string accountName = "***";
    string accountKey = "***";
    string endpoint = $"https://{accountName}.blob.core.windows.net/";
    string containerName = "***";
    StorageCredentials storageCredentials = new StorageCredentials(accountName, accountKey);
    CloudStorageAccount cloudStorageAccount = new CloudStorageAccount(
        storageCredentials, new Uri(endpoint), null, null, null);
    CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
    CloudBlobContainer container = cloudBlobClient.GetContainerReference(containerName);
    container.CreateIfNotExists();
    return container;
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
