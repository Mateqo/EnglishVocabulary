using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishVocabulary
{
    public class DesignService
    {

        public void HidePlaceHolder(TextBox textBox,string placeHolder)
        {
            if (textBox.Text == placeHolder)
                textBox.Text = "";
        }

        public void ShowPlaceHolder(TextBox textBox, string placeHolder)
        {
            if (textBox.Text == "")
                textBox.Text = placeHolder;
        }

    }
}
