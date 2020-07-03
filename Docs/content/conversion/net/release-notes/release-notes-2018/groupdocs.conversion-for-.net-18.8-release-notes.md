---
id: groupdocs-conversion-for-net-18-8-release-notes
url: conversion/net/groupdocs-conversion-for-net-18-8-release-notes
title: GroupDocs.Conversion for .NET 18.8 Release Notes
weight: 4
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 18.8{{< /alert >}}

## Major Features

This regular monthly release contains 5+ new features, improvements and bug fixes. Most notable are: 

*   Introduced PdfFormatingOptions when converting to PDF
*   Introduced TxtLoadOptions for conversions from TXT documents
*   Improved per page savings for all conversions
*   Image to PDF conversions improvements

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-2640 | Implement PdfFormattingOptions when converting to PDF | New Feature |
| CONVERSIONNET-2661 | Implement specific options for converting TXT documents | New Feature |
| CONVERSIONNET-2633 | Automatically add extension of the converted file if not set | Improvement |
| CONVERSIONNET-2649 | Remove obsolete constructors and properties | Improvement |
| CONVERSIONNET-2658 | Image to PDF conversion improvement | Improvement |
| CONVERSIONNET-2686 | Improve per page savings when converting to Words, Images, Slides, Cells, Pdf, Xps, Html | Improvement |
| CONVERSIONNET-2687 | Security improvements update | Improvement |
| CONVERSIONNET-2683 | Exception when cache is enabled | Bug |

##   
Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 18.8. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### Following obsolete constructors are removed from ConversionHandler

```csharp
/// <summary>
/// Instantiate the ConversionHandler with default <see cref="IOutputDataHandler"/>, <see cref="ICacheDataHandler"/> and custom <see cref="IInputDataHandler"/> implementation
/// </summary>
/// <param name="conversionConfig">Instance of <see cref="ConversionConfig"/></param>
/// <param name="inputDataHandler">Custom implementation of <see cref="IInputDataHandler" /> interface</param>
public ConversionHandler(ConversionConfig conversionConfig, IInputDataHandler inputDataHandler)
 
/// <summary>
/// Instantiate the ConversionHandler with default <see cref="IInputDataHandler"/>, <see cref="IOutputDataHandler"/> and custom <see cref="ICacheDataHandler"/> implementation
/// </summary>
/// <param name="conversionConfig">Instance of <see cref="ConversionConfig"/></param>
/// <param name="cacheDataHandler">Custom implementation of <see cref="IInputDataHandler" /> interface</param>
public ConversionHandler(ConversionConfig conversionConfig, ICacheDataHandler cacheDataHandler)
 
/// <summary>
/// Instantiate the ConversionHandler with default <see cref="IInputDataHandler"/>, <see cref="ICacheDataHandler"/> and custom <see cref="IOutputDataHandler"/> implementation
/// </summary>
/// <param name="conversionConfig">Instance of <see cref="ConversionConfig"/></param>
/// <param name="outputDataHandler">Custom implementation of <see cref="IOutputDataHandler" /> interface</param>
public ConversionHandler(ConversionConfig conversionConfig, IOutputDataHandler outputDataHandler)
 
/// <summary>
/// Instantiate the ConversionHandler with default <see cref="ICacheDataHandler"/> and custom <see cref="IInputDataHandler"/>, <see cref="IOutputDataHandler"/> implementation
/// </summary>
/// <param name="conversionConfig">Instance of <see cref="ConversionConfig"/></param>
/// <param name="inputDataHandler">Custom implementation of <see cref="IInputDataHandler" /> interface</param>
/// <param name="outputDataHandler">Custom implementation of <see cref="IOutputDataHandler" /> interface</param>
public ConversionHandler(ConversionConfig conversionConfig, IInputDataHandler inputDataHandler, IOutputDataHandler outputDataHandler)
 
/// <summary>
/// Instantiate the ConversionHandler with default <see cref="IOutputDataHandler"/> and custom <see cref="IInputDataHandler"/>, <see cref="ICacheDataHandler"/> implementation
/// </summary>
/// <param name="conversionConfig">Instance of <see cref="ConversionConfig"/></param>
/// <param name="inputDataHandler">Custom implementation of <see cref="IInputDataHandler" /> interface</param>
/// <param name="cacheDataHandler">Custom implementation of <see cref="ICacheDataHandler" /> interface</param>
public ConversionHandler(ConversionConfig conversionConfig, IInputDataHandler inputDataHandler, ICacheDataHandler cacheDataHandler)
/// <summary>
/// Instantiate the ConversionHandler with default <see cref="IInputDataHandler"/> and custom <see cref="IOutputDataHandler"/>, <see cref="ICacheDataHandler"/> implementation
/// </summary>
/// <param name="conversionConfig">Instance of <see cref="ConversionConfig"/></param>
/// <param name="outputDataHandler">Custom implementation of <see cref="IOutputDataHandler" /> interface</param>
/// <param name="cacheDataHandler">Custom implementation of <see cref="ICacheDataHandler" /> interface</param>
public ConversionHandler(ConversionConfig conversionConfig, IOutputDataHandler outputDataHandler, ICacheDataHandler cacheDataHandler)
 
/// <summary>
/// Instantiate the ConversionHandler with custom <see cref="IInputDataHandler"/>, <see cref="IOutputDataHandler"/> and custom <see cref="ICacheDataHandler"/> implementations
/// </summary>
/// <param name="conversionConfig">Instance of <see cref="ConversionConfig"/></param>
/// <param name="inputDataHandler">Custom implementation of <see cref="IInputDataHandler" /> interface</param>
/// <param name="outputDataHandler">Custom implementation of <see cref="IOutputDataHandler" /> interface</param>
/// <param name="cacheDataHandler">Custom implementation of <see cref="ICacheDataHandler" /> interface</param>
public ConversionHandler(ConversionConfig conversionConfig, IInputDataHandler inputDataHandler, IOutputDataHandler outputDataHandler, ICacheDataHandler cacheDataHandler)
```

### Usage

```csharp
var config = new ConversionConfig
{
    StoragePath = ".",
    OutputPath = "." 
};
var handler = new ConversionHandler(config);
```

### Introduced PdfFormatingOptions when converting to PDF

```csharp
/// <summary>
/// Define Pdf formating options
/// </summary>
public sealed class PdfFormatingOptions
{
    ...
 
    /// <summary>
    /// Specify whether position of the document's window will be centerd on the screen. Default: false.
    /// </summary>
    public bool CenterWindow { get; set; }
    /// <summary>
    /// Sets reading order of text: L2R (left to right) or R2L (right to left). Default: L2R.
    /// </summary>
    public PdfDirection Direction { get; set; }
    /// <summary>
    /// Specifying whether document's window title bar should display document title. Default: false.
    /// </summary>
    public bool DisplayDocTitle { get; set; }
    /// <summary>
    /// Specify whether document window must be resized to fit the first displayed page. Default: false.
    /// </summary>
    public bool FitWindow { get; set; }
    /// <summary>
    /// Specify whether menu bar should be hidden when document is active. Default: false.
    /// </summary>
    public bool HideMenubar { get; set; }
    /// <summary>
    /// Specifying whether toolbar should be hidden when document is active. Default: false.
    /// </summary>
    public bool HideToolBar { get; set; }
    /// <summary>
    /// Specify whether user interface elements should be hidden when document is active. Default: false.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public bool HideWindowUI { get; set; }
    /// <summary>
    /// Sets page mode, specifying how to display the document on exiting full-screen mode.
    /// </summary>
    public PdfPageMode NonFullScreenPageMode { get; set; }
    /// <summary>
    /// Sets page layout which shall be used when the document is opened.
    /// </summary>
    public PdfPageLayout PageLayout { get; set; }
    /// <summary>
    /// Sets page mode, specifying how document should be displayed when opened.
    /// </summary>
    public PdfPageMode PageMode { get; set; }
}
```

### Usage

```csharp
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
             
const string source = "source.docx";
var saveOptions = new PdfSaveOptions();
saveOptions.PdfOptions.FormatingOptions.PageMode = PdfFormatingOptions.PdfPageMode.FullScreen;
saveOptions.PdfOptions.FormatingOptions.PageLayout = PdfFormatingOptions.PdfPageLayout.SinglePage;
var convertedDocument = conversionHandler.Convert(source, saveOptions);
convertedDocument.Save("result");
```

### Introduced TxtLoadOptions for conversions from TXT documents

```csharp
/// <summary>
/// Txt document load options
/// </summary>
public class TxtLoadOptions : LoadOptions
{
    /// <summary>
    /// Allows to specify how numbered list items are recognized when plain text document is converted.
    /// The default value is true.</summary>
    /// <remarks>
    /// <para> If this option is set to false, lists recognition algorithm detects list paragraphs, when list numbers ends with
    /// either dot, right bracket or bullet symbols (such as "•", "*", "-" or "o").</para>
    /// <para> If this option is set to true, whitespaces are also used as list number delimeters:
    /// list recognition algorithm for Arabic style numbering (1., 1.1.2.) uses both whitespaces and dot (".") symbols.</para>
    /// </remarks>
    public bool DetectNumberingWithWhitespaces { get; set; }
 
    /// <summary>
    /// Gets or sets preferred option of a trailing space handling.
    /// Default value is <see cref="TxtTrailingSpacesOptions.Trim"/>.
    /// </summary>
    public TxtTrailingSpacesOptions TrailingSpacesOptions { get; set; }
 
    /// <summary>
    /// Gets or sets preferred option of a leading space handling.
    /// Default value is <see cref="TxtLeadingSpacesOptions.ConvertToIndent"/>.
    /// </summary>
    public TxtLeadingSpacesOptions LeadingSpacesOptions { get; set; }
 
    /// <summary>
    /// Gets or sets the encoding that will be used when loading Txt document. Can be null. Default is null.
    /// </summary>
    public Encoding Encoding { get; set; }
}
```

### Usage

```csharp
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
             
const string source = "source.txt";
var loadOptions = new TxtLoadOptions
{
   DetectNumberingWithWhitespaces = false,
   LeadingSpacesOptions = TxtLoadOptions.TxtLeadingSpacesOptions.Trim,
   TrailingSpacesOptions = TxtLoadOptions.TxtTrailingSpacesOptions.Trim
};
var saveOptions = new PdfSaveOptions();
var convertedDocument = conversionHandler.Convert(source, loadOptions, saveOptions);
 convertedDocument.Save("result");
```
