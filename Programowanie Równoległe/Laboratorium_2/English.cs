using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class English : ILanguage
    {
        public int Id => 2;
        public string Language => "English";

        Dictionary<string, string> ILanguage.Translation
        {
            get => Languages.English; set => Languages.English = value;
        }
    }
}
