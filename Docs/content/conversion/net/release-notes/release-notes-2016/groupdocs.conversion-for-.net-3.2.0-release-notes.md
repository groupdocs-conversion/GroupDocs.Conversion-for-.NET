---
id: groupdocs-conversion-for-net-3-2-0-release-notes
url: conversion/net/groupdocs-conversion-for-net-3-2-0-release-notes
title: GroupDocs.Conversion For .NET 3.2.0 Release Notes
weight: 7
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 3.2.0{{< /alert >}}

## Major Features

These are improvements and fixes in this regular monthly release. The most notable are:

*   When converting to PDF return each page in separate stream
*   When converting to HTML return each page in separate stream
*   Place watermark in the converted document
*   Add support for converting to PSD format
*   Add support for converting from PSD format
*   Introducing two public interfaces IConversionProgressListener and IConversionStatusListener
*   Implement ConversionCompleted event with conversion details
*   Show grid lines when converting Excel files
*   Show hidden sheets when converting Excel files
*   Return conversion guid in ConversionProgressEventArgs

## All Changes

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-684 | When converting to PDF return each page in separate stream | New Feature |
| CONVERSIONNET-685 | When converting to HTML return each page in separate stream | New Feature |
| CONVERSIONNET-723 | Place watermark in the converted document | New Feature |
| CONVERSIONNET-724 | Add support for converting to PSD format | New Feature |
| CONVERSIONNET-725 | Add support for converting from PSD format | New Feature |
| CONVERSIONNET-789 | Implement ConversionCompleted event with conversion details | New Feature |
| CONVERSIONNET-807 | ConversionStart event | New Feature |
| CONVERSIONNET-812 | Introducing two public interfaces IConversionProgressListener and IConversionStatusListener | New Feature |
| CONVERSIONNET-816 | Show grid lines when converting Excel files | New Feature |
| CONVERSIONNET-817 | Show hidden sheets when converting Excel files | New Feature |
| CONVERSIONNET-765 | Return conversion guid in ConversionProgressEventArgs | Improvement |
| CONVERSIONNET-710 | Client Response - In-Proper conversion From PPTX to PDF, Image and Word Document formats | Bug |
| CONVERSIONNET-722 | Exception when converting from ODP to PPT and PPS | Bug |
| CONVERSIONNET-734 | While Converting Xlsx file to HTML with HtmlSaveOptions Specific Pages (Sheets) does not work | Bug |
| CONVERSIONNET-740 | Client Response - HTML to Doc and Docx is not proper for Headings and contents are mixed | Bug |
| CONVERSIONNET-749 | Client Response - Only first page converts to PNG from TIF file (With and Without License) | Bug |
| CONVERSIONNET-750 | Client Response - Convert to HTML from Excel, PDF, MS Word overlaps the images AND some of Words with styling | Bug |
| CONVERSIONNET-757 | Can not find CallBack function to get Conversion Progress for MVC/WebForms Applications | Bug |
| CONVERSIONNET-767 | Client Respose - Could not open the file stream on azure. | Bug |
| CONVERSIONNET-782 | Client Response - FileType not supported Exceptions are not handled | Bug |
| CONVERSIONNET-783 | Client Response - Error for Empty Input Documents as Stream for Conversion | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 3.2.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### How to use PageMode when converting to Html or Pdf

When converting to Html or Pdf developers may get conversion result as separate stream or file path for each page from source document.

#### Usage of PageMode when converting to PDF



```csharp
const string sourceFileName = "sample.doc"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var saveOptions = new PdfSaveOptions {
    OutputType = OutputType.String,
    PageMode = true
};

//Note: when using PageMode expected result is either IList<string> or IList<Stream> depending
// of used OutputType in save options provided
var resultPaths = conversionHandler.Convert<IList<string>>(sourceFileName, saveOptions);

foreach(var path in resultPaths) {
  Console.WriteLine("{0}", path);
}
Console.ReadLine();
 
```

#### Usage of PageMode when converting to HTML



```csharp
const string sourceFileName = "sample.doc"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
var saveOptions = new HtmlSaveOptions {
    OutputType = OutputType.String,

    PageMode = true
};


//Note: when using PageMode expected result is either IList<string> or IList<Stream> depending
// of used OutputType in save options provided
var resultPaths = conversionHandler.Convert<IList<string>>(sourceFileName, saveOptions);


foreach(var path in resultPaths) {
  Console.WriteLine("{0}", path);
}
Console.ReadLine();
 
```

#### How to place watermark in converted document



