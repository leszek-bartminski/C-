using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Factory
    {
        public ILanguage CreateLanguage(int languageId)
        {
            switch (languageId)
            {
                case 1:
                    //Languages.PolishDictionary();
                    Polish polishVersion = new Polish();
                    return polishVersion;

                case 2:
                    //Languages.EnglishDictionary();
                    English englishVersion = new English();
                    return englishVersion;

                default:
                    return null;
            }
        }
    }
}
