---
id: groupdocs-conversion-for-net-17-10-release-notes
url: conversion/net/groupdocs-conversion-for-net-17-10-release-notes
title: GroupDocs.Conversion for .NET 17.10 Release Notes
weight: 3
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 17.10{{< /alert >}}

## Major Features

There are 10+ new features, improvements and fixes in this regular monthly release. The most notable are:

*   Converting from STL
*   Converting from IFC
*   Improved Cells to XPS conversions
*   Improved Slides to XPS conversions
*   Improved saving on the whole converted document as well as page by page saving functionality
*   Watermark transparency set to 50% transparent by default
*   4 bugs fixed  
      
    

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-2170 | Implement conversion from STL | New Feature |
| CONVERSIONNET-2171 | Implement conversion from IFC | New Feature |
| CONVERSIONNET-2176 | Conversion of document containing images to RTF with "old readers" compatibility | New Feature |
| CONVERSIONNET-2108 | Improve document savers for saving complete document and save by page | Improvement |
| CONVERSIONNET-2130 | Cells To XPS conversion improvement | Improvement |
| CONVERSIONNET-2152 | WatermarkOptions is instantiated default Width and Height of the watermark | Improvement |
| CONVERSIONNET-2153 | Set default transparency of watermark to 0.5 | Improvement |
| CONVERSIONNET-2155 | Slides To XPS conversion improvement | Improvement |
| CONVERSIONNET-2161 | Expose FileType and PagesCount properties in ConvertedDocument class | Improvement |
| CONVERSIONNET-1908 | Incorrect conversion from One to PDF | Bug |
| CONVERSIONNET-2158 | PsdOptions does not have constructor | Bug |
| CONVERSIONNET-2163 | Converting HTML with external resources produce wrong output | Bug |
| CONVERSIONNET-2167 | PDF locked with modification password but without view password cannot be converted | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 17.10. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### Obsoleted Property

```csharp
 public DocumentInfo DocumentInfo { get; }
//The property is obsolete and will be removed after v18.1
```