```csharp
const string sourceFileName = "sample.doc"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);
// Save options
SaveOptions saveOptions = new PdfSaveOptions
{
    OutputType = OutputType.String,
    WatermarkOptions = new WatermarkOptions("Watermark text")
    {
        Color = Color.Blue,
        Font = new Font("Arial", 40),
        RotationAngle = 45,
        Transparency = 0.1,
        Left = 200,
        Top = 400
    }
};
var result = conversionHandler.Convert<string>(sourceFileName, saveOptions);
Console.WriteLine("The conversion finished. The result can be located here: {0}. Press <<ENTER>> to exit.", resultPath);
Console.ReadLine();
 
```

#### How to convert from and to PSD

##### Convert to PSD



```csharp
const string sourceFileName = "sample.doc"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);

// Save options
SaveOptions saveOptions = new ImageSaveOptions
{
    OutputType = OutputType.String,
    ConvertFileType = ImageSaveOptions.ImageFileType.Psd,
    PsdOptions = new PsdOptions
    {
        ColorMode = PsdOptions.ColorModes.Grayscale,
        CompressionMethod = PsdOptions.CompressionMethods.Raw
    }
};
var result = conversionHandler.Convert<IList<string>>(sourceFileName , saveOptions);
 
```

##### Convert from PSD



```csharp
const string sourceFileName = "sample.psd"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);

// Save options
SaveOptions saveOptions = new PdfSaveOptions
{
    OutputType = OutputType.String
};
var result = conversionHandler.Convert<string>(sourceFileName , saveOptions);
 
```

#### How to use ConversionStart, ConversionProgress and ConversionComplete events



```csharp
const string sourceFileName = "sample.doc"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);

conversionHandler.ConversionStart += delegate(ConversionStartEventArgs args)
{
    Console.WriteLine("Conversion {0} started", args.ConversionGuid);
};
conversionHandler.ConversionProgress += delegate(ConversionProgressEventArgs args)
{
    Console.WriteLine("Conversion {0} progress: {1} %", args.ConversionGuid, args.Progress);
};
conversionHandler.ConversionComplete += delegate(ConversionCompleteEventArgs args)
{
    Console.WriteLine("Conversion {0} completed", args.ConversionGuid);
    Console.WriteLine("Result document is {0}. Cache is {1}", args.ConversionType, args.UsedCache?"used": "not used");
    Console.WriteLine("Result document has {0} page(s).", ((PdfConversionCompleteEventArgs)args).PageCount);
};
// Save options
SaveOptions saveOptions = new PdfSaveOptions
{
    OutputType = OutputType.String
};
var result = conversionHandler.Convert<string>(sourceFileName, saveOptions);
 
```

#### How to use IConversionProgressListener and IConversionStatusListener to receive conversion status changes and progress info

#### Defining conversion callbacks receiver



```csharp
public class ConversionManager : IConversionProgressListener, IConversionStatusListener
{
    private readonly ConversionHandler _conversionHandler;
    public ConversionManager(string path)
    {
        var conversionConfig = new ConversionConfig { StoragePath = path };
        _conversionHandler = new ConversionHandler(conversionConfig);
        _conversionHandler.SetConversionProgressListener(this);
        _conversionHandler.SetConversionStatusListener(this);
    }
    public void ConversionProgressChanged(ConversionProgressEventArgs args)
    {
        Console.WriteLine("Conversion progress: {0} %", args.Progress);
    }
    public void ConversionStatusChanged(ConversionEventArgs args)
    {
        Console.WriteLine("Conversion status changed to: {0}", args.Status);
    }
    public string Convert(string file)
    {
        var option = new PdfSaveOptions
        {
            OutputType = OutputType.String
        };
        return _conversionHandler.Convert<string>(file, option);
    }
}
 
```

#### Usage of the conversion callback receiver for getting updates from conversion



```csharp
const string sourceFileName = "sample.xlsx"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);

// Save options
SaveOptions saveOptions = new HtmlSaveOptions
{
    OutputType = OutputType.String,
    ShowGridLines = true
};

var result = conversionHandler.Convert<string>(sourceFileName, saveOptions);
 
```

#### How to show grid lines when converting from Excel



```csharp
const string sourceFileName = "sample.xlsx"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);

// Save options
SaveOptions saveOptions = new HtmlSaveOptions
{
    OutputType = OutputType.String,
    ShowGridLines = true
};

var result = conversionHandler.Convert<string>(sourceFileName, saveOptions);
 
```

#### How to show hidden sheets when converting from Excel



```csharp
const string sourceFileName = "sample.xlsx"; //TODO: Put the source filename here
// Setup Conversion configuration
var conversionConfig = new ConversionConfig
{
    CachePath = "cache",
    StoragePath = "."
};
var conversionHandler = new ConversionHandler(conversionConfig);

// Save options
SaveOptions saveOptions = new HtmlSaveOptions
{
    OutputType = OutputType.String,
    ShowHiddenSheets = true
};

var result = conversionHandler.Convert<string>(sourceFileName, saveOptions);
 
```
