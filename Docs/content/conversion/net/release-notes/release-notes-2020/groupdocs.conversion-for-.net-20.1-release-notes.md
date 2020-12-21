---
id: groupdocs-conversion-for-net-20-1-release-notes
url: conversion/net/groupdocs-conversion-for-net-20-1-release-notes
title: GroupDocs.Conversion for .NET 20.1 Release Notes
weight: 10
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 20.1{{< /alert >}}{{< alert style="danger" >}}In this version we will remove Legacy API of GroupDocs.Conversion. So from version 20.1 GroupDocs.Conversion.Legacy. does not exist anymore{{< /alert >}}

## Major Features

There are 10+ features, improvements and bug-fixes in this release, most notable are:

*   Legacy API is removed from the product
*   Introduced EML to MSG conversions
*   API to retrieve prepared default ConvertOptions for desired target conversion
*   Introduced GetAllPossibleConversions method which return all supported conversions
*   GetPossibleConversions method for a document extension without instantiating a *Converter*
*   GetPossibleConversions for currently provided source document
*   Improved document info classes
*   Image to image conversions now produces proportional image if only width or only height is provided 

## Full List of Issues Covering all Changes in this Release

| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-3290 | Feature | EML to MSG conversion |
| CONVERSIONNET-3512 | Feature | API to retrieve prepared default ConvertOptions for desired target conversion |
| CONVERSIONNET-3536 | Feature | Convert attachments from a mail document |
| CONVERSIONNET-3586 | Feature | GetAllPossibleConversions method which returns all supported conversions |
| CONVERSIONNET-3587 | Feature | GetPossibleConversions for a document extension without instantiating a Converter |
| CONVERSIONNET-3597 | Improvement | Improve document info classes  |
| CONVERSIONNET-3626 | Improvement | Make proportional image If only Width or Height is provided when converting to image |
| CONVERSIONNET-3576 | Bug | Email to Excel conversion issue |
| CONVERSIONNET-3581 | Bug | Email to Word or PDF License Not working |
| CONVERSIONNET-3625 | Bug | PageNumber and PagesCount not respected when converting to image |
| CONVERSIONNET-3634 | Bug | 'Index was out of range.' exception when converting particular .mpx file to .html |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 20.1. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

1.  **GroupDocs.Conversion.Contracts.PossibleConversions**  
    Introduced new class PossibleConversions
    
    ```csharp
    /// <summary>
    /// Represents a mapping what conversion pairs
    /// are supported for specific source file format
    /// </summary>
    public sealed class PossibleConversions
    {
        /// <summary>
        /// Source file formats
        /// </summary>
        public FileType Source { get; private set; }
     
     
        /// <summary>
        /// All target file types and primary/secondary flag
        /// </summary>
        public IEnumerable<TargetConversion> All { get; }
     
        /// <summary>
        /// Returns target conversion for specified target file type
        /// </summary>
        /// <param name="target"></param>
        /// <returns><see cref="TargetConversion"/> or null</returns>
        public TargetConversion this[FileType target] { get; }
     
     
        /// <summary>
        /// Returns target conversion for specified target file type extension
        /// </summary>
        /// <param name="extension"></param>
        /// <returns><see cref="TargetConversion"/> or null</returns>
        public TargetConversion this[string extension] { get; }
     
        /// <summary>
        /// Primary target file types
        /// </summary>
        public IEnumerable<FileType> Primary { get; }
     
     
        /// <summary>
        /// Secondary target file types
        /// </summary>
        public IEnumerable<FileType> Secondary { get; }
    }
    ```
    
    Usage:
    
    ```csharp
    using (var converter = new Converter("source.docx"))
    {
        var possibleConversions = converter.GetPossibleConversions();
        ...
    }
    ```
    
