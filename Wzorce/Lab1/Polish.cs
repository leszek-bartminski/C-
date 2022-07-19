using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Polish : ILanguage
    {
        public int Id => 1;
        public string Language => "Polish";

        Dictionary<string, string> ILanguage.Translation { get; set; }
    }
}

