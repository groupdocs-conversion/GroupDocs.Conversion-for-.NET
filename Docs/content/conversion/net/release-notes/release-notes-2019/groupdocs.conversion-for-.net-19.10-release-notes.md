---
id: groupdocs-conversion-for-net-19-10-release-notes
url: conversion/net/groupdocs-conversion-for-net-19-10-release-notes
title: GroupDocs.Conversion for .NET 19.10 Release Notes
weight: 4
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 19.10{{< /alert >}}

## Major Features

There are 5 features, improvements and bug-fixes in this release, most notable are:

*   Introduced support of .Net Standard 2.0. It has full functionality of .NET Framework version of GroupDocs.Conversion.
*   Added an option to set timezone offset when converting from email.
*   Converting from spreadsheet to html now respects specified range for conversion.
*   Improved conversion of multi-page TIFF to PDF

## Full List of Issues Covering all Changes in this Release

| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-3323 | Feature | Keep the timezone of the SENT field |
| CONVERSIONNET-3330 | Feature | Add .NET Standard 2.0 support |
| CONVERSIONNET-3416 | Improvement | Converting multi-page TIFF to PDF |
| CONVERSIONNET-3356 | Bug | Converting spreadsheet to html, ranges are not respected |
| CONVERSIONNET-3376 | Bug | Exception stream is not expandable when converting to html |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 19.10. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

1.  **GroupDocs.Conversion.Options.Load.EmailLoadOptions**  
    Introduced new property TimeZoneOffset
    
    ```csharp
    /// <summary>
    /// Gets or sets the Coordinated Universal Time (UTC) offset for the message dates. This property defines the time zone difference, between the local time and UTC.
    /// </summary>
    public TimeSpan TimeZoneOffset { get; set; }
    ```
    
    Usage
    ```csharp
    var loadOptions = new EmailLoadOptions();
    loadOptions.TimeZoneOffset = TimeSpan.FromHours(5);
    ```
