using System;
using Microsoft.Office.Interop.PowerPoint;

namespace FindLyrics.Models
{
    public class Cancionero
    {

        public static string values
        {
            get
            {
                string value = string.Empty;

                Application PowerPoint_App = new Application();
                Presentations multi_presentations = PowerPoint_App.Presentations;
                Presentation presentation = multi_presentations.Open(@"D:\Dominacion Mundial\Net\FindLyrics\FindLyrics.Models\CANCIONEROOFICIAL.ppt");
                value = string.Empty;
                for (int i = 0; i < presentation.Slides.Count; i++)
                {
                    foreach (Shape shape in presentation.Slides[i + 1].Shapes)
                    {
                        if (shape.HasTextFrame == Microsoft.Office.Core.MsoTriState.msoTrue && shape.TextFrame.HasText == Microsoft.Office.Core.MsoTriState.msoTrue)
                            value += shape.TextFrame.TextRange.Text + " ";
                    }
                }
                PowerPoint_App.Quit();

                return value;
            }
        }
    }
}
