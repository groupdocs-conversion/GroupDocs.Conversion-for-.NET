![Nuget](https://img.shields.io/nuget/v/groupdocs.conversion) ![Nuget](https://img.shields.io/nuget/dt/groupdocs.conversion) ![GitHub](https://img.shields.io/github/license/groupdocs-conversion/GroupDocs.Conversion-for-.NET)
# Document Conversion API for .NET

[GroupDocs.Conversion for .NET](https://products.groupdocs.com/conversion/net) is a powerful on-premise library used for documents conversion with flexible options for the resulting document. Convert DOC to PDF, PDF to DOC, XLS to DOC, PDF to XLS, PPT to PDF and many other popular document formats with just a few lines of code.

<p align="center">

  <a title="Download complete GroupDocs.Conversion for .NET source code" href="https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

Directory | Description
--------- | -----------
[Docs](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET/tree/master/Examples)  | Product documentation containing Developer's Guide, Release Notes & more.
[Demos](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET/tree/master/Demos)  | Source code for the live demos hosted at https://products.groupdocs.app/conversion/family.
[Examples](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET/tree/master/Examples)  | Package contains C# example project & sample documents used in the examples.
[Showcases](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET/tree/master/Showcases)  | The open source UI examples to integrate GroupDocs.Conversion in front end applications. 
[Plugins](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET/tree/master/Plugins)  | Contains Visual Studio plugins related to GroupDocs.Conversion.

## Document & Image Conversion Features

- [80+ supported file formats](https://docs.groupdocs.com/conversion/net/supported-document-formats/).
- [Add watermark to the converted documents](https://docs.groupdocs.com/conversion/net/add-watermark/).
- Convert PDF & images to Grayscale & linearize PDF documents for the web.
- Remove annotations & embedded files.
- Convert specific pages or [N consecutive pages](https://docs.groupdocs.com/conversion/net/convert-n-consecutive-pages/).
- Convert to HTML format with absolutely positioned HTML elements.
- [Cache conversion results](https://docs.groupdocs.com/conversion/net/how-to-use-custom-cache-implementation/) to local drive or use extension points.
- Load & convert password protected documents.
- Monitor file conversion progress (Start, End) directly at client-side.

## Conversion File Formats

**Spreadsheet:** XLSX, XLSB, XLS2003, XLT, XLTX, XLTM, XLAM, XLS, XLSM, ODS, TSV, CSV\
**Document:** DOC, DOCM, DOCX, DOT, DOTM, DOTX, RTF, TXT, ODT, OTT\
**Presentation:** PPT, PPS, PPTX, PPSX, ODP, POT, POTX, POTM, PPTM, PPSM, FODP\
**Image:** JPEG-LS, TIFF, TIF, JPEG, JPG, PNG, GIF, BMP, ICO, CMX, DIB, JPC\
**Portable Document:** PDF, XPS, EPUB\
**Web:** HTM, HTML, MHTML\
**Adobe Photoshop:** PSD\
**Microsoft Project:** MPT, MPP, MPX\
**Email:** MSG, EML, EMLX\
**Microsoft Visio:** VSD, VSDX, VSS, VST, VSX, VTX, VDW, VDX, SVG, VSDM, VSSM, VSTM\
**AutoCAD:** DXF, DWG, DWF, STL, IFC, DWT\
**Page Description:** EPS, PCL, PS, CGM\
**Markup:** MD

## Document Information Retrieval

**Word Processing:** Word Count, Line Count, Page Count, Author, Creation Date\
**Spreadsheet:** Worksheet Count, Author, Creation Date\
**Presentation:** Slide Count, Author, Creation Date, Presentation Format\
**Email:** Attachment Count, HTML Body, is_Encrypted, is_Signed\
**Image:** Image Width, Image Height, Image Format\
**CAD Drawing:** Collections of layout and layers\
**PDF Document:** Page Count, Author, Creation Date, is_Landscaped, is_Encrypted

## Develop & Deploy GroupDocs.Conversion Anywhere

**Microsoft Windows:** Windows Desktop (x86, x64), Windows Server (x86, x64), Windows Azure\
**macOS:** Mac OS X\
**Linux:** Ubuntu, OpenSUSE, CentOS, and others\
**Development Environments:** Microsoft Visual Studio (2010 & up), Xamarin.Android, Xamarin.IOS, Xamarin.Mac, MonoDevelop 2.4 and later\
**Supported Frameworks:** .NET Standard 2.0, .NET Framework 2.0 or higher, .NET Core 2.0 or higher, Mono Framework 1.2 or higher

## Getting Started with GroupDocs.Conversion for .NET

Are you ready to give GroupDocs.Conversion for .NET a try? Simply execute `Install-Package GroupDocs.Conversion` from Package Manager Console in Visual Studio to fetch & reference GroupDocs.Conversion assembly in your project. If you already have GroupDocs.Conversion for .NET and want to upgrade it, please execute `Update-Package GroupDocs.Conversion` to get the latest version.

## Convert Specific Pages of DOCX to PDF via C# Code

```csharp
using (Converter converter = new Converter("sample.docx"))
{
    PdfConvertOptions options = new PdfConvertOptions
    {
        Pages = new List<int>{ 1, 3 }
    };
    converter.Convert("converted.pdf", options);
}
```

## Fetch all Possible Conversion Formats

```csharp
var allPossibleConversions = Converter.GetAllPossibleConversions();
foreach (var possibleConversions in allPossibleConversions)
{
    Console.WriteLine($"Source format: {possibleConversions.Source.Description}");
    foreach (var primary in possibleConversions.Primary)
    {
        Console.WriteLine($"\t...can be converted to {primary.Description}");
    }
    foreach (var secondary in possibleConversions.Secondary)
    {
        Console.WriteLine($"\t...can be converted to {secondary.Description}");
    }
}
```

[Home](https://www.groupdocs.com/) | [Product Page](https://products.groupdocs.com/conversion/net) | [Documentation](https://docs.groupdocs.com/conversion/net) | [Demo](https://products.groupdocs.app/conversion/family) | [API Reference](https://apireference.groupdocs.com/net/conversion) | [Examples](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET) | [Blog](https://blog.groupdocs.com/category/conversion/) | [Free Support](https://forum.groupdocs.com/c/conversion) | [Temporary License](https://purchase.groupdocs.com/temporary-license)
