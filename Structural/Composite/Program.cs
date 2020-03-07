using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var pdfFile = new File("example.pdf");
            var jpegFile = new File("shot.jpeg");
            var docxFile = new File("1.docx");

            var myComputer = new Directory("my computer");

            myComputer.Add(pdfFile);

            var myDocuments = new Directory("my documents");
            myDocuments.Add(jpegFile);
            myDocuments.Add(docxFile);

            myComputer.Add(myDocuments);

            myComputer.Display(1);

            Console.ReadKey();
        }
    }
}
