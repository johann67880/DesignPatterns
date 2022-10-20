using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Spanish
    {
        public string Sentence { get; set; }

        public void AnySentence(string words)
        {
            Sentence = words;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Resultado en espaniol: {Sentence}");
        }
    }
}
