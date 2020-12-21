---
id: groupdocs-conversion-for-net-20-3-release-notes
url: conversion/net/groupdocs-conversion-for-net-20-3-release-notes
title: GroupDocs.Conversion for .NET 20.3 Release Notes
weight: 9
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 20.3{{< /alert >}}

## Major Features

There are 20+ features, improvements and bug-fixes in this release, most notable are:

*   Introduced possibility to hide border while converting Wordprocessing to HTML
*   When converting from email, field captions could be localized
*   When converting from email current set culture is respected when saving datetime
*   Improved initial bootstrap performance 
*   Now can add page numbering when convert html to Wordprocessing 

## Full List of Issues Covering all Changes in this Release

| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-3351 | Feature | Support for page numeration in the output document when convert html to Wordprocessing documents |
| CONVERSIONNET-3733 | Feature | Hide / remove borders while converting DOCX to HTML |
| CONVERSIONNET-3748 | Feature | Implement rename email fields when converting an Email file |
| CONVERSIONNET-3674 | Improvement | Change date format when converting from email formats |
| CONVERSIONNET-3734 | Improvement | Enhance loading times in general / for Converter |
| CONVERSIONNET-3596 | Bug | Error in converting a particular DOCX to PDF |
| CONVERSIONNET-3633 | Bug | Not supported file type exception for certain JPG when using FileStream |
| CONVERSIONNET-3652 | Bug | Watermark and Zoom are not applied when converting ProjectManagement to Markup |
| CONVERSIONNET-3653 | Bug | Converting MSG document with attachments fails with NullReference exception |
| CONVERSIONNET-3655 | Bug | XML support is no more available in 20.1 |
| CONVERSIONNET-3662 | Bug | XML document type is not listed in the possible conversions pair |
| CONVERSIONNET-3688 | Bug | Exception while Converting MPP to PDF |
| CONVERSIONNET-3693 | Bug | Exception while Converting VSDX to PDF |
| CONVERSIONNET-3721 | Bug | API compatibility with System.Drawing.Common version 4.6.0-preview6.19303.8. |
| CONVERSIONNET-3708 | Bug | StreamToFileType adapter in Foundation do not detect certain jpg file |
| CONVERSIONNET-3722 | Bug | Exception while Converting VSDX to PDF |
| CONVERSIONNET-3736 | Bug | Converting image to Pdf takes too long |
| CONVERSIONNET-3741 | Bug | Eml to Xlsx conversion issue |
| CONVERSIONNET-3742 | Bug | Images not resized proportionally when only height or width is set |
| CONVERSIONNET-3654 | Bug | Particular DWG is not detected correctly from StreamToFileTypeAdapter |
| CONVERSIONNET-3728 | Bug | Aspect ratio/output dimension issue  |

## Public API and Backward Incompatible Changes

1.  **GroupDocs.Conversion.Options.Convert.MarkupConvertOptions**  
    Introduced new property in class MarkupConvertOptions
    
    ```csharp
    /// <summary>
    /// Show page borders when converting to fixed layout. Default is True.
    /// </summary>
    public bool FixedLayoutShowBorders { get; set; }
     
    ```
    
    Usage
    
    ```csharp
    var source = "sample.docx";
    using (var converter = new Converter(source))
    {
        var options = new MarkupConvertOptions
        {
            FixedLayoutShowBorders = false
        };
        converter.Convert("converted.html" , options);
    }
    ```
    
2.  **GroupDocs.Conversion.Options.Load.EmailLoadOptions**  
    New properties in EmailLoadOptions
    
    ```csharp
    /// <summary>
    /// The mapping between email message <see cref="EmailField"/> and field text representation
    /// </summary>
    public Dictionary<EmailField, string> FieldTextMap { get; set; }
    /// <summary>
    /// Defines whether need to keep original date header string in mail message when saving or not (Default value is true) 
    /// </summary>
    public bool PreserveOriginalDate { get; set; }
     
    ```
    
    Usage
    
    ```csharp
    var source = "sample.eml";
    var loadOptions = new EmailLoadOptions
    {
        FieldTextMap = new Dictionary<EmailField, string>
        {
            { EmailField.Subject, "Gegenstand" },
            { EmailField.From, "Von" },
            { EmailField.Attachments, "Anhänge" }
        }
    };
    using (var converter = new Converter(source, () => loadOptions))
    {
        var options = new PdfConvertOptions();
        converter.Convert("converted.pdf" , options);
    }
    ```
    
3.  **GroupDocs.Conversion.Options.Load.MarkupLoadOptions**  
    Introduced new class MarkupLoadOptions
    
    ```csharp
    /// <summary>
    /// Options for loading Markup documents.
    /// </summary>
    public sealed class MarkupLoadOptions : LoadOptions
    {
       /// <summary>
       /// Enable or disable generation of page numbering in converted document. Default: false
       /// </summary>
       public bool PageNumbering { get; set; }
    }
     
    ```
    
    Usage
    
    ```csharp
    var source = "sample.html";
    var loadOptions = new MarkupLoadOptions
    {
        PageNumbering = true
    };
    using (var converter = new Converter(source, () => loadOptions))
    {
        var options = new WordProcessingConvertOptions();
        converter.Convert("converted.docx" , options);
    }
    ```
