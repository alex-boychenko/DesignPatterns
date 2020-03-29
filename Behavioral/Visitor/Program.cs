using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new HtmlDocument();

            document.Add(new HeadingNode());
            document.Add(new AnchorNode());

            document.Execute(new HighlightOperation());
            //document.Execute(new PlainTextOperation());

            Console.ReadKey();
        }
    }
}
