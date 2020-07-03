---
id: groupdocs-conversion-for-net-18-7-release-notes
url: conversion/net/groupdocs-conversion-for-net-18-7-release-notes
title: GroupDocs.Conversion for .NET 18.7 Release Notes
weight: 5
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 18.7{{< /alert >}}

## Major Features

This regular monthly release contains 5+ new features, improvements and bug fixes. Most notable are: 

*   Introduced MailOption class for controlling email header rendering when converting from email
*   Added support for password protected ODT and OTT documents
*   New way for managing font substitutions when converting from Words, Slides and Cells

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-2615 | MailOption to control conversions from email | New Feature |
| CONVERSIONNET-2625 | Add support for password protected ODT and OTT documents | New Feature |
| CONVERSIONNET-2618 | Implement font substitution option when converting from Words | New Feature |
| CONVERSIONNET-2620 | Implement automatic font substitution option when converting from Words | New Feature |
| CONVERSIONNET-2622 | Implement font substitution option when converting from Slides | New Feature |
| CONVERSIONNET-2624 | Implement font substitution option when converting from Cells | New Feature |
| CONVERSIONNET-2616 | Fonts loading folder is not properly set when converting from Words | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 18.7. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### Explicit font substitution when converting from Cells

```csharp
/// <summary>
/// Default font for Cells document. The following font will be used if a font is missing.
/// </summary>
public string DefaultFont { get; set; }
/// <summary>
/// Substitute specific fonts when converting Cells document.
/// </summary>
public IList<KeyValuePair<string, string>> FontSubstitutes { get; private set; }
```

Usage

```csharp
const string sourceDocument = "international_characters.xls";
var config = new ConversionConfig
{
    StoragePath = ".",
    OutputPath = ".",
};
config.FontDirectories.Add("."); //Path to location of the substituting font
var handler = new ConversionHandler(config);
 
var loadOptions = new CellsLoadOptions();
loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Arial", "Tahoma"));
loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Calibri", "Tahoma"));
 
var options = new PdfSaveOptions();
             
var converted = handler.Convert(sourceDocument, loadOptions, options);
```

### Explicit font substitution when converting from Slides

```csharp
/// <summary>
/// Default font for rendering the presentation. The following font will be used if a presentation font is missing.
/// </summary>
public string DefaultFont { get; set; }
/// <summary>
/// Substitute specific fonts when converting Slides document.
/// </summary>
public IList<KeyValuePair<string, string>> FontSubstitutes { get; private set; }
```

Usage

```csharp
const string sourceDocument = "international_characters.pptx";
var config = new ConversionConfig
{
    StoragePath = ".",
    OutputPath = ".",
};
config.FontDirectories.Add("."); //Path to location of the substituting font
var handler = new ConversionHandler(config);
 
var loadOptions = new SlidesLoadOptions();
loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Arial", "Tahoma"));
loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Calibri", "Tahoma"));
 
var options = new PdfSaveOptions();
             
var converted = handler.Convert(sourceDocument, loadOptions, options);
```

### Explicit font substitution when converting from Words

```csharp
/// <summary>
/// Default font for Words document. The following font will be used if a font is missing.
/// </summary>
public string DefaultFont { get; set; }
/// <summary>
/// If AutoFontSubstitution is disabled, GroupDocs.Conversion uses the DefaultFont for the substitution of missing fonts. If AutoFontSubstitution is enabled,
/// GroupDocs.Conversion evaluates all the related fields in FontInfo (Panose, Sig etc) for the missing font and finds the closest match among the available font sources.
/// Note that font substitution mechanism will override the DefaultFont in cases when FontInfo for the missing font is available in the document. The default value is True.
/// </summary>
public bool AutoFontSubstitution { get; set; }
/// <summary>
/// Substitute specific fonts when converting Words document.
/// </summary>
public IList<KeyValuePair<string, string>> FontSubstitutes { get; private set; }
```

Usage

```csharp
const string sourceDocument = "international_characters.docx";
var config = new ConversionConfig
{
    StoragePath = ".",
    OutputPath = ".",
};
config.FontDirectories.Add("."); //Path to location of the substituting font
var handler = new ConversionHandler(config);
 
var loadOptions = new WordsLoadOptions();
loadOptions.FontSubstitutes.Add(new KeyValuePair<string, string>("Angsana New", "Arial Unicode MS"));
loadOptions.AutoFontSubstitution = false;
var options = new PdfSaveOptions();
             
var converted = handler.Convert(sourceDocument, loadOptions, options);
```

### New property EmailOptions in SaveOptions class

```csharp
/// <summary>
/// Email specific convert options
/// </summary>
public EmailOptions EmailOptions { get; set; }
```

Usage

```csharp
const string sourceDocument = "message.eml";
var config = new ConversionConfig
{
    StoragePath = ".",
    OutputPath = "."
};
var handler = new ConversionHandler(config);
var options = new PdfSaveOptions
{
    EmailOptions =
    {
        DisplayHeader = true,
        DisplayEmailAddress = true,
        DisplayFromEmailAddress = true,
        DisplayToEmailAddress = true,
        DisplayCcEmailAddress = true,
        DisplayBccEmailAddress = true
    }
};
             
var converted = handler.Convert(sourceDocument, options);
```
