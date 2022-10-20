using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = "Hola como estas?";
            Console.WriteLine($"User input in spanish:{words}");

            var adapter = new SpanishToEnglishAdapter();
            adapter.Translate(words);
        }
    }
}
