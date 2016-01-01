Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO

Namespace GroupDocs.Conversion.Examples.VisualBasic
    Module Module1
        Sub Main()
            ' ****************************************************************************************
            ' --------------- START Convert to Cells examples ---------------
            ' ****************************************************************************************

            ' you can set Input and output paths and input file name
            ConvertToCells.storagePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\SampleFiles")
            ConvertToCells.cachePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\OutputFiles")
            'ConvertToCells.inputGUIDFile = "DOCXsample.docx"
            'ConvertToCells.inputGUIDFile = "PDFsample.pdf"
            ConvertToCells.inputGUIDFile = "PPTSample.pptx"

            ' Result as file path
            ConvertToCells.ToCellsAsPath()

            ' Result as Stream
            'ConvertToCells.ToCellsAsStream()

            ' Advanced example
            'ConvertToCells.ToCellsAdvance()

            ' ****************************************************************************************
            ' --------------- END Convert to Cells examples ---------------
            ' ****************************************************************************************


            ' ****************************************************************************************
            ' --------------- START Convert to HTML examples ---------------
            ' ****************************************************************************************

            ' you can set Input and output paths and input file name
            ConvertToHtml.storagePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\SampleFiles")
            ConvertToHtml.cachePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\OutputFiles")
            'ConvertToHtml.inputGUIDFile = "DOCXsample.docx"
            'ConvertToHtml.inputGUIDFile = "PDFsample.pdf"
            ConvertToHtml.inputGUIDFile = "PPTSample.pptx"

            ' Result as file path
            'ConvertToHtml.ToHTMLAsPath()

            ' Result as Stream
            'ConvertToHtml.ToHTMLAsStream()

            ' Advanced example
            'ConvertToHtml.ToHTMLAdvance()

            ' ****************************************************************************************
            ' --------------- END Convert to HTML examples ---------------
            ' ****************************************************************************************

            ' ****************************************************************************************
            ' --------------- START Convert to HTML examples ---------------
            ' ****************************************************************************************

            ' you can set Input and output paths and input file name
            ConvertToImage.storagePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\SampleFiles")
            ConvertToImage.cachePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\OutputFiles")
            'ConvertToImage.inputGUIDFile = "DOCXsample.docx"
            'ConvertToImage.inputGUIDFile = "PDFsample.pdf"
            ConvertToImage.inputGUIDFile = "PPTSample.pptx"

            ' Result as file path
            'ConvertToImage.ToImageAsPath()

            ' Result as Stream
            'ConvertToImage.ToImageAsStream()

            ' Advanced example
            'ConvertToImage.ToImageAdvance()

            ' ****************************************************************************************
            ' --------------- END Convert to Image examples ---------------
            ' ****************************************************************************************

            ' ****************************************************************************************
            ' --------------- START Convert to Pdf examples ---------------
            ' ****************************************************************************************

            ' you can set Input and output paths and input file name
            ConvertToPdf.storagePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\SampleFiles")
            ConvertToPdf.cachePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\OutputFiles")
            'ConvertToPdf.inputGUIDFile = "DOCXsample.docx"
            'ConvertToPdf.inputGUIDFile = "PDFsample.pdf"
            ConvertToPdf.inputGUIDFile = "PPTSample.pptx"

            ' Result as file path
            'ConvertToPdf.ToPdfAsPath()

            ' Result as Stream
            'ConvertToPdf.ToPdfAsStream()

            ' Advanced example
            'ConvertToPdf.ToPdfAdvance()

            ' ****************************************************************************************
            ' --------------- END Convert to Pdf examples ---------------
            ' ****************************************************************************************

            ' ****************************************************************************************
            ' --------------- START Convert to Slides examples ---------------
            ' ****************************************************************************************

            ' you can set Input and output paths and input file name
            ConvertToSlides.storagePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\SampleFiles")
            ConvertToSlides.cachePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\OutputFiles")
            'ConvertToSlides.inputGUIDFile = "DOCXsample.docx"
            ConvertToSlides.inputGUIDFile = "PDFsample.pdf"
            'ConvertToSlides.inputGUIDFile = "PPTSample.pptx"

            ' Result as file path
            'ConvertToSlides.ToSlidesAsPath()

            ' Result as Stream
            'ConvertToSlides.ToSlidesAsStream()

            ' Advanced example
            'ConvertToSlides.ToSlidesAdvance()

            ' ****************************************************************************************
            ' --------------- END Convert to Slides examples ---------------
            ' ****************************************************************************************


            ' ****************************************************************************************
            ' --------------- START Convert to Words examples ---------------
            ' ****************************************************************************************

            ' you can set Input and output paths and input file name
            ConvertToWords.storagePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\SampleFiles")
            ConvertToWords.cachePath = Path.Combine(Environment.CurrentDirectory, "..\..\Data\OutputFiles")
            'ConvertToWords.inputGUIDFile = "DOCXsample.docx"
            'ConvertToWords.inputGUIDFile = "PDFsample.pdf"
            ConvertToWords.inputGUIDFile = "PPTSample.pptx"

            ' Result as file path
            'ConvertToWords.ToWordsAsPath()

            ' Result as Stream
            'ConvertToWords.ToWordsAsStream()

            ' Advanced example
            'ConvertToWords.ToWordsAdvance()

            ' ****************************************************************************************
            ' --------------- END Convert to Words examples ---------------
            ' ****************************************************************************************

        End Sub

    End Module
End Namespace