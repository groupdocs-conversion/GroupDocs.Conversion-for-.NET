---
id: groupdocs-conversion-for-net-18-6-release-notes
url: conversion/net/groupdocs-conversion-for-net-18-6-release-notes
title: GroupDocs.Conversion for .NET 18.6 Release Notes
weight: 6
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 18.6{{< /alert >}}

## Major Features

This regular monthly release contains simplified instantiation of the conversion handler and abstraction for handling streams for temp operation. 

*   Reducing ConversionHandler constructors to one
*   Introduced ITempDataHandler for handling temp operations stream
*   Introducing new properties in ConversionConfig for different handler types

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| CONVERSIONNET-2597 | Reducing ConversionHandler constructors to one | Improvement |
| CONVERSIONNET-2598 | Introduced ITempDataHandler for handling temp operations stream | Improvement |
| CONVERSIONNET-2599 | Introducing new properties in ConversionConfig for different handler types | Improvement |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 18.6. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### v18.6 New ITempDataHandler abstraction for providing custom implementation for providing temp stream

#### New ITempDataHandler

```csharp
/// <summary>
/// Implement this interface to provide custom way of handling temporary files
/// </summary>
public interface ITempDataHandler
{
     /// <summary>
     /// Gets stream for temporary file. This stream usually should be only for writing.
     /// </summary>
     /// <returns></returns>
     Stream CreateTempStream();
}
```

Usage

```csharp
// custom implementation of ITempDataHandler
internal class MyTempDataHandler : ITempDataHandler
{
     public Stream CreateTempStream()
     {
         return new FileStream(string.Format(@"c:\temp\gd-{0:N}.tmp", Guid.NewGuid()), FileMode.Create);
     }
}
 
...
 
// provide instance of the above implementation to the Conversion handler
var config = new ConversionConfig
            {
                TempDataHandler = new MyTempDataHandler(),
                StoragePath = ".", 
                OutputPath = "."
            };
             
var handler = new ConversionHandler(config);
const string sourceFile = @"source.docx";
var result = handler.Convert(sourceFile, new PdfSaveOptions());
result.Save("converted.pdf");
 
Console.WriteLine("Done!");
Console.ReadKey();
```

### v18.6 New properties in ConversionConfig for providing custom DataHandlers instances

#### New properties in ConversionConfig

All constructors listed below are obsolete

```csharp
/// <summary>
/// Custom implementation of <see cref="IInputDataHandler" /> interface
/// </summary>
public IInputDataHandler InputDataHandler { get; set; }
 
 
/// <summary>
/// Custom implementation of <see cref="IOutputDataHandler" /> interface
/// </summary>
public IOutputDataHandler OutputDataHandler { get; set; }
 
 
/// <summary>
/// Custom implementation of <see cref="ICacheDataHandler" /> interface
/// </summary>
public ICacheDataHandler CacheDataHandler { get; set; }
 
/// <summary>
/// Custom implementation of <see cref="ITempDataHandler" /> interface
/// </summary>
public ITempDataHandler TempDataHandler { get; set; }
```

Usage

```csharp
var config = new ConversionConfig
            {
                TempDataHandler = new MyTempDataHandler(),
                StoragePath = ".", 
                OutputPath = "."
            };
             
var handler = new ConversionHandler(config);
```

### v18.6 Obsolete ConversionHandler constructors 

All constructors listed below are obsolete

```csharp
public ConversionHandler(ConversionConfig conversionConfig, IInputDataHandler inputDataHandler);
public ConversionHandler(ConversionConfig conversionConfig, ICacheDataHandler cacheDataHandler);
public ConversionHandler(ConversionConfig conversionConfig, IOutputDataHandler outputDataHandler);
public ConversionHandler(ConversionConfig conversionConfig, IInputDataHandler inputDataHandler, IOutputDataHandler outputDataHandler);
public ConversionHandler(ConversionConfig conversionConfig, IInputDataHandler inputDataHandler, ICacheDataHandler cacheDataHandler);
public ConversionHandler(ConversionConfig conversionConfig, IOutputDataHandler outputDataHandler, ICacheDataHandler cacheDataHandler);
public ConversionHandler(ConversionConfig conversionConfig, IInputDataHandler inputDataHandler, IOutputDataHandler outputDataHandler, ICacheDataHandler cacheDataHandler);
```

There is only one constructor left:

```csharp
public ConversionHandler(ConversionConfig conversionConfig)
```

Usage

```csharp
var config = new ConversionConfig
            {
                TempDataHandler = new MyTempDataHandler(),
                StoragePath = ".", 
                OutputPath = "."
            };
             
var handler = new ConversionHandler(config);
```
