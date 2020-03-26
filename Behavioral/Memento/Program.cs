using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "article 1";
            history.Push(editor.CreateState());

            editor.Content = "article 2";
            history.Push(editor.CreateState());

            editor.Content = "article 3";
            history.Push(editor.CreateState());

            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

            Console.ReadKey();
        }
    }
}
