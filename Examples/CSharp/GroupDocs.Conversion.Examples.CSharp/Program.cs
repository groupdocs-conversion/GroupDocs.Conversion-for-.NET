using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GroupDocs.Conversion.Examples.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            /// <summary>
            ///START Convert to Cells examples
            /// </summary>

            /// you can set Input and output paths and input file name along with license path
            Conversion.storagePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\SampleFiles");
            Conversion.cachePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\OutputFiles");
            
            Conversion.inputGUIDFile = "DOCXsample.docx";
            //Conversion.inputGUIDFile = "PPTSample.pptx";
            //Conversion.inputGUIDFile = "PDFsample.pdf";

            // Result as file path (Excel)
            Conversion.ToCellsAsPath();

            // Result as Stream (Excel)
            // Conversion.ToCellsAsStream();

            // Advanced example (Excel)
            //Conversion.ToCellsAdvance();

            // Result as file path (PDF)
            //Conversion.ToPdfAsPath();

            // Result as Stream (PDF)
            //Conversion.ToPdfAsStream();

            // Advanced example (PDF)
            // Conversion.ToPdfAdvance();

            // Result as file path (PowerPoint)
            //Conversion.ToSlidesAsPath();

            // Result as Stream (PowerPoint)
            //Conversion.ToSlidesAsStream();

            // Advanced example (PowerPoint)
            //ConversionConversionToSlidesAdvance();

            // Result as  file path (Word)
            //Conversion.ToWordsAsPath();

            // Result as Stream (Word)
            //Conversion.ToWordsAsStream();

            // Advanced example (Word)
            //Conversion.ToWordsAdvance();


            /// <summary>
            ///Rendering to HTML and Image formats examples
            /// </summary>


            /// you can set Input and output paths and input file name along with license path
            Rendering.storagePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\SampleFiles");
            Rendering.cachePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Data\OutputFiles");

            //Rendering.inputGUIDFile = "DOCXsample.docx";
            //Rendering.inputGUIDFile = "PPTSample.pptx";
            Rendering.inputGUIDFile = "PDFsample.pdf";

            // Result as file path
            //Rendering.ToHTMLAsPath();

            // Result as Stream
            //Rendering.ToHTMLAsStream();

            // Advanced example
            //Rendering.ToHTMLAdvance();

            // Result as file path
            // Rendering.ToImageAsPath();

            // Result as Stream
            //Rendering.ToImageAsStream();

            // Advanced example
            //Rendering.ToImageAdvance();
        }
    }
}
