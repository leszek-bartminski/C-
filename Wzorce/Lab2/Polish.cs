using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Polish : ILanguage
    {
        public int Id => 1;
        public string Language => "Polish";

        public Dictionary<string, string> Translation
        {
            get => Languages.Polish; set => Languages.Polish = value;
        }

        public string GetTranslation(string text)
        {
            return text;
        }
        public void WriteLine(string text)
        {
            Console.WriteLine(GetTranslation(text));
        }
    }
}

