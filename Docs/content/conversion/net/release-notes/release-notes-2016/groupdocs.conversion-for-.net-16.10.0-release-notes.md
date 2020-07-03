---
id: groupdocs-conversion-for-net-16-10-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-16-10-0-release-notes
title: GroupDocs.Conversion For .NET 16.10.0 Release Notes
weight: 3
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 16.10{{< /alert >}}

## Major Features

There are 5 improvements and fixes in this regular monthly release. The most notable are:

*   Converting from CAD documents to Cells, Html, Image, Pdf, Slides and Words
*   Setting default fonts to be used when converting from Slides if used font do not exist in the system
*   FixedLayout option when converting Word and Pdf to Html

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1318 | Convert from CAD documents to Cells, Html, Image, Pdf, Slides, Words | New Feature |
| CONVERSIONNET-1077 | Setting default Fonts | New Feature |
| CONVERSIONNET-1305 | Add FixedLayout option to Words to Html conversions | New Feature |
| CONVERSIONNET-1304 | Add FixedLayout option to Pdf to Html conversions | New Feature |
| CONVERSIONNET-1351 | Coversion with document as Stream input not working | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 16.10.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

##### Introduced SlidesLoadOptions with ability to specify default font for rendering if a presentation font is missing.



```csharp
 var loadOptions = new SlidesLoadOptions
{
	Password = "secret",
	DefaultFont = "Verdana"  // Default font for rendering the presentation. The following font will be used if a presentation font is missing.
};


```

##### HtmlSaveOptions class is extended with new property - FixedLayout - if true html will be rendered with absolutely positioned elements



```csharp
 var saveOptions = new HtmlSaveOptions
{

	FixedLayout = true

};


```
