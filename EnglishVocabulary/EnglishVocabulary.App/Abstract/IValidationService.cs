using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabulary.App.Abstract
{
    public interface IValidationService
    {
        bool CheckPolishWord(string word);
        bool CheckEnglishWord(string word);

    }
}
