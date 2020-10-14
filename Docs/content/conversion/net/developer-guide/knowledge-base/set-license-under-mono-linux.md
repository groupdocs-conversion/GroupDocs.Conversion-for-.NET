---
id: set-license-under-mono-linux
url: conversion/net/set-license-under-mono-linux
title: How to set license under Mono/Linux
weight: 6
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---

If under Mono/Linux observe unexpected exceptions when license is set, but this exceptions do not appear without license, try to set the license by the one of the following two ways:

1. Set license with absolute path e.g

    ```csharp
    license.SetLicense("/home/<USERNAME>/conversion-sample-src/GroupDocs.Conversion.NET.lic");
    ```

2. Provide license stream loaded from the license file e.g.
    
    ```csharp
    using(var licenseStream = new FileStream("GroupDocs.Conversion.NET.lic", FileMode.Open)) {

        license.SetLicense(licenseStream);
        
    }
    ```