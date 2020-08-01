---
id: groupdocs-conversion-for-net-19-9-release-notes
url: conversion/net/groupdocs-conversion-for-net-19-9-release-notes
title: GroupDocs.Conversion for .NET 19.9 Release Notes
weight: 5
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 19.9{{< /alert >}}

## Major Features

{{< alert style="danger" >}}In this version we're introducing new public API which was designed to be simple and easy to use. For more details about new API please check Developer Guide section. The legacy API have been moved into Legacy namespace so after update to this version it is required to make project-wide replacement of namespace usages from GroupDocs.Conversion. to GroupDocs.Conversion.Legacy. to resolve build issues.{{< /alert >}}

Additionally one bug is fixed: 

*   Exception "Specified argument was out of the range of valid values" is raised when converting a spreadsheet document to PDF
    

## Full List of Issues Covering all Changes in this Release

| Key |Category | Summary | 
| --- | --- | --- |
| CONVERSIONNET-3142 | Bug | Specified argument was out of the range of valid values when converting a spreadsheet document to pdf |

## Public API and Backward Incompatible Changes

#### All public types from GroupDocs.Conversion namespace 

1.  Have been moved into **GroupDocs.Conversion.Legacy** namespace
2.  Marked as **Obsolete** with message: *This interface/class/enumeration is obsolete and will be available till January 2020 (v20.1).*

#### Full list of types that have been moved and marked as obsolete:

