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

        public bool CheckPolishWorld(string world)
        {
            if (properlyPolishWorld.IsMatch(world))
                return true;

            return false;
        }

        public bool CheckEnglishWorld(string world)
        {
            if (properlyEnglishWorld.IsMatch(world))
                return true;

            return false;
        }
    }
}
