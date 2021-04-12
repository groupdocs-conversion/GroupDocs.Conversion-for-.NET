---
id: groupdocs-conversion-for-net-21-3-1-release-notes
url: conversion/net/groupdocs-conversion-for-net-21-3-1-release-notes
title: GroupDocs.Conversion for .NET 21.3.1 Release Notes
weight: 9
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 21.3.1{{< /alert >}}

## Major Features

This is a hot fix release which fix one issue:

*   Wordprocessing conversion issue under linux and windows core
 
## Full List of Issues Covering all Changes in this Release


| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-4571 | Bug | Wordprocessing conversion issue under linux and windows core |


## Public API and Backward Incompatible Changes

1.  **Introduced new property in class WordProcessingLoadOptions**
    
    ```csharp
    /// <summary>
    /// Specifies whether to use a text shaper for better kerning display. Default is false.
    /// </summary>
    public bool UseTextShaper { get; set; }
    ```
