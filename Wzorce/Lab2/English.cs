using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class English : ILanguage
    {
        public int Id => 2;
        public string Language => "English";

        private Dictionary<string, string> Translation
        {
            get => Languages.English; set => Languages.English = value;
        }

        public string GetTranslation(string text)
        {
            return Translation[text];
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(GetTranslation(text));
        }
    }
}
