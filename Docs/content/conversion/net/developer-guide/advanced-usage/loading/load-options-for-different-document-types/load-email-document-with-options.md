---
id: load-email-document-with-options
url: conversion/net/load-email-document-with-options
title: Load Email document with options
weight: 3
description: "Learn this article and check how to load and convert Email documents with advanced options using GroupDocs.Conversion for .NET API."
keywords: Load document, Load Email document
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
[**GroupDocs.Conversion**](https://products.groupdocs.com/conversion/net) provides [EmailLoadOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/emailloadoptions) to give you control over how source email document will be processed. The following options could be set:

*   **[Format](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/emailloadoptions/properties/format)** - the document type is auto detected during loading, however you can specify explicitly the type of the source email document. Available options are: Msg, Eml, Emlx, Pst, Ost, Vcf, Mht 
*   **[DisplayHeader](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/emailloadoptions/properties/displayheader)** - option to display or hide the email header  
*   **[DisplayFromEmailAddress](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/emailloadoptions/properties/displayfromemailaddress)** - option to display or hide "from" email address
*   **[DisplayEmailAddress](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/emailloadoptions/properties/displayemailaddress)** - option to display or hide email address
*   [**DisplayToEmailAddress** ](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/emailloadoptions/properties/displaytoemailaddress) - option to display or hide "to" email address
*   **[DisplayCcEmailAddress](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/emailloadoptions/properties/displayccemailaddress)** - option to display or hide "Cc" email address
*   **[DisplayBccEmailAddress](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.load/emailloadoptions/properties/displaybccemailaddress)** - option to display or hide "Bcc" email address
*   **[ConvertOwned ](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/emailloadoptions/properties/convertowned)** - controls whether the owned documents in the documents container must be converted
*   **[ConvertOwner](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/emailloadoptions/properties/convertowner)** - controls whether the documents container itself must be converted If this property is true the documents container will be the first converted document
*   **[Depth](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/emailloadoptions/properties/depth)** - controls how many levels in depth to perform conversion
*   **[FieldTextMap](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/emailloadoptions/properties/fieldtextmap)** - the mapping between email message [EmailField](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/emailfield) and field text representation
*   **[PreserveOriginalDate](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/emailloadoptions/properties/preserveoriginaldate)** - defines whether need to keep original date header string in mail message when saving or not (Default value is true)
*   **[TimeZoneOffset](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.load/emailloadoptions/properties/timezoneoffset)** - gets or sets the Coordinated Universal Time (UTC) offset for the message dates. This property defines the time zone difference, between the localtime and UTC.

### Control fields visibility

The following code sample shows how to convert Email document and control the fields visibility:

```csharp
Contracts.Func<LoadOptions> getLoadOptions = () => new EmailLoadOptions
{
    DisplayHeader = false,
    DisplayFromEmailAddress = false,
    DisplayToEmailAddress = false,
    DisplayEmailAddress = false,
    DisplayCcEmailAddress = false,
    DisplayBccEmailAddress = false
};
using (Converter converter = new Converter("sample.msg", getLoadOptions))
{
    PdfConvertOptions options = new PdfConvertOptions();
    converter.Convert("converted.pdf", options);
}
```

### Converting email attachments

The following code sample shows how to convert Email document and all attachments:

```csharp
var source = "sample-with-attachment.eml";
var loadOptions = new EmailLoadOptions {
                         ConvertOwner = true,
                         ConvertOwned = true,
                         // convert email itself and the attachments
                         Depth = 2
                      };
using (var converter = new Converter(source, () => loadOptions))
{
    var index = 1;
    var options = new PdfConvertOptions();
    // Note: index = 1 is the email itself, all following indexes are attachments
    converter.Convert(() => new FileStream($"converted-{index++}.pdf", FileMode.Create) , options);
}
```

{{< alert style="warning" >}}This functionality is introduced in v20.1{{< /alert >}}

### Localize email fields captions

The following code sample shows how to convert Email document and localize email fields

```csharp
var source = "sample.eml";
var loadOptions = new EmailLoadOptions
{
    FieldTextMap = new Dictionary<EmailField, string>
    {
        { EmailField.Subject, "Gegenstand" },
        { EmailField.From, "Von" },
        { EmailField.Attachments, "Anhänge" }
    }
};
using (var converter = new Converter(source, () => loadOptions))
{
    var options = new PdfConvertOptions();
    converter.Convert("converted.pdf" , options);
}


```

{{< alert style="warning" >}}This functionality is introduced in v20.3{{< /alert >}}

### Control date/time format

The following code sample shows how to convert Email document and modify date/time format

```csharp
var source = "sample.eml";
CultureInfo.CurrentCulture = new CultureInfo("fr-FR");
using (var converter = new Converter(source))
{
    var options = new PdfConvertOptions();
    converter.Convert("converted.pdf" , options);
}
```

{{< alert style="warning" >}}This functionality is introduced in v20.3{{< /alert >}}

## More resources

### GitHub Examples
You may easily run the code above and see the feature in action in our GitHub examples:
*   [GroupDocs.Conversion for .NET examples, plugins, and showcase](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET)
*   [GroupDocs.Conversion for Java examples, plugins, and showcase](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java)
*   [Document Conversion for .NET MVC UI Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC)
*   [Document Conversion for .NET App WebForms UI Modern Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-WebForms)
*   [Document Conversion for Java App Dropwizard UI Modern Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java-Dropwizard)
*   [Document Conversion for Java Spring UI Example](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java-Spring)

### Free Online Document Converter Apps
Along with full-featured .NET library we provide free Apps and free services for document conversion.
In order to see a full potential of GroupDocs.Conversion, you are welcome to convert DOC to PDF, DOC to XLSX, PDF to DOC, PDF to XLSX, PPT to DOC and more with **[Free Online Document Converter App](https://products.groupdocs.app/conversion)** or get a full advantage of **[Free Online Document Converter Suite](https://conholdate.app/features/document-converter-online)** with advanced conversion settings and many more enterprise built-in features.

**Please note** that more [premium features](https://conholdate.app/features), advanced options and enhanced document management experience is available for signed-in users at [conholdate.app](https://conholdate.app) for **FREE**.  
If you don't own an account yet, register it now for free! No credit card is required!
