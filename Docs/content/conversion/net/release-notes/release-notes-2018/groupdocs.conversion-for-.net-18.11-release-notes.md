---
id: groupdocs-conversion-for-net-18-11-release-notes
url: conversion/net/groupdocs-conversion-for-net-18-11-release-notes
title: GroupDocs.Conversion for .NET 18.11 Release Notes
weight: 1
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 18.11{{< /alert >}}

## Major Features

This regular monthly release contains 10+ improvements and bug fixes. Most notable are: 

*   Improved options to make them more meaningful
*   Conversions from EPS
*   Conversions from/to TSV
*   Conversion from Pcl
*   Rotate feature when converting to image
*   ConvertedDocument extended with additional property which contain conversion elapsed time

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-2814 | Move HideWordTrackedChanges option to WordsLoadOptions class | Improvement |
| CONVERSIONNET-2815 | Move HidePdfAnnotations option to PdfLoadOptions class | Improvement |
| CONVERSIONNET-2816 | Move HideComments option to CellsLoadOptions, Slides CellsLoadOptions and WordsLoadOptions class | Improvement |
| CONVERSIONNET-1509 | Implement conversion from EPS | Feature |
| CONVERSIONNET-2781 | Implement conversion from TSV and to TSV | Feature |
| CONVERSIONNET-2786 | Implement conversion from Pcl | Feature |
| CONVERSIONNET-2797 | Implement setting default font and font substitution options when converting One document | Feature |
| CONVERSIONNET-2799 | Implement setting default font when converting Psd, Emf, Wmf documents | Feature |
| CONVERSIONNET-2801 | Measure conversion time and return it as property of ConvertedDocument class | Feature |
| CONVERSIONNET-2802 | Set font load folders when converting Image documents | Feature |
| CONVERSIONNET-2810 | Implement rotation feature when converting to image | Feature |
| CONVERSIONNET-2818 | Implement option for flatten all form fields when converting Pdf | Feature |
| CONVERSIONNET-2825 | Implement page rotation when converting to Pdf | Feature |
| CONVERSIONNET-2826 | Implement option for including hidden slides in converted document when converting from Slides | Feature |
| CONVERSIONNET-2828 | Set default font when converting from Diagram | Feature |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 18.11. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

## Measure conversion time and return it as property of ConvertedDocument class

```csharp
/// <summary>
/// Class for handling converted document
/// </summary>
public sealed class ConvertedDocument
{
    ...
    /// <summary>
    /// Get the total elapsed time for the conversion in milliseconds
    /// </summary>
    public long Elapsed { get; private set; }
    ...
}
```

Usage

```csharp
...
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
const string source = "source.docx";
var saveOptions = new PdfSaveOptions();
var convertedDocument = conversionHandler.Convert(source, saveOptions);
Console.WriteLine("Elapsed time: {0}ms", convertedDocument.Elapsed);
...
```

## Option for including hidden slides in converted document when converting from Slides

```csharp
/// <summary>
/// Slide document load options
/// </summary>
public class SlidesLoadOptions: LoadOptions
{
    ...
    /// <summary>
    /// Show hidden slides
    /// </summary>
    public bool ShowHiddenSlides { get; set; }
    ...
}
```

Usage

```csharp
...
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
const string source = "source.pptx";
var loadOptions = new SlidesLoadOptions
{
    ShowHiddenSlides = true
};
var saveOptions = new PdfSaveOptions();
var convertedDocument = conversionHandler.Convert(source, loadOptions, saveOptions);
convertedDocument.Save("result");
...
```

## Option for page rotation when converting to Pdf

```csharp
/// <summary>
/// Options for to PDF conversion
/// </summary>
public class PdfSaveOptions : SaveOptions
{
    ...
    /// <summary>
    /// Rotation enum
    /// </summary>
    public enum Rotation
    {
        /// <summary>
        /// None
        /// </summary>
        None,
        /// <summary>
        /// 90 degrees
        /// </summary>
        On90,
        /// <summary>
        /// 180 degrees
        /// </summary>
        On180,
        /// <summary>
        /// 270 degrees
        /// </summary>
        On270
    }
    ...
    /// <summary>
    /// Rotate page
    /// </summary>
    public Rotation Rotate { get; set; }
    ...
}
```

