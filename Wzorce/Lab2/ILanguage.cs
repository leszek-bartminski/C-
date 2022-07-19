using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    interface ILanguage
    {
        int Id { get; }
        string Language { get; }
/*        Dictionary<string, string> Translation { get; set; }*/

        string GetTranslation(string text);
        void WriteLine(string text);
    }
}

