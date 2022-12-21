using System.IO;
using System.Runtime.CompilerServices;

namespace GroupDocs.Conversion.Examples.CSharp
{
    internal static class Constants
    {
        public const string LicensePath = "./Resources/GroupDocs.Conversion.lic";
        public const string SamplesPath = @"./Resources/SampleFiles";
        public const string FontsPath = @"./Resources/Fonts";
        public const string OutputPath = @"./Output";

        // AI
        public static string SAMPLE_AI => GetSampleFilePath("sample.ai");

        // BMP
        public static string SAMPLE_BMP => GetSampleFilePath("sample.bmp");

        // CDR
        public static string SAMPLE_CDR => GetSampleFilePath("sample.cdr");

        // CF2
        public static string SAMPLE_CF2 => GetSampleFilePath("sample.cf2");

        // CGM
        public static string SAMPLE_CGM => GetSampleFilePath("sample.cgm");

        // CMX
        public static string SAMPLE_CMX => GetSampleFilePath("sample.cmx");

        // CSV
        public static string SAMPLE_CSV => GetSampleFilePath("sample.csv");

        // DGN
        public static string SAMPLE_DGN => GetSampleFilePath("sample.dgn");

        // DIB
        public static string SAMPLE_DIB => GetSampleFilePath("sample.dib");

        // DICOM
        public static string SAMPLE_DICOM => GetSampleFilePath("sample.dcm");
        public static string SAMPLE_DCM => GetSampleFilePath("sample.dcm");
        
        // DJVU
        public static string SAMPLE_DJVU => GetSampleFilePath("sample.djvu");

        // DNG
        public static string SAMPLE_DNG => GetSampleFilePath("sample.dng");

        // DOC
        public static string SAMPLE_DOC => GetSampleFilePath("sample.doc");

        // DOCM
        public static string SAMPLE_DOCM => GetSampleFilePath("sample.docm");

        // DOCX
        public static string SAMPLE_DOCX => GetSampleFilePath("sample.docx");

        // DOT
        public static string SAMPLE_DOT => GetSampleFilePath("sample.dot");

        // DOTM
        public static string SAMPLE_DOTM => GetSampleFilePath("sample.dotm");

        // DOTX
        public static string SAMPLE_DOTX => GetSampleFilePath("sample.dotx");

        // DWF
        public static string SAMPLE_DWF => GetSampleFilePath("sample.dwf");

        // DWFX
        public static string SAMPLE_DWFX => GetSampleFilePath("sample.dwfx");

        // DWG
        public static string SAMPLE_DWG => GetSampleFilePath("sample.dwg");

        // DWT
        public static string SAMPLE_DWT => GetSampleFilePath("sample.dwt");

        // DXF
        public static string SAMPLE_DXF => GetSampleFilePath("sample.dxf");

        // EMF
        public static string SAMPLE_EMF => GetSampleFilePath("sample.emf");

        // EML
        public static string SAMPLE_EML => GetSampleFilePath("sample.eml");

        // EMLX
        public static string SAMPLE_EMLX => GetSampleFilePath("sample.emlx");

        // EMZ
        public static string SAMPLE_EMZ => GetSampleFilePath("sample.emz");

        // EPS
        public static string SAMPLE_EPS => GetSampleFilePath("sample.eps");

        // EPUB
        public static string SAMPLE_EPUB => GetSampleFilePath("sample.epub");

        // FODP
        public static string SAMPLE_FODP => GetSampleFilePath("sample.fodp");

        // FODS
        public static string SAMPLE_FODS => GetSampleFilePath("sample.fods");

        // GIF
        public static string SAMPLE_GIF => GetSampleFilePath("sample.gif");

        // HTM
        public static string SAMPLE_HTM => GetSampleFilePath("sample.htm");

        // HTML
        public static string SAMPLE_HTML => GetSampleFilePath("sample.html");

        // ICO
        public static string SAMPLE_ICO => GetSampleFilePath("sample.ico");

        // IFC
        public static string SAMPLE_IFC => GetSampleFilePath("sample.ifc");

        // IGS
        public static string SAMPLE_IGS => GetSampleFilePath("sample.igs");

        // J2C
        public static string SAMPLE_J2C => GetSampleFilePath("sample.j2c");

