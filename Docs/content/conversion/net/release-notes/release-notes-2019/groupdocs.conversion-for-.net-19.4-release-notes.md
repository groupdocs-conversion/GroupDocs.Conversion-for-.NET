---
id: groupdocs-conversion-for-net-19-4-release-notes
url: conversion/net/groupdocs-conversion-for-net-19-4-release-notes
title: GroupDocs.Conversion for .NET 19.4 Release Notes
weight: 8
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 19.4{{< /alert >}}

## Major Features

This regular monthly release contains 5+ improvements and bug fixes. Most notable are: 

*   Conversions from Cmx
*   Automatic naming when saving converted document to file
*   Get page orientation for specific page

## Full List of Issues Covering all Changes in this Release

| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-2980 | Feature | Implement automatic naming when saving converted document to file |
| CONVERSIONNET-2983 | Feature | Implement conversion from Cmx |
| CONVERSIONNET-3011 | Improvement | Implement getting page orientation for specific page |
| CONVERSIONNET-1747 | Bug | HTML output file is not rendered properly in Edge |
| CONVERSIONNET-1919 | Bug | Arrows point in the wrong direction in ODP output |
| CONVERSIONNET-2964 | Bug | AutoCAD(.ifc) to Image conversion issue |
| CONVERSIONNET-2995 | Bug | Evaluation message is not visible when converting to ODS |
| CONVERSIONNET-3002 | Bug | Incorrect Html after applying evaluation message when converting from Email |
| CONVERSIONNET-3003 | Bug | Incorrect Html structure after applying watermark over Html |
| CONVERSIONNET-3048 | Bug | GroupDocs.Conversion with several GroupDocs products in same project throws exception |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 19.4. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

1.  ### CellsLoadOptions is marked as obsolete
    Replaced by SpreadsheetLoadOptions
2.  ### CellsSaveOptions is marked as obsolete
    Replaced by SpreadsheetSaveOptions
3.  ### HtmlSaveOptions is marked as obsolete
    Replaced by MarkupSaveOptions
4.  ### SlidesLoadOptions is marked as obsolete
    Replaced by PresentationLoadOptions
5.  ### SlidesSaveOptions is marked as obsolete
    Replaced by PresentationSaveOptions
6.  ### WordsLoadOptions is marked as obsolete
    Replaced by WordProcessingLoadOptions
7.  ### WordsSaveOptions is marked as obsolete
    Replaced by WordProcessingSaveOptions
