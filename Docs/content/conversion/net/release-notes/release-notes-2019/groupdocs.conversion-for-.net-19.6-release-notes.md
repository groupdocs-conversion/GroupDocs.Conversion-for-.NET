---
id: groupdocs-conversion-for-net-19-6-release-notes
url: conversion/net/groupdocs-conversion-for-net-19-6-release-notes
title: GroupDocs.Conversion for .NET 19.6 Release Notes
weight: 6
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Conversion for .NET 19.6{{< /alert >}}

## Major Features

This regular monthly release contains 5+ new features, improvements and bug fixes. Most notable are: 

*   Conversions from/to Xlam
*   Conversions from Mpx
*   Conversions from Jpc
*   Conversions from Dwt
*   Conversions from JPEG-LS (jls)
*   Improved diagram to word conversions
*   Introduced Metered.GetConsumptionCredit

## Full List of Issues Covering all Changes in this Release

| Key | Category | Summary |
| --- | --- | --- |
| CONVERSIONNET-3089 | Feature | Implement conversion from Xlam |
| CONVERSIONNET-3091 | Feature | Implement conversion to Xlam |
| CONVERSIONNET-3093 | Feature | Implement conversion from Mpx |
| CONVERSIONNET-3096 | Feature | Introduce Metered.GetConsumptionCredit |
| CONVERSIONNET-3098 | Feature | Implement conversion from Jpc |
| CONVERSIONNET-3100 | Feature | Implement conversion from Dwt |
| CONVERSIONNET-3113 | Feature | Implement conversion from JPEG-LS (Jls) |
| CONVERSIONNET-3117 | Improvement | Improve Diagram to Word conversion |
| CONVERSIONNET-2839 | Bug | PowerPoint with black SmartArt Text gets changed into white text when converted to a PDF |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Conversion for .NET 19.6. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Conversion which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

1.  Added GetConsumptionCredit in GroupDocs.Conversion.Metered
    This method returns count of credits which were consumed in case of Metered licensing is used.
    
    ```csharp
    /// <summary>
    /// Retrieves count of credits consumed.
    /// </summary>
    
    public static decimal GetConsumptionCredit()
    {
        return MeteredBillingService.Instance.GetCustomerCredit();
    }
    ```
    
    Following example demonstrates how to retrieve count of credits consumed:
    
    ```csharp
    ...
    string publicKey = "Public Key";
    string privateKey = "Private Key";
    
    Metered metered = new Metered();
    metered.SetMeteredKey(publicKey, privateKey);
     
    decimal creditsConsumed = Metered.GetConsumptionCredit();
    ...
    ```