        // J2K
        public static string SAMPLE_J2K => GetSampleFilePath("sample.j2k");

        // JLS
        public static string SAMPLE_JLS => GetSampleFilePath("sample.jls");

        // JP2
        public static string SAMPLE_JP2 => GetSampleFilePath("sample.jp2");

        // JPC
        public static string SAMPLE_JPC => GetSampleFilePath("sample.jpc");

        // JPEG
        public static string SAMPLE_JPEG => GetSampleFilePath("sample.jpeg");

        // JPF
        public static string SAMPLE_JPF => GetSampleFilePath("sample.jpf");

        // JPG
        public static string SAMPLE_JPG => GetSampleFilePath("sample.jpg");

        // JPM
        public static string SAMPLE_JPM => GetSampleFilePath("sample.jpm");

        // JPX
        public static string SAMPLE_JPX => GetSampleFilePath("sample.jpx");

        // LOG
        public static string SAMPLE_LOG => GetSampleFilePath("sample.log");

        // MD
        public static string SAMPLE_MD => GetSampleFilePath("sample.md");

        // MBOX
        public static string SAMPLE_MBOX => GetSampleFilePath("sample.mbox");

        // MHT
        public static string SAMPLE_MHT => GetSampleFilePath("sample.mht");

        // MHTML
        public static string SAMPLE_MHTML => GetSampleFilePath("sample.mhtml");

        // MOBI
        public static string SAMPLE_MOBI => GetSampleFilePath("sample.mobi");

        // MPP
        public static string SAMPLE_MPP => GetSampleFilePath("sample.mpp");

        // MPT
        public static string SAMPLE_MPT => GetSampleFilePath("sample.mpt");

        // MPX
        public static string SAMPLE_MPX => GetSampleFilePath("sample.mpx");

        // MSG
        public static string SAMPLE_MSG => GetSampleFilePath("sample.msg");

        // ODG
        public static string SAMPLE_ODG => GetSampleFilePath("sample.odg");

        // ODP
        public static string SAMPLE_ODP => GetSampleFilePath("sample.odp");

        // ODS
        public static string SAMPLE_ODS => GetSampleFilePath("sample.ods");

        // ODT
        public static string SAMPLE_ODT => GetSampleFilePath("sample.odt");

        // ONE
        public static string SAMPLE_ONE => GetSampleFilePath("sample.one");

        // OST
        public static string SAMPLE_OST => GetSampleFilePath("sample.ost");

        // OTG
        public static string SAMPLE_OTG => GetSampleFilePath("sample.otg");

        // OTP
        public static string SAMPLE_OTP => GetSampleFilePath("sample.otp");

        // OTS
        public static string SAMPLE_OTS => GetSampleFilePath("sample.ots");

        // OTT
        public static string SAMPLE_OTT => GetSampleFilePath("sample.ott");

        // OXPS
        public static string SAMPLE_OXPS => GetSampleFilePath("sample.oxps");

        // PCL
        public static string SAMPLE_PCL => GetSampleFilePath("sample.pcl");

        // PLT
        public static string SAMPLE_PLT => GetSampleFilePath("sample.plt");

        // PNG
        public static string SAMPLE_PNG => GetSampleFilePath("sample.png");

        // PS
        public static string SAMPLE_PS => GetSampleFilePath("sample.ps");

        // POT
        public static string SAMPLE_POT => GetSampleFilePath("sample.pot");

        // POTM
        public static string SAMPLE_POTM => GetSampleFilePath("sample.potm");

        // POTX
        public static string SAMPLE_POTX => GetSampleFilePath("sample.potx");

        // PPS
        public static string SAMPLE_PPS => GetSampleFilePath("sample.pps");

        // PPSM
        public static string SAMPLE_PPSM => GetSampleFilePath("sample.ppsm");

        // PPSX
        public static string SAMPLE_PPSX => GetSampleFilePath("sample.ppsx");

        // PPT
        public static string SAMPLE_PPT => GetSampleFilePath("sample.ppt");

        // PPTM
        public static string SAMPLE_PPTM => GetSampleFilePath("sample.pptm");

        // PPTX
        public static string SAMPLE_PPTX => GetSampleFilePath("sample.pptx");

        // PSD
        public static string SAMPLE_PSD => GetSampleFilePath("sample.psd");

