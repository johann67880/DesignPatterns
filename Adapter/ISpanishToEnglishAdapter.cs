using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface ISpanishToEnglishAdapter
    {
        public void Translate(string words);
    }
}
