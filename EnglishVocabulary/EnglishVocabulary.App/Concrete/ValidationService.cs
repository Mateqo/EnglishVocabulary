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
        Regex properlyPolishWorld = new Regex("^[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]+$");
        Regex properlyEnglishWorld = new Regex("^[A-Za-z]+$");

        public bool CheckPolishWorld(TextBox textBox)
        {
            if (properlyPolishWorld.IsMatch(textBox.Text))
                return true;

            return false;
        }

        public bool CheckEnglishWorld(TextBox textBox)
        {
            if (properlyEnglishWorld.IsMatch(textBox.Text))
                return true;

            return false;
        }
    }
}
