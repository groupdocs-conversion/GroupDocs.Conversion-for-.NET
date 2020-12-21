---
id: groupdocs-conversion-for-net-20-6-release-notes
url: conversion/net/groupdocs-conversion-for-net-20-6-release-notes
title: GroupDocs.Conversion for .NET 20.6 Release Notes
weight: 7
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 20.6{{< /alert >}}

## Major Features

There are 20+ features, improvements and bug-fixes in this release, most notable are:

*   Conversions from/to Md (markdown)
*   Conversions from/to Fodp
*   XML can be used as data source for conversion
*   Improved pst/ost documents info

## Full List of Issues Covering all Changes in this Release

| Key |  Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-3848 | Feature | Implement conversion from/to Fodp |
| CONVERSIONNET-3901 | Feature | Implement conversion from Md |
| CONVERSIONNET-3903 | Feature | Implement conversion to Md |
| CONVERSIONNET-3913 | Feature | Convert XML files as data source |
| CONVERSIONNET-3888 | Improvement | Improved document info for pst/ost documents |
| CONVERSIONNET-3680 | Bug | Exception while Converting TXT to CSV using GroupDocs.Conversion .NET API v20.1.0 |
| CONVERSIONNET-3694 | Bug | Exception while Converting PDF to XLSM using GroupDocs.Conversion .NET API v20.1.0 |
| CONVERSIONNET-3730 | Bug | Exception while Converting VSDX to XLSX using GroupDocs.Conversion .NET API v20.1 |
| CONVERSIONNET-3785 | Bug | Cc filed missing in EmailField  |
| CONVERSIONNET-3795 | Bug | PDF to XLSM Conversion issue |
| CONVERSIONNET-3818 | Bug | DOC to XLS conversion issue for a particular file |
| CONVERSIONNET-3820 | Bug | Can't convert docx to xls |
| CONVERSIONNET-3833 | Bug | VTX to JPG conversion issue |
| CONVERSIONNET-3850 | Bug | Xlsx to xlsm conversion issue  |
| CONVERSIONNET-3852 | Bug | Docx to csv conversion issue - cannot conver the file is corrupt or damaged |
| CONVERSIONNET-3876 | Bug | Exception if provided folder not exist in ost/pst documents |
| CONVERSIONNET-3878 | Bug | VTX to PNG conversion issue  |
| CONVERSIONNET-3879 | Bug | Cannot convert a particular eml file to xls |
| CONVERSIONNET-3884 | Bug | Implement conversion from CFF2 |
| CONVERSIONNET-3885 | Bug | PDF to TSV conversion issue |
| CONVERSIONNET-3890 | Bug | DOCX/DOC to XLS conversion issue |
| CONVERSIONNET-3894 | Bug | TXT to CSV/XLSX conversion issue |
| CONVERSIONNET-3926 | Bug | HTML to XLS conversion issue |
| CONVERSIONNET-3928 | Bug | Doc to Xlsx conversion issue |
| CONVERSIONNET-3938 | Bug | Wrong Height and Width are returning from GetDocumentInfo method  |

## Public API and Backward Incompatible Changes

1.  **Introduced new class GroupDocs.Conversion.Contracts.PersonalStorageDocumentInfo**
    
    ```csharp
    /// <summary>
    /// Contains personal storage document metadata
    /// </summary>
    public class PersonalStorageDocumentInfo : DocumentInfo
    {
        /// <summary>
        /// Is storage password protected
        /// </summary>
        public bool IsPasswordProtected { get; }
        /// <summary>
        /// Root folder name
        /// </summary>
        public string RootFolderName { get; }
        /// <summary>
        /// Get count of contents in the root folder
        /// </summary>
        public int ContentCount { get; }
        /// <summary>
        /// Folders in the storage
        /// </summary>
        public IList<string> Folders { get; }
    } 
    ```
    
    Usage
    
    ```csharp
    const string source = "ContactsExport.pst";
    using(var converter = new Converter(source))
    {
        var documentInfo = converter.GetDocumentInfo();
        var pstInfo = (PersonalStorageDocumentInfo) documentInfo;
        foreach (var folder in pstInfo.Folders)
        {
            Console.WriteLine(folder);
        }
    }
    
    ```
    
2.  **Introduced new property in class XmlLoadOptions**
    
    ```csharp
    /// <summary>
    /// Use Xml document as data source
    /// </summary>
    public bool UseAsDataSource { get; set; }
     
    ```
    
    Usage
    
    ```csharp
    var source = "sample.xml";
    using (var converter = new Converter(source, () => new XmlLoadOptions { UseAsDataSource = true; }))
    {
        var options = new SpreadsheetConvertOptions();
        converter.Convert("converted.xlsx" , options);
    }
    ```
