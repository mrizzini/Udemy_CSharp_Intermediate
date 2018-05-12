using System;

namespace Inheritance
{
    // THIS CLASS DERIVES FROM PRESENTATION OBJECT
    public class Text : PresentationObject
    {
        // Properties:
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            System.Console.WriteLine("Added link to " + url);
        }
    }
}