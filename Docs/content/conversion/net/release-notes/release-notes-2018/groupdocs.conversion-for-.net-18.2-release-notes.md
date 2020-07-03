---
id: groupdocs-conversion-for-net-18-2-release-notes
url: conversion/net/groupdocs-conversion-for-net-18-2-release-notes
title: GroupDocs.Conversion for .NET 18.2 Release Notes
weight: 10
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 18.2{{< /alert >}}

## Major Features

There are 4 new features, improvements and fixes in this regular monthly release. The most notable are:

*   Conversion from PostScript
*   Option to convert specific range when converting from cells
*   Option for skipping blank rows and columns when converting from cells
*   Bug fixes
    

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-2322 | Convert specific range when converting cells document | New Feature |
| CONVERSIONNET-2344 | Implement conversion from PostScript | New Feature |
| CONVERSIONNET-2338 | Implement configuration option for selecting if blank rows and columns should be skipped when converting Cells document | Improvement |
| CONVERSIONNET-2324 | Just print area is getting converted, not the entire spreadsheet | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 18.2. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### Introduced new property ConvertRange

```csharp
/// <summary>
/// Convert specific range when converting to other than cells format. Example: "D1:F8"
/// </summary>
public string ConvertRange { get; set; }
```

### Usage

```csharp
var saveOptions = new PdfSaveOptions();
saveOptions.CellsOptions.ConvertRange = "D1:F8";
```

### Introduced new property SkipEmptyRowsAndColumns

```csharp
/// <summary>
/// Skips empty rows and columns when converting. Default is True.
/// </summary>
public bool SkipEmptyRowsAndColumns { get; set; }
```

### Usage

```csharp
var saveOptions = new PdfSaveOptions();
saveOptions.CellsOptions.SkipEmptyRowsAndColumns= false;
```
