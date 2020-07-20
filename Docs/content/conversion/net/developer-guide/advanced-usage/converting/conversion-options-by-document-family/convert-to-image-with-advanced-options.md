---
id: convert-to-image-with-advanced-options
url: conversion/net/convert-to-image-with-advanced-options
title: Convert to Image with advanced options
weight: 4
description: "Follow this guide and learn how to convert documents to image with height, width, resolution, brightness and other customizations using GroupDocs.Conversion for .NET."
keywords: Convert to Image, Convert Image
productName: GroupDocs.Conversion for .NET
hideChildren: False
---
GroupDocs.Conversion provides [ImageConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions) to give you control over conversion result when convert to image. Along with [common convert options]({{< ref "conversion/net/developer-guide/advanced-usage/converting/common-conversion-options/_index.md" >}}) from base class [ImageConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions) has the following additional options:

*   [Format](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert.convertoptions/1/properties/format) - desired result document type. Available options are: *Tiff, Tif, Jpg, Jpeg, Png, Gig, Bmp, Ico, Psd, Wmf, Emf, Dcm, Webp, Dng, Svg, Jp2, Odg, J2c, J2k, Jpx, Jpf, Jpm, Eps, Cgm, Cdr, Cmx, Dib, Jpc, Jls, DjVu*
*   [Width](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions/properties/width) - desired image width after conversion
*   [Height](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions/properties/height) - desired image height after conversion
*   [HorizontalResolution](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions/properties/horizontalresolution) - desired image horizontal resolution after conversion
*   [VerticalResolution](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions/properties/verticalresolution) - desired image vertical resolution after conversion
*   [Grayscale](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions/properties/grayscale) - if true converted image will be grayscaled
*   [RotateAngle](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions/properties/rotateangle) - image rotation angle
*   [FlipMode](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions/properties/flipmode) - image flip mode. Available options are: *None, FlipX, FlipY, FlipXY*
*   [Brightness](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions/properties/brightness) - adjusts image brightness
*   [Contrast](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions/properties/contrast) - adjusts image contrast
*   [Gamma](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions/properties/gamma) - adjust image gamma 
*   [JpegOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.convert/imageconvertoptions/properties/jpegoptions) - JPEG specific convert options
*   [TiffOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.convert/imageconvertoptions/properties/tiffoptions) - TIFF specific convert options
*   [PsdOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.convert/imageconvertoptions/properties/psdoptions) - PSD specific convert options
*   [WebpOptions](https://apireference.groupdocs.com/conversion/net/groupdocs.conversion.options.convert/imageconvertoptions/properties/webpoptions) - WebP specific convert options
*   [UsePdf](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions/properties/usepdf) - in some cases, for better rendering and elements positioning the source document should be converted to PDF first. If this property is set to *true*, the input firstly is converted to PDF and after that to desired format

Following code snippet shows how to convert to image with advanced options

```csharp
string outputFileTemplate = Path.Combine("c:\output", "converted-page-{0}.png");
SavePageStream getPageStream = page => new FileStream(string.Format(outputFileTemplate, page), FileMode.Create);
using (Converter converter = new Converter("sample.pdf"))
{
    ImageConvertOptions options = new ImageConvertOptions
    {
        Format = ImageFileType.Png,
        FlipMode = ImageFlipModes.FlipY,
        Brightness = 50,
        Contrast = 50,
        Gamma = 0.5F,
        Grayscale = true,
        HorizontalResolution = 300,
        VerticalResolution = 100
    };
    
    converter.Convert(getPageStream, options);
}
```

### JpegOptions

[JpegOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/jpegoptions) is subset of [ImageConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions) which allow enhanced control over conversions to JPEG format. 

The following options are available:

*   [Quality](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/jpegoptions/properties/quality) - desired image quality.
*   [ColorMode](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/jpegoptions/properties/colormode) - JPEG color mode. Available options are: *Rgb, YCbCr, Cmyk, Ycck, Grayscale*
*   [Compression](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/jpegoptions/properties/compression) - JPEG compression methods. Available options are: *Baseline, Progressive, Lossless, JpegLs*

### TiffOptions

[TiffOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/tiffoptions) is subset of  [ImageConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions) which allow enhanced control over conversions to TIFF format. 

The following options are available:

*   [Compression](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/tiffoptions/properties/compression) - TIFF compression method. Available options are: None, Lzw, Ccitt3, Ccitt4, Rle

### PsdOptions

[PsdOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/psdoptions) is subset of  [ImageConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions) which allow enhanced control over conversions to PSD format. 

The following options are available:

*   [ChannelBitsCount](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/psdoptions/properties/channelbitscount) - bits count per channel
*   [ChannelsCount](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/psdoptions/properties/channelscount) - color channels count
*   [ColorMode](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/psdoptions/properties/colormode) - PSD color mode. Available options are: *Bitmap, Grayscale, Indexed, Rgb, Cmyk, Multichannel, Duotone, Lab*
*   [Compression](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/psdoptions/properties/compression) - PSD compression method. Available options are: *Raw, Rle, ZipWithoutPrediction, ZipWithPrediction*
*   [Version](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/psdoptions/properties/version) - desired PSD version

### WebpOptions

[WebpOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/webpoptions) is subset of  [ImageConvertOptions](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/imageconvertoptions) which allow enhanced control over conversions to WebP format. 

The following options are available:

*   [Lossless](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/webpoptions/properties/lossless) - the compression of the converted image will be lossless.
*   [Quality](https://apireference.groupdocs.com/net/conversion/groupdocs.conversion.options.convert/webpoptions/properties/quality) - set the quality of converted image

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
In order to see a full potential of GroupDocs.Conversion, you are welcome to convert DOC to PDF, DOC to XLSX, PDF to DOC, PDF to XLSX, PPT to DOC and more with [Free Online Document Converter App](https://products.groupdocs.app/conversion) or get a full advantage of [Free Online Document Converter Suite](https://conholdate.app/features/document-converter-online) with advanced conversion settings and many more enterprise built-in features.

**Please note** that more [premium features](https://conholdate.app/features), advanced options and enhanced document management experience is available for signed-in users at [conholdate.app](https://conholdate.app) for **FREE**.  
If you don't own an account yet, register it now for free! No credit card is required!