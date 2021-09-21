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

        // CAD
        public static string SAMPLE_DWG_WITH_LAYOUTS_AND_LAYERS => 
            GetSampleFilePath("with_layers_and_layouts.dwg");

        // Diagrams
        public static string SAMPLE_VSDX => 
            GetSampleFilePath("sample.vsdx");
        
        // Email messages
        public static string SAMPLE_MSG => 
            GetSampleFilePath("sample.msg");
        public static string SAMPLE_MSG_WITH_ATTACHMENTS => 
            GetSampleFilePath("with_attachments.msg");
        public static string SAMPLE_OST => 
            GetSampleFilePath("sample.ost");
        public static string SAMPLE_OST_SUBFOLDERS => 
            GetSampleFilePath("with_subfolders.ost");

        // Note
        public static string SAMPLE_ONE =>
            GetSampleFilePath("sample.one");

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

        // Project Management documents
        public static string SAMPLE_MPP => 
            GetSampleFilePath("sample.mpp");

        // Spreadsheets
        public static string SAMPLE_XLSX => 
            GetSampleFilePath("sample.xlsx");
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
        public static string SAMPLE_CSV =>
            GetSampleFilePath("sample.csv");

        // Email documents
        public static string SAMPLE_EML =>
            GetSampleFilePath("sample.eml");
        public static string SAMPLE_EML_WITH_ATTACHMENT =>
            GetSampleFilePath("embedded-image-and-attachment.eml");

        // Word Processing documents
        public static string SAMPLE_DOCX => 
            GetSampleFilePath("sample.docx");
        public static string SAMPLE_DOCX_WITH_TOC => 
            GetSampleFilePath("sample-toc.docx");
        public static string SAMPLE_DOCX_WITH_COMMENT => 
            GetSampleFilePath("with_comment.docx");
        public static string SAMPLE_DOCX_WITH_PASSWORD => 
            GetSampleFilePath("password_protected.docx");
        public static string SAMPLE_DOCX_WITH_TRACKED_CHANGES => 
            GetSampleFilePath("with_tracked_changes.docx");
        public static string SAMPLE_TXT =>
            GetSampleFilePath("sample.txt");
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

        // BMP
        public static string SAMPLE_BMP =>
            GetSampleFilePath("sample.bmp");

        // CGM
        public static string SAMPLE_CGM =>
            GetSampleFilePath("sample.cgm");
        
        // DICOM
        public static string SAMPLE_DICOM =>
            GetSampleFilePath("sample.dcm");

        // EMF
        public static string SAMPLE_EMF =>
            GetSampleFilePath("sample.emf");

        // EPUB
        public static string SAMPLE_EPUB =>
            GetSampleFilePath("sample.epub");

        // HTML
        public static string SAMPLE_HTML =>
            GetSampleFilePath("sample.html");

        // JPG
        public static string SAMPLE_JPG =>
            GetSampleFilePath("sample.jpg");

        // MARKDOWN
        public static string SAMPLE_MD =>
            GetSampleFilePath("sample.md");

        // MHTML
        public static string SAMPLE_MHTML =>
            GetSampleFilePath("sample.mhtml");

        // PCL
        public static string SAMPLE_PCL =>
            GetSampleFilePath("sample.pcl");

        // PNG
        public static string SAMPLE_PNG =>
            GetSampleFilePath("sample.png");

        // PS
        public static string SAMPLE_PS =>
            GetSampleFilePath("sample.ps");

        // SVG
        public static string SAMPLE_SVG =>
            GetSampleFilePath("sample.svg");

        // TEX
        public static string SAMPLE_TEX =>
            GetSampleFilePath("sample.tex");

        // TIFF
        public static string SAMPLE_TIFF =>
            GetSampleFilePath("sample.tiff");

        // XML
        public static string SAMPLE_XML =>
            GetSampleFilePath("sample.xml");

        // XPS
        public static string SAMPLE_XPS =>
            GetSampleFilePath("sample.xps");

        // DWF
        public static string SAMPLE_DWF => GetSampleFilePath("sample.dwf");

        // DWFX
        public static string SAMPLE_DWFX => GetSampleFilePath("sample.dwfx");
        
        // EMZ
        public static string SAMPLE_EMZ => GetSampleFilePath("sample.emz");

        // IFC
        public static string SAMPLE_IFC => GetSampleFilePath("sample.ifc");

        // IGS
        public static string SAMPLE_IGS => GetSampleFilePath("sample.igs");

        // MBOX
        public static string SAMPLE_MBOX => GetSampleFilePath("sample.mbox");
        
        // OXPS
        public static string SAMPLE_OXPS => GetSampleFilePath("sample.oxps");

        // PPSM
        public static string SAMPLE_PPSM => GetSampleFilePath("sample.ppsm");

        // PPTM
        public static string SAMPLE_PPTM => GetSampleFilePath("sample.pptm");

        // PST
        public static string SAMPLE_PST => GetSampleFilePath("sample.pst");

        // STL
        public static string SAMPLE_STL => GetSampleFilePath("sample.stl");

        // TSV
        public static string SAMPLE_TSV => GetSampleFilePath("sample.tsv");

        // VCF
        public static string SAMPLE_VCF => GetSampleFilePath("sample.vcf");

        // VSD
        public static string SAMPLE_VSD => GetSampleFilePath("sample.vsd");

        // XLSM
        public static string SAMPLE_XLSM => GetSampleFilePath("sample.xlsm");

        /***  -----------------     *************/

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
