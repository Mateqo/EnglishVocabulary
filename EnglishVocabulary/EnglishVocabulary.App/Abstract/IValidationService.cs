using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabulary.App.Abstract
{
    public interface IValidationService
    {
        bool CheckPolishWorld(TextBox textBox);
        bool CheckEnglishWorld(TextBox textBox);

    }
}
