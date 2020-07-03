---
id: groupdocs-conversion-for-net-3-5-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-3-5-0-release-notes
title: GroupDocs.Conversion For .NET 3.5.0 Release Notes
weight: 4
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 3.5.0{{< /alert >}}

## Major Features

There are general improvements and performance improvements in this version (almost all conversions are faster from 0.1 to 20 times). 3 bugs are fixed.

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-1078 | % symbol in the file name trowns an exception | Bug |
| CONVERSIONNET-1206 | Exception in HTML to Excel Conversion | Bug |
| CONVERSIONNET-1207 | Convert Excel from Html - Table with background colour and some html controls are not converted properly | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 3.5.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

##### Namespace changes

 Previous: ***GroupDocs.Conversion.Exception***

 Become: ***GroupDocs.Conversion.Exceptions***

**Note:** The change is need to avoid interference with System.Exception type