        // PST
        public static string SAMPLE_PST => GetSampleFilePath("sample.pst");

        // RAR
        public static string SAMPLE_RAR => GetSampleFilePath("sample.rar");

        // RTF
        public static string SAMPLE_RTF => GetSampleFilePath("sample.rtf");

        // STL
        public static string SAMPLE_STL => GetSampleFilePath("sample.stl");

        // SVG
        public static string SAMPLE_SVG => GetSampleFilePath("sample.svg");

        // SVGZ
        public static string SAMPLE_SVGZ => GetSampleFilePath("sample.svgz");

        // SXC
        public static string SAMPLE_SXC => GetSampleFilePath("sample.sxc");

        // TEX
        public static string SAMPLE_TEX => GetSampleFilePath("sample.tex");

        // TXT
        public static string SAMPLE_TXT => GetSampleFilePath("sample.txt");

        // TIF
        public static string SAMPLE_TIF => GetSampleFilePath("sample.tif");

        // TIFF
        public static string SAMPLE_TIFF => GetSampleFilePath("sample.tiff");

        // TSV
        public static string SAMPLE_TSV => GetSampleFilePath("sample.tsv");

        // VCF
        public static string SAMPLE_VCF => GetSampleFilePath("sample.vcf");

        // VDW
        public static string SAMPLE_VDW => GetSampleFilePath("sample.vdw");

        // VDX
        public static string SAMPLE_VDX => GetSampleFilePath("sample.vdx");

        // VSD
        public static string SAMPLE_VSD => GetSampleFilePath("sample.vsd");

        // VSDM
        public static string SAMPLE_VSDM => GetSampleFilePath("sample.vsdm");

        // VSDX
        public static string SAMPLE_VSDX => GetSampleFilePath("sample.vsdx");

        // VSS
        public static string SAMPLE_VSS => GetSampleFilePath("sample.vss");

        // VSSM
        public static string SAMPLE_VSSM => GetSampleFilePath("sample.vssm");

        // VSSX
        public static string SAMPLE_VSSX => GetSampleFilePath("sample.vssx");

        // VST
        public static string SAMPLE_VST => GetSampleFilePath("sample.vst");

        // VSTM
        public static string SAMPLE_VSTM => GetSampleFilePath("sample.vstm");

        // VSTX
        public static string SAMPLE_VSTX => GetSampleFilePath("sample.vstx");

        // VSX
        public static string SAMPLE_VSX => GetSampleFilePath("sample.vsx");

        // VTX
        public static string SAMPLE_VTX => GetSampleFilePath("sample.vtx");

        // WEBP
        public static string SAMPLE_WEBP => GetSampleFilePath("sample.webp");

        // WMF
        public static string SAMPLE_WMF => GetSampleFilePath("sample.wmf");

        // WMZ
        public static string SAMPLE_WMZ => GetSampleFilePath("sample.wmz");

        // XLAM
        public static string SAMPLE_XLAM => GetSampleFilePath("sample.xlam");

        // XLS
        public static string SAMPLE_XLS => GetSampleFilePath("sample.xls");

        // XLSB
        public static string SAMPLE_XLSB => GetSampleFilePath("sample.xlsb");

        // XLSM
        public static string SAMPLE_XLSM => GetSampleFilePath("sample.xlsm");

        // XLSX
        public static string SAMPLE_XLSX => GetSampleFilePath("sample.xlsx");

        // XLT
        public static string SAMPLE_XLT => GetSampleFilePath("sample.xlt");

        // XLTM
        public static string SAMPLE_XLTM => GetSampleFilePath("sample.xltm");

        // XLTX
        public static string SAMPLE_XLTX => GetSampleFilePath("sample.xltx");

        // XML
        public static string SAMPLE_XML => GetSampleFilePath("sample.xml");

        // XPS
        public static string SAMPLE_XPS => GetSampleFilePath("sample.xps");

        // ZIP
        public static string SAMPLE_ZIP => GetSampleFilePath("sample.zip");

        // ZIP WITH FOLDERS
        public static string SAMPLE_ZIP_WITH_FOLDERS => GetSampleFilePath("with_folders.zip");



