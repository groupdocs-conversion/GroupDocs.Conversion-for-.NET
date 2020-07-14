---
id: convert-document
url: conversion/net/convert-document
title: Convert document
weight: 3
description: "This documentation explains how to convert a file to PDF, Word, Excel, PowerPoint, Email, JPG, PNG, TIFF and many other formats with just couple of lines of С# (CSharp) code."
keywords: Convert PDF, Convert Word, Convert Excel, Convert Email, Convert Presentation, Convert a File C#, Convert document C#
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="success" >}}
**Try online**  
  
You can try to convert a file online free using GroupDocs.Conversion and download results following this [link](https://products.groupdocs.app/conversion/total)
{{< /alert >}}

# Convert a file
**[GroupDocs.Conversion](https://products.groupdocs.com/conversion/net)** provides a quick and easy way to convert files from some source format to various range of target formats. Conversion process from the user's point of view is pretty simple - source document is loaded to a converter and after conversion is completed, result is saved to a desired file path at local disk or other storage. 
By default when performing internal calculations GroupDocs.Conversion for .NET will use some predefined settings that are most suitable for loading and saving specified file format. However, it is always possible to adjust these settings through [LoadOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load) and [ConvertOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.convert) classes. In general conversion to any format could be triggered by following 3 steps:
*   Create new instance of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter) class and pass source document path as a constructor parameter
*   Instantiate the needed [ConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/convertoptions) object according to your requirements.
*   Call [Convert](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter/methods/convert/2) method of [Converter](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion/converter)class instance and pass name of the converted document and the instance of convert options from the previous step
These documentation articles are explaining in details how to convert a file to the most popular formats:
