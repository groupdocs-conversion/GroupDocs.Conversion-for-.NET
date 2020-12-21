---
id: groupdocs-conversion-for-net-20-9-release-notes
url: conversion/net/groupdocs-conversion-for-net-20-9-release-notes
title: GroupDocs.Conversion for .NET 20.9 Release Notes
weight: 4
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 20.9{{< /alert >}}

## Major Features

There are 5+ improvements and bug-fixes in this release, most notable are:

*   Fixed conversions from XLSX to PNG
*   Fixed conversions from DWG to DOCX 
*   Properly detect email type even if file extension is incorrect

## Full List of Issues Covering all Changes in this Release


| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-4146 |	Improvement | Introduce new load option to exclude Excel checks when converting from Spreadsheet document types |
| CONVERSIONNET-3786 |	Bug	        | XLSB to XLSX conversion issue for a particular file |
| CONVERSIONNET-3788 |	Bug	        | WMF to GIF conversion issue |
| CONVERSIONNET-3934 |	Bug	        | XLSX to PNG conversion produces only black image |
| CONVERSIONNET-4143 |	Bug	        | Conversion take to much time |
| CONVERSIONNET-4152 |	Bug	        | DWG to DOCX conversion issue |
| CONVERSIONNET-4161 |	Bug	        | Cannot convert Email document if the file format doesn't match file extension |


## Public API and Backward Incompatible Changes

1.  **Introduced new property in class SpreadsheetLoadOptions**
    
    ```csharp
    /// <summary>
    /// Whether check restriction of excel file when user modify cells related objects.
    /// For example, excel does not allow inputting string value longer than 32K.
    /// When you input a value longer than 32K, if this property is true, you will get an Exception.
    /// If this property is false, we will accept your input string value as the cell's value so that later
    /// you can output the complete string value for other file formats such as CSV.
    /// However, if you have set such kind of value that is invalid for excel file format, you should not save
    /// the workbook as excel file format later. Otherwise there may be unexpected error for the generated excel file.
    /// </summary>
    public bool CheckExcelRestriction { get; set; }  
    ```
