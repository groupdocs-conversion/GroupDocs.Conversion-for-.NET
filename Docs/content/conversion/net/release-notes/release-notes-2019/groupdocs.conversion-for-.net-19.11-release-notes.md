---
id: groupdocs-conversion-for-net-19-11-release-notes
url: conversion/net/groupdocs-conversion-for-net-19-11-release-notes
title: GroupDocs.Conversion for .NET 19.11 Release Notes
weight: 3
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 19.11{{< /alert >}}

## Major Features

There are 5+ features, improvements and bug-fixes in this release, most notable are:
*   Solved compatibility issues under .NET Standard 2.0
*   Now client application can hookup to converter and monitor for start, progress and complete states
*   Improved MPP to spreadsheet conversions

## Full List of Issues Covering all Changes in this Release

| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-3460 | Feature | Provide information for conversion start, end and progress |
| CONVERSIONNET-3345 | Improvement | MPP to XLS conversion improvement and missing information |
| CONVERSIONNET-2819 | Bug | Fail to convert a specific word document to PDF |
| CONVERSIONNET-3420 | Bug | Other than PNG to PDF conversion throw exception for PNG source file |
| CONVERSIONNET-3423 | Bug | "System.DllNotFoundException: Unable to load DLL ?gdiplus?" exception when targeting .NET Standard 2.0 under MacOS |
| CONVERSIONNET-3424 | Bug | Compatibility issues under .NET Standard 2.0 |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 19.11. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

1.  **GroupDocs.Conversion.ConverterSettings.Listener**
    
    Introduced new property Listener
    
    ```csharp
    /// <summary>
    /// The converter listener implementation used for monitoring conversion status and progress
    /// </summary>
    public IConverterListener Listener { get; set; } = NullConverterListener.Instance;
    ```
    
    Usage
    
    ```csharp
    var settings = new ConverterSettings
    {
       Listener = new ConverterListener()
    };
    ```
    
    **ConverterListener** is a class which implement **IConverterListener** interface:
    
    ```csharp
    public class ConverterListener : IConverterListener
    {
        public void Started()
        {
            Console.WriteLine("Conversion started...");
        }
        public void Progress(byte current)
        {
            Console.WriteLine($"... {current} % ...");
        }
        public void Completed()
        {
            Console.WriteLine("... conversion completed");
        }
    }
    ```