Usage

```csharp
...
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
const string source = "source.docx";
var saveOptions = new PdfSaveOptions {
    Rotate = PdfSaveOptions.Rotation.On90
};
var convertedDocument = conversionHandler.Convert(source, saveOptions);
convertedDocument.Save("result");
...
```

## Option to flatten all form fields when converting Pdf

```csharp
/// <summary>
/// Pdf document load options
/// </summary>
public class PdfLoadOptions : LoadOptions
{
    ...
    /// <summary>
    /// Flatten all the fields of the PDF form
    /// </summary>
    public bool FlattenAllFields { get; set; }
    ...
}
```

Usage

```csharp
...
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
const string source = "source.pdf";
var loadOptions = new PdfLoadOptions
{
    FlattenAllFields = true
};
var saveOptions = new WordsSaveOptions();
var convertedDocument = conversionHandler.Convert(source, loadOptions, saveOptions);
convertedDocument.Save("result");
...
```

## Rotation feature when converting to image

```csharp
/// <summary>
/// Options for to Image conversion
/// </summary>
public class ImageSaveOptions : SaveOptions
{
    ...
    /// <summary>
    /// Image rotation angle 
    /// </summary>
    public int RotateAngle { get; set; }
    ...
}
```

Usage

```csharp
...
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
const string source = "source.pdf";
var saveOptions = new ImageSaveOptions {
    RotateAngle = 45
};
var convertedDocument = conversionHandler.Convert(source, saveOptions);
convertedDocument.Save("result");
...
```

## Set default font and font substitution options when converting One document

```csharp
/// <summary>
/// One document load options
/// </summary>
public class OneLoadOptions: LoadOptions
{
    /// <summary>
    /// Default font for Note document. The following font will be used if a font is missing.
    /// </summary>
    public string DefaultFont { get; set; }
    /// <summary>
    /// Substitute specific fonts when converting Note document.
    /// </summary>
    public IList<KeyValuePair<string, string>> FontSubstitutes { get; }
    /// <summary>
    /// Set password to unprotect protected document
    /// </summary>
    public new string Password { get; set; }
}
```

Usage

```csharp
...
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
const string source = "source.one";
var loadOptions = new OneLoadOptions
{
    DefaultFont = "Helvetica",
};
loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Arial", "Helvetica"));
loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Harriet", "Transcript"));
var saveOptions = new PdfSaveOptions();
var convertedDocument = conversionHandler.Convert(source, loadOptions, saveOptions);
convertedDocument.Save("result");
...
```

## Set default font when converting from Diagram

```csharp
/// <summary>
/// Diagram document load options
/// </summary>
public class DiagramLoadOptions: LoadOptions
{
    /// <summary>
    /// Default font for Diagram document. The following font will be used if a font is missing.
    /// </summary>
    public string DefaultFont { get; set; }
}
```

Usage

```csharp
...
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
const string source = "source.vsd";
var loadOptions = new DiagramLoadOptions
{
    DefaultFont = "Helvetica",
};
var saveOptions = new PdfSaveOptions();
var convertedDocument = conversionHandler.Convert(source, loadOptions, saveOptions);
convertedDocument.Save("result");
...
```

## Set default font when converting Psd, Emf, Wmf documents

```csharp
/// <summary>
/// Image document load options
/// </summary>
public class ImageLoadOptions
{
    /// <summary>
    /// Default font for Psd, Emf, Wmf document types. The following font will be used if a font is missing.
    /// </summary>
    public string DefaultFont { get; set; }
}
```

Usage

```csharp
...
var config = new ConversionConfig();
var conversionHandler = new ConversionHandler(config);
const string source = "source.psd";
var loadOptions = new ImageLoadOptions
{
    DefaultFont = "Helvetica",
};
var saveOptions = new PdfSaveOptions();
var convertedDocument = conversionHandler.Convert(source, loadOptions, saveOptions);
convertedDocument.Save("result"); 
...
```
