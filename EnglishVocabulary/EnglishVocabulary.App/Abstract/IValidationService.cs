using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabulary.App.Abstract
{
    public interface IValidationService
    {
        bool CheckPolishWorld(string world);
        bool CheckEnglishWorld(string world);

    }
}