2.  **GroupDocs.Conversion.Contracts.TargetConversion**  
    Introduced new class TargetConversion
    
    ```csharp
    /// <summary>
    /// Represents possible target conversion and a flag is it a primary or secondary 
    /// </summary>
    public sealed class TargetConversion
    {
        /// <summary>
        /// Target document format
        /// </summary>
        public FileType Format { get; }
     
        /// <summary>
        /// Is the conversion primary
        /// </summary>
        public bool IsPrimary { get;  }
     
     
        /// <summary>
        /// Predefined convert options which could be used to convert to current type
        /// </summary>
        public ConvertOptions ConvertOptions { get; }
    } 
    ```
    
    Usage:
    
    ```csharp
    using (var converter = new Converter("source.docx"))
    {
        var possibleConversions = converter.GetPossibleConversions();
        var targetConversion = possibleConversions["pdf"];
        var convertOptions = targetConversion?.ConvertOptions;
        ...
    }
    ```
    
3.  **GroupDocs.Conversion.Converter.GetAllPossibleConversions**  
    Introduced new static method GetAllPossibleConversions in Converter class
    
    ```csharp
    /// <summary>
    /// Gets all supported conversions
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<PossibleConversions> GetAllPossibleConversions()
    ```
    
    Usage:
    
    ```csharp
    var allPossibleConversions = Converter.GetAllPossibleConversions();
    foreach (var possibleConversions in allPossibleConversions)
    {
        Console.WriteLine($"Source format: {possibleConversions.Source.Description}");
        foreach (var primary in possibleConversions.Primary)
        {
            Console.WriteLine($"\t-->{primary.Description}");
        }
        foreach (var secondary in possibleConversions.Secondary)
        {
            Console.WriteLine($"\t-->{secondary.Description}");
        }
    }
    ```
    
4.  **GroupDocs.Conversion.Converter.GetPossibleConversions**  
    Introduced new method GetPossibleConversions in Converter class
    
    ```csharp
    /// <summary>
    /// Gets possible conversions for the source document.
    /// </summary>
    /// <returns></returns>
    public PossibleConversions GetPossibleConversions()
    ```
    
    Usage:
    
    ```csharp
    using (var converter = new Converter("source.docx"))
    {
        var possibleConversions = converter.GetPossibleConversions();
        ...
    }
    ```
    
    Introduced new static method GetPossibleConversions in Converter class
    
    ```csharp
    /// <summary>
    /// Gets supported conversions for provided document extension
    /// </summary>
    /// <param name="extension">Document extension</param>
    /// <example>Converter.GetPossibleConversions(".docx")</example>
    /// <example>Converter.GetPossibleConversions("docx")</example>
    /// <returns></returns>
    public static PossibleConversions GetPossibleConversions(string extension)
    ```
    
    Usage:
    
    ```csharp
    var possibleConversions = Converter.GetPossibleConversions("docx");
    var targetConversion = possibleConversions["pdf"]; // docx -> pdf
    var convertOptions = targetConversion?.ConvertOptions;
    ```
    
5.  **GroupDocs.Conversion.Options.Convert.EmailConvertOptions**  
    Introduced new class EmailConvertOptions
    
    ```csharp
    /// <summary>
    /// Options for conversion to Email file type.
    /// </summary>
    public class EmailConvertOptions : ConvertOptions<EmailFileType>
    {
    }
    ```
    
    Usage:
    
    ```csharp
    using(var converter = new Converter("source.eml")) {
        var convertOptions = new EmailConvertOptions
        {
            Format = EmailFileType.Msg
        };
        converter.Convert("converted.msg",  convertOptions);
    }
    ```
    
6.  **GroupDocs.Conversion.Options.Load.EmailLoadOptions**  
    Introduced new property ConvertAttachments in EmailLoadOptions
    
    ```csharp
    /// <summary>
    /// Option to convert attachments in source email or not. Default: false.
    /// </summary>
    public bool ConvertAttachments { get; set; }
    ```
    
    Usage:
    
    ```csharp
    var source = "sample-with-attachment.eml";
    var loadOptions = new EmailLoadOptions {ConvertAttachments = true};
    using (var converter = new Converter(source, () => loadOptions))
    {
        var index = 1;
        var options = new PdfConvertOptions();
        converter.Convert(() => new FileStream($"converted-{index++}.pdf", FileMode.Create) , options);
    }
    ```
    
7.  **GroupDocs.Conversion.Legacy**  
    Removed all public types form GroupDocs.Conversion.Legacy namespace.
