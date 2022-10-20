using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class English
    {
        public string Sentence { get; set; }

        public void AnySentence(string words)
        {
            Sentence = words;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Result in english: {Sentence}");
        }
    }
}