        // CAD
        public static string SAMPLE_DWG_WITH_LAYOUTS_AND_LAYERS => 
            GetSampleFilePath("with_layers_and_layouts.dwg");

        
        // Email messages
        public static string SAMPLE_MSG_WITH_ATTACHMENTS => 
            GetSampleFilePath("with_attachments.msg");
        public static string SAMPLE_OST_SUBFOLDERS => 
            GetSampleFilePath("with_subfolders.ost");

       
        // Markup
        public static string SAMPLE_MARKUP =>
            GetSampleFilePath("sample.html");

        // PDFs
        public static string SAMPLE_PDF => 
            GetSampleFilePath("sample.pdf");
        public static string SAMPLE_PDF_WITH_TOC => 
            GetSampleFilePath("sample-toc.pdf");
        public static string SAMPLE_PDF_WITH_PASSWORD => 
            GetSampleFilePath("sample_with_password.pdf");
        public static string HIEROGLYPHS_PDF => 
            GetSampleFilePath("hieroglyphs.pdf");
        public static string HIEROGLYPHS_1_PDF => 
            GetSampleFilePath("hieroglyphs_1.pdf");
        
        // Presentations
        public static string PPTX_WITH_NOTES => 
            GetSampleFilePath("with_notes.pptx");
        public static string SAMPLE_PPTX_HIDDEN_PAGE =>
            GetSampleFilePath("with_hidden_page.pptx");
        public static string MISSING_FONT_PPTX =>
            GetSampleFilePath("with_missing_font.pptx");
        public static string JPG_IMAGE_PPTX =>
            GetSampleFilePath("with_jpg_image.pptx");
        
        // Spreadsheets
        public static string SAMPLE_XLSX_WITH_PRINT_AREAS => 
            GetSampleFilePath("with_four_print_areas.xlsx");        
        public static string SAMPLE_XLSX_WITH_EMPTY_COLUMN => 
            GetSampleFilePath("with_empty_column.xlsx");        
        public static string SAMPLE_XLSX_WITH_EMPTY_ROW => 
            GetSampleFilePath("with_empty_row.xlsx");
        public static string SAMPLE_XLSX_WITH_HIDDEN_ROW_AND_COLUMN => 
            GetSampleFilePath("with_hidden_row_and_column.xlsx");
        public static string SAMPLE_XLSX_WITH_TEXT_OVERFLOW =>
            GetSampleFilePath("with_overflowing_text.xlsx");
        public static string SAMPLE_XLSX_WITH_HIDDEN_SHEET =>
            GetSampleFilePath("with_hidden_sheet.xlsx");
      
        // Email documents
        public static string SAMPLE_EML_WITH_ATTACHMENT =>
            GetSampleFilePath("embedded-image-and-attachment.eml");

        // Word Processing documents
        public static string SAMPLE_DOCX_WITH_TOC => 
            GetSampleFilePath("sample-toc.docx");
        public static string SAMPLE_DOCX_WITH_COMMENT => 
            GetSampleFilePath("with_comment.docx");
        public static string SAMPLE_DOCX_WITH_PASSWORD => 
            GetSampleFilePath("password_protected.docx");
        public static string SAMPLE_DOCX_WITH_TRACKED_CHANGES => 
            GetSampleFilePath("with_tracked_changes.docx");
        public static string SAMPLE_TXT_SHIFT_JS_ENCODED =>
            GetSampleFilePath("shift_jis_encoded.txt");

        // Images
        public static string SAMPLE_MISSING_FONT_ODG =>
            GetSampleFilePath("with_missing_font.odg");

        // XML
        public static string SAMPLE_XML_DATASOURCE =>
            GetSampleFilePath("sample_datasource.xml");

        // JSON
        public static string SAMPLE_JSON =>
            GetSampleFilePath("sample.json");

        // Default font
        public static string SAMPLE_DEFAULT_FONT =>
            Path.Combine(FontsPath, "terminal-grotesque_open.otf");
        

        private static string GetSampleFilePath(string filePath) =>
            Path.Combine(SamplesPath, filePath);
        
        public static string GetOutputDirectoryPath([CallerFilePath] string callerFilePath = null)
        {
            string outputDirectory = Path.Combine(OutputPath, Path.GetFileNameWithoutExtension(callerFilePath));

            if (!Directory.Exists(outputDirectory))
                Directory.CreateDirectory(outputDirectory);

            string path = Path.GetFullPath(outputDirectory);
            return path;
        }
    }
}
