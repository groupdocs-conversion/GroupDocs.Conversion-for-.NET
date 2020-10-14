---
id: set-license-under-mono-linux
url: conversion/net/set-license-under-mono-linux
title: Set license under Mono/Linux
weight: 6
description: ""
keywords: 
productName: GroupDocs.Conversion for .NET
hideChildren: False
---

In some cases under Mono/Linux when license is set from relative path unexpected exceptions are raised.

Under Mono/Linux use one of the following ways to set the license:

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