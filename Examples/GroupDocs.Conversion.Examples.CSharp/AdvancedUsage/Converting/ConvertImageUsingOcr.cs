using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Aspose.OCR;
using GroupDocs.Conversion.Integration.Ocr;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert image using ocr
    /// </summary>
    internal static class ConvertImageUsingOcr
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");


            var imageLoadOptions = new ImageLoadOptions();
            imageLoadOptions.SetOcrConnector(new OcrConnector());

            using (Converter converter = new Converter(Constants.SAMPLE_JPEG, () => imageLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nDocument converted successfully. \nCheck output in {0}", outputFolder);
        }
    }

    internal class OcrConnector : IOcrConnector
    {
        public RecognizedImage Recognize(Stream imageStream)
        {
            try
            {
                var api = new AsposeOcr();
                var ocrInput = new OcrInput(InputType.SingleImage);

                using (MemoryStream ms = new MemoryStream())
                {
                    imageStream.Position = 0;
                    imageStream.CopyTo(ms);
                    ms.Position = 0;
                    ocrInput.Add(ms);

                    var detectedRectangles = api.DetectRectangles(ocrInput, AreasType.LINES, false).First();
                    var result = api.Recognize(ocrInput, new RecognitionSettings
                        {
                            DetectAreasMode = DetectAreasMode.COMBINE,
                            RecognitionAreas = detectedRectangles.Rectangles
                        })
                        .First();
                    return CreateRecognizedImageFromResult(result);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Aspose.OCR Recognition failed: {0}", ex);
            }
            return RecognizedImage.Empty;
        }

        private RecognizedImage CreateRecognizedImageFromResult(RecognitionResult result)
        {
            var lines = new List<TextLine>();

            
            for (var i = 0; i < result.RecognitionAreasText.Count; i++)
            {
                var rectangle = result.RecognitionAreasRectangles[i];
                var s = result.RecognitionAreasText[i].Trim('\r', '\n');
                var fragments = SplitToFragments(s, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
                lines.Add(new TextLine(fragments));
            }
            return new RecognizedImage(lines);
        }

        private static List<TextFragment> SplitToFragments(string lineText, int rectangleX, int rectangleY, int rectangleWidth, int rectangleHeight)
        {
            var fragments = new List<TextFragment>();
            if (!string.IsNullOrEmpty(lineText))
            {
                int index = 0, fragIndex = 0;
                bool isWhitespace = false;
                List<char> frag = new List<char>();
                int previousWidth = 0;
                float fixWidthChar = rectangleWidth / GetEquivalentLength(lineText);
                while (index < lineText.Length)
                {
                    if (frag.Count == 0)
                    {
                        isWhitespace = (lineText[index] == ' ');
                    }
                    else
                    {
                        bool altIsWhitespace = (lineText[index] == ' ');
                        if (index == lineText.Length - 1) frag.Add(lineText[index]);
                        if (altIsWhitespace != isWhitespace || (index == lineText.Length - 1))
                        {
                            string fragment = new string(frag.ToArray());
                            int fragWidth = (int)Math.Round(GetEquivalentLength(fragment) * fixWidthChar);
                            int actualLength = (index == lineText.Length - 1) ? lineText.Length : index;
                            previousWidth = (int)Math.Round(GetEquivalentLength(lineText.Substring(0, actualLength - frag.Count)) * fixWidthChar);
                            fragments.Add(new TextFragment(fragment, new System.Drawing.Rectangle(rectangleX + previousWidth,
                                rectangleY, fragWidth, rectangleHeight)));
                            fragIndex += fragment.Length;
                            frag.Clear();
                            isWhitespace = altIsWhitespace;
                        }
                    }
                    frag.Add(lineText[index]);
                    index++;
                }
            }
            return fragments;
        }
        
        private static readonly List<char> NarrowChars = new List<char>(new char[] { ',', '.', ':', ';', '!', '|', '(', ')', '{', '}',
            'l', 'i', 'I', '-', '+', 'f', 't', 'r'});
        private static readonly List<char> WideChars = new List<char>(new char[] { '\t', 'm', 'w', 'M', 'W' });

        private static float GetEquivalentLength(string lineText)
        {
            var length = 0F;
            foreach (var c in lineText)
            {
                if (c == ' ')
                    length += 0.6F;
                else if (NarrowChars.Contains(c))
                    length += 0.5F;
                else if (WideChars.Contains(c) || char.IsUpper(c))
                    length += 1.5F;
                else
                    length += 1F;
            }
            return length;
        }
    }
}