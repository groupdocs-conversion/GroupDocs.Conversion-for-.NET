---
id: groupdocs-conversion-for-net-20-7-release-notes
url: conversion/net/groupdocs-conversion-for-net-20-7-release-notes
title: GroupDocs.Conversion for .NET 20.7 Release Notes
weight: 6
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 20.7{{< /alert >}}

## Major Features

There are 15+ features, improvements and bug-fixes in this release, most notable are:

*   Conversions to Dif
*   Conversions from/to SXC
*   Conversions from AI
*   Conversions from/to Emz
*   Conversions from/to Wmz
*   Conversions from/to Svgz

## Full List of Issues Covering all Changes in this Release


| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-3968    |	Feature |	Implement conversion to Dif |
| CONVERSIONNET-3970    |	Feature |	Implement conversion from SXC |
| CONVERSIONNET-3971    |	Feature |	Implement conversion to SXC |
| CONVERSIONNET-4039    |	Feature |	Implement conversion from AI |
| CONVERSIONNET-4042    |	Feature |	Implement conversion from/to Emz |
| CONVERSIONNET-4043    |	Feature |	Implement conversion from/to Wmz |
| CONVERSIONNET-4044    |	Feature |	Implement conversion from/to Svgz |
| CONVERSIONNET-4006    |	Improvement |	Change watermark font property from System.Drawing.Font to own class |
| CONVERSIONNET-3707    |	Bug |	Exception while Converting WMF to DOC using GroupDocs.Conversion .NET API v20.1.0 As Image export failed |
| CONVERSIONNET-3809    |	Bug |	PDF to ODS conversion issue |
| CONVERSIONNET-3851    |	Bug |	PDF to HTML conversion issue, additional space in a word |
| CONVERSIONNET-3891    |	Bug |	DOCX to PDF conversion issue for a particular file |
| CONVERSIONNET-3893    |	Bug |	VSDX to PNG Conversion issue |
| CONVERSIONNET-3911    |	Bug |	PDF to CSV conversion issue |
| CONVERSIONNET-3962    |	Bug |	PPT/PPTX to XLS conversion issue |
| CONVERSIONNET-3997    |	Bug |	Conversion is stuck |
| CONVERSIONNET-3998    |	Bug |	XLSM to PDF - Index was outside the bounds of the array |
| CONVERSIONNET-4022    |	Bug |	Bad image quality for low resolution PNG |
| CONVERSIONNET-4056    |	Bug |	HTML to PDF conversion, characters issue |


## Public API and Backward Incompatible Changes

1.  **Introduced new property in class WatermarkOptions**
    
    ```csharp
    /// <summary>
    /// Watermark font if text watermark is applied
    /// </summary>
    public Font WatermarkFont { get; set; }
    ```
    
2.  **Following properties are marked as obsolete**
    
    * **GroupDocs.Conversion.Options.Convert.WatermarkOptions** property **Font**  - will be removed in v20.10. Property **WatermarkFont** must be used instead.
    
3.  **Following properties are removed**
    
    * From **GroupDocs.Conversion.ConverterSettings** property **DefaultFont**
    * From **GroupDocs.Conversion.Options.Convert.PdfOptions** property **FormatingOptions**
    * From **GroupDocs.Conversion.Options.Load.EmailLoadOptions** property **ConvertAttachments**
