---
id: groupdocs-conversion-for-net-19-3-release-notes
url: conversion/net/groupdocs-conversion-for-net-19-3-release-notes
title: GroupDocs.Conversion for .NET 19.3 Release Notes
weight: 9
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 19.3{{< /alert >}}

## Major Features

This regular monthly release contains 10+ improvements and bug fixes. Most notable are: 

*   Conversions from Cdr
*   Adjusting brightness, contrast, gamma when converting to image
*   Flip image option when converting to image
*   Converstions from Excel95/5.0

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-2892 | Implement conversion from Cdr | Feature |
| CONVERSIONNET-2911 | Set color mode when converting to Jpeg | Feature |
| CONVERSIONNET-2912 | Set compression mode when converting to Jpeg | Feature |
| CONVERSIONNET-2925 | Implement option for adjusting brightness when converting to image | Feature |
| CONVERSIONNET-2926 | Implement option for adjusting contrast when converting to image | Feature |
| CONVERSIONNET-2927 | Implement option for adjusting gamma when converting to image | Feature |
| CONVERSIONNET-2928 | Implement option for flip image when converting to image | Feature |
| CONVERSIONNET-2891 | Support conversion from Excel95/5.0 XLS files | Improvement |
| CONVERSIONNET-2913 | Set image quality when converting to WebP | Improvement |
| CONVERSIONNET-2914 | Extend DocumentInfo with new property IsPasswordProtected | Improvement |
| CONVERSIONNET-2965 | Remove HideComments from SaveOptions | Improvement |
| CONVERSIONNET-2966 | Remove HidePdfAnnotations from SaveOptions | Improvement |
| CONVERSIONNET-2967 | Remove HideWordTrackedChanges from SaveOptions | Improvement |
| CONVERSIONNET-2880 | ImageSaveOptions.JpegQuality issue when converting .pdf to .jpeg | Bug |
| CONVERSIONNET-2916 | Multi-line merged cell in excel renders only the first line | Bug |
| CONVERSIONNET-1937 | Arrows point in the wrong direction in ODP output | Bug |

##   
Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 19.3. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### Control brightness, contrast, gamma and flip when convert to image

```csharp
/// <summary>
/// Options for to Image conversion
/// </summary>
public class ImageSaveOptions : SaveOptions
{
    ...
    /// <summary>
    /// Image flip mode
    /// </summary>
    public FlipModes FlipMode { get; set; }
 
    /// <summary>
    /// Adjust image brightness
    /// </summary>
    public int Brightness { get; set; }
     
    /// <summary>
    /// Adjust image contrast
    /// </summary>
    public int Contrast { get; set; }
     
    /// <summary>
    /// Adjust image gamma
    /// </summary>
    public float Gamma { get; set; }
    ...
}
```

Usage

```csharp
...
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
const string source = "source.pdf";
var saveOptions = new ImageSaveOptions {
    FlipMode = FlipModes.FlipX,
    Brightness = 50,
    Contrast = 50,
    Gamma = 0.5
};
var convertedDocument = conversionHandler.Convert(source, saveOptions);
convertedDocument.Save("result");
...
```

### Removed HideComments from SaveOptions

Replaced by HideComments property in CellsLoadOptions, SlidesLoadOptions or WordsLoadOptions classes.

### Removed HidePdfAnnotations from SaveOptions

Replaced by GroupDocs.Conversion.Options.Load.PdfLoadOptions.HidePdfAnnotations property

### Removed HideWordTrackedChanges from SaveOptions

Replaced by GroupDocs.Conversion.Options.Load.WordsLoadOptions.HideWordTrackedChanges property
