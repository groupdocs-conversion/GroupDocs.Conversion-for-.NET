---
id: groupdocs-conversion-for-net-18-9-release-notes
url: conversion/net/groupdocs-conversion-for-net-18-9-release-notes
title: GroupDocs.Conversion for .NET 18.9 Release Notes
weight: 3
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 18.9{{< /alert >}}

## Major Features

This regular monthly release contains 10+ new features, improvements and bug fixes. Most notable are:

*   Improved Load and Save Options, moved to new namespace
*   Introduced conversion from IGS
*   Introduced conversion from PLT
*   Convert from password protected ODS
*   Convert to password protected ODS
*   Introduced conversion from CGM

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| 14095 | Implement conversion from Igs | New Feature |
| 14094 | Implement conversion from Plt | New Feature |
| 14073 | Support password protection when converting to ODS | New Feature |
| 14072 | Support converting password protected ODS document | New Feature |
| 14061 | Implement conversion from Cgm | New Feature |
| 14097 | Pdf to Cells improvement | Improvement |
| 14084 | Improve Words conversion options | Improvement |
| 14083 | Improve Slides conversion options | Improvement |
| 14082 | Improve Pdf conversion options | Improvement |
| 14080 | Improve Image conversion options | Improvement |
| 14079 | Improve Html conversion options | Improvement |
| 14078 | Improve Cells conversion options | Improvement |
| 14087 | XLS to HTML output is too small | Bug |
| 14074 | Excel to SVG conversion issue | Bug |
| 13688 | Xps to Pdf conversion issue | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 18.9. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

All classes from GroupDocs.Conversion.Converter.Option namespace are now obsolete

This is not breaking change, but the classes are marked as obsolete and will be removed in version 18.12. The new options classes are in GroupDocs.Conversion.Options namespace and are separated in two sub namespaces GroupDocs.Conversion.Options.Load and GroupDocs.Conversion.Options.Save
