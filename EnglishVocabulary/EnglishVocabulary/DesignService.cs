using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void CorrectQuestion(Button answerCorrectButton,Label veryficationLabel,PictureBox veryficationPictureBox)
        {
            answerCorrectButton.BackColor = Color.SeaGreen;
            veryficationLabel.Visible = true;
            veryficationPictureBox.Visible = true;
            veryficationLabel.Text = "Correct answer";
            veryficationPictureBox.Image = Properties.Resources.correct;

        }

        public void WrongQuestion(Button answerButton, Label veryficationLabel, PictureBox veryficationPictureBox)
        {
            answerButton.BackColor = Color.Brown;
            veryficationLabel.Visible = true;
            veryficationPictureBox.Visible = true;
            veryficationLabel.Text = "Wrong answer";
            veryficationPictureBox.Image = Properties.Resources.wrong;
        }

    }
}