1.  GroupDocs.Conversion.Config.ConversionConfig => GroupDocs.Conversion.Legacy.Config.ConversionConfig
2.  GroupDocs.Conversion.Domain.CacheFileDescription => GroupDocs.Conversion.Legacy.Domain.CacheFileDescription
3.  GroupDocs.Conversion.Domain.ConversionType => GroupDocs.Conversion.Legacy.Domain.ConversionType
4.  GroupDocs.Conversion.Domain.FileDescription => GroupDocs.Conversion.Legacy.Domain.FileDescription
5.  GroupDocs.Conversion.Exceptions.CorruptOrDamagedFileException => GroupDocs.Conversion.Legacy.Exceptions.CorruptOrDamagedFileException
6.  GroupDocs.Conversion.Exceptions.FileTypeNotSupportedException => GroupDocs.Conversion.Legacy.Exceptions.FileTypeNotSupportedException
7.  GroupDocs.Conversion.Exceptions.GroupDocsException => GroupDocs.Conversion.Legacy.Exceptions.GroupDocsException
8.  GroupDocs.Conversion.Exceptions.PasswordProtectedException => GroupDocs.Conversion.Legacy.Exceptions.PasswordProtectedException
9.  GroupDocs.Conversion.Handler.Cache.ICacheDataHandler => GroupDocs.Conversion.Legacy.Handler.Cache.ICacheDataHandler
10.  GroupDocs.Conversion.Handler.Input.IInputDataHandler => GroupDocs.Conversion.Legacy.Handler.Input.IInputDataHandler
11.  GroupDocs.Conversion.Handler.Output.IOutputDataHandler => GroupDocs.Conversion.Legacy.Handler.Output.IOutputDataHandler
12.  GroupDocs.Conversion.Handler.Temp.ITempDataHandler => GroupDocs.Conversion.Legacy.Handler.Temp.ITempDataHandler
13.  GroupDocs.Conversion.Handler.CellsConversionCompleteEventArgs => GroupDocs.Conversion.Legacy.Handler.CellsConversionCompleteEventArgs
14.  GroupDocs.Conversion.Handler.ConversionCompleteHandler => GroupDocs.Conversion.Legacy.Handler.ConversionCompleteHandler
15.  GroupDocs.Conversion.Handler.ConversionCompleteEventArgs => GroupDocs.Conversion.Legacy.Handler.ConversionCompleteEventArgs
16.  GroupDocs.Conversion.Handler.ConversionEventArgs => GroupDocs.Conversion.Legacy.Handler.ConversionEventArgs
17.  GroupDocs.Conversion.Handler.ConversionHandler => GroupDocs.Conversion.Legacy.Handler.ConversionHandler
18.  GroupDocs.Conversion.Handler.ConversionProgressHandler => GroupDocs.Conversion.Legacy.Handler.ConversionProgressHandler
19.  GroupDocs.Conversion.Handler.ConversionProgressEventArgs => GroupDocs.Conversion.Legacy.Handler.ConversionProgressEventArgs
20.  GroupDocs.Conversion.Handler.ConversionStartHandler => GroupDocs.Conversion.Legacy.Handler.ConversionStartHandler
21.  GroupDocs.Conversion.Handler.ConversionStartEventArgs => GroupDocs.Conversion.Legacy.Handler.ConversionStartEventArgs
22.  GroupDocs.Conversion.Handler.ConversionStatus => GroupDocs.Conversion.Legacy.Handler.ConversionStatus
23.  GroupDocs.Conversion.Handler.ConvertedDocument => GroupDocs.Conversion.Legacy.Handler.ConvertedDocument
24.  GroupDocs.Conversion.Handler.DocumentInfo => GroupDocs.Conversion.Legacy.Handler.DocumentInfo
25.  GroupDocs.Conversion.Handler.IConversionProgressListener => GroupDocs.Conversion.Legacy.Handler.IConversionProgressListener
26.  GroupDocs.Conversion.Handler.IConversionStatusListener => GroupDocs.Conversion.Legacy.Handler.IConversionStatusListener
27.  GroupDocs.Conversion.Handler.ImageConversionCompleteEventArgs => GroupDocs.Conversion.Legacy.Handler.ImageConversionCompleteEventArgs
28.  GroupDocs.Conversion.Handler.MarkupConversionCompleteEventArgs => GroupDocs.Conversion.Legacy.Handler.MarkupConversionCompleteEventArgs
29.  GroupDocs.Conversion.Handler.PdfConversionCompleteEventArgs => GroupDocs.Conversion.Legacy.Handler.PdfConversionCompleteEventArgs
30.  GroupDocs.Conversion.Handler.PresentationConversionCompleteEventArgs => GroupDocs.Conversion.Legacy.Handler.PresentationConversionCompleteEventArgs
31.  GroupDocs.Conversion.Handler.SaveInfo => GroupDocs.Conversion.Legacy.Handler.SaveInfo
32.  GroupDocs.Conversion.Handler.WordProcessingConversionCompleteEventArgs => GroupDocs.Conversion.Legacy.Handler.WordProcessingConversionCompleteEventArgs
33.  GroupDocs.Conversion.Options.Load.CadLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.CadLoadOptions
34.  GroupDocs.Conversion.Options.Load.CsvLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.CsvLoadOptions
35.  GroupDocs.Conversion.Options.Load.DiagramLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.DiagramLoadOptions
36.  GroupDocs.Conversion.Options.Load.EmailLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.EmailLoadOptions
37.  GroupDocs.Conversion.Options.Load.ImageLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.ImageLoadOptions
38.  GroupDocs.Conversion.Options.Load.LoadOptions => GroupDocs.Conversion.Legacy.Options.Load.LoadOptions
39.  GroupDocs.Conversion.Options.Load.OneLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.OneLoadOptions
40.  GroupDocs.Conversion.Options.Load.PdfLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.PdfLoadOptions
41.  GroupDocs.Conversion.Options.Load.PresentationLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.PresentationLoadOptions
42.  GroupDocs.Conversion.Options.Load.SpreadsheetLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.SpreadsheetLoadOptions
43.  GroupDocs.Conversion.Options.Load.TxtLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.TxtLoadOptions
44.  GroupDocs.Conversion.Options.Load.WordProcessingLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.WordProcessingLoadOptions
45.  GroupDocs.Conversion.Options.Load.XmlLoadOptions => GroupDocs.Conversion.Legacy.Options.Load.XmlLoadOptions
46.  GroupDocs.Conversion.Options.Save.ImageSaveOptions => GroupDocs.Conversion.Legacy.Options.Save.ImageSaveOptions
47.  GroupDocs.Conversion.Options.Save.JpegOptions => GroupDocs.Conversion.Legacy.Options.Save.JpegOptions
48.  GroupDocs.Conversion.Options.Save.MarkupSaveOptions => GroupDocs.Conversion.Legacy.Options.Save.MarkupSaveOptions
49.  GroupDocs.Conversion.Options.Save.PdfFormattingOptions => GroupDocs.Conversion.Legacy.Options.Save.PdfFormattingOptions
50.  GroupDocs.Conversion.Options.Save.PdfOptimizationOptions => GroupDocs.Conversion.Legacy.Options.Save.PdfOptimizationOptions
51.  GroupDocs.Conversion.Options.Save.PdfOptions => GroupDocs.Conversion.Legacy.Options.Save.PdfOptions
52.  GroupDocs.Conversion.Options.Save.PdfSaveOptions=> GroupDocs.Conversion.Legacy.Options.Save.PdfSaveOptions
53.  GroupDocs.Conversion.Options.Save.PresentationSaveOptions => GroupDocs.Conversion.Legacy.Options.Save.PresentationSaveOptions
54.  GroupDocs.Conversion.Options.Save.PsdOptions => GroupDocs.Conversion.Legacy.Options.Save.PsdOptions
55.  GroupDocs.Conversion.Options.Save.RtfOptions => GroupDocs.Conversion.Legacy.Options.Save.RtfOptions
56.  GroupDocs.Conversion.Options.Save.SaveOptions => GroupDocs.Conversion.Legacy.Options.Save.SaveOptions
57.  GroupDocs.Conversion.Options.Save.SpreadsheetSaveOptions => GroupDocs.Conversion.Legacy.Options.Save.SpreadsheetSaveOptions
58.  GroupDocs.Conversion.Options.Save.TiffOptions => GroupDocs.Conversion.Legacy.Options.Save.TiffOptions
59.  GroupDocs.Conversion.Options.Save.WatermarkOptions => GroupDocs.Conversion.Legacy.Options.Save.WatermarkOptions
60.  GroupDocs.Conversion.Options.Save.WebpOptions => GroupDocs.Conversion.Legacy.Options.Save.WebpOptions
61.  GroupDocs.Conversion.Options.Save.WordProcessingBookmarksOptions=> GroupDocs.Conversion.Legacy.Options.Save.WordProcessingBookmarksOptions
62.  GroupDocs.Conversion.Options.Save.WordProcessingSaveOptions => GroupDocs.Conversion.Legacy.Options.Save.WordProcessingSaveOptions
