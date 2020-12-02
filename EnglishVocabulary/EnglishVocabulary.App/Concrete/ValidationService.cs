using EnglishVocabulary.App.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EnglishVocabulary.App.Concrete
{
    public class ValidationService : IValidationService
    {
        Regex properlyPolishWord = new Regex("^[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]+$");
        Regex properlyEnglishWord = new Regex("^[A-Za-z]+$");

        public bool CheckPolishWord(string word)
        {
            if (properlyPolishWord.IsMatch(word))
                return true;

            return false;
        }

        public bool CheckEnglishWord(string word)
        {
            if (properlyEnglishWord.IsMatch(word))
                return true;

            return false;
        }
    }
}
