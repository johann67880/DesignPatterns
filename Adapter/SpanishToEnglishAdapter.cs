using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class SpanishToEnglishAdapter : ISpanishToEnglishAdapter
    {
        private English english = new English();

        public void Translate(string words)
        {
            string translatedWord = "How are you?";
            english.AnySentence(translatedWord);
            english.ShowInfo();
        }
    }
}
