---
id: groupdocs-conversion-for-net-19-5-release-notes
url: conversion/net/groupdocs-conversion-for-net-19-5-release-notes
title: GroupDocs.Conversion for .NET 19.5 Release Notes
weight: 7
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 19.5{{< /alert >}}

## Major Features

This regular monthly release contains 5+ new features, improvements and bug fixes. Most notable are: 

*   Conversions from Dib
*   Conversions from Xlt
*   Conversions from Pot
*   Conversions to Wmf
*   Conversions to Emf
*   Removed obsolete property JpegQuality from ImageSaveOptions
*   Enabled metered licensing

## Full List of Issues Covering all Changes in this Release

| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-3053 | Feature | Enabled metered licensing |
| CONVERSIONNET-3058 | Feature | Implement conversion from Dib |
| CONVERSIONNET-3059 | Feature | Implement conversion from Xlt |
| CONVERSIONNET-3061 | Feature | Implement conversion to Wmf |
| CONVERSIONNET-3062 | Feature | Implement conversion to Emf |
| CONVERSIONNET-3087 | Feature | Implement conversion from Pot |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 19.5. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

1.  **Convert to Emf**
    ```csharp
    ...
    var config = new ConversionConfig();
    var conversionHandler = new ConversionHandler(config);
    const string source = "source.pdf";
    var saveOptions = new ImageSaveOptions {
        ConvertFileType = ImageSaveOptions.ImageFileType.Emf
    };
    var convertedDocument = conversionHandler.Convert(source, saveOptions);
    convertedDocument.Save("result");
    ...
    ```
    
2.  **Convert to Wmf**
    ```csharp
    ...
    var config = new ConversionConfig();
    var conversionHandler = new ConversionHandler(config);
    const string source = "source.pdf";
    var saveOptions = new ImageSaveOptions {
        ConvertFileType = ImageSaveOptions.ImageFileType.Wmf
    };
    var convertedDocument = conversionHandler.Convert(source, saveOptions);
    convertedDocument.Save("result");
    ...
    ```
3.  **Property JpegQuality from ImageSaveOptions class is removed**  
    Replaced by ImageSaveOptions.JpegOptions.Quality property
4.  **Set Metered license**  
    Alternatively to license from file, you may set Metered license
    ```csharp
    string PublicKey = ""; // Your public license key
    string PrivateKey = ""; // Your private license key
    Metered metered = new Metered();
    metered.SetMeteredKey(PublicKey, PrivateKey);
    ```
