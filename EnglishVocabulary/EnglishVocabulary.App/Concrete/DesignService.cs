using EnglishVocabulary.App.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabulary.App.Concrete
{
    public class DesignService : IDesignService
    {
        public void HidePlaceHolder(TextBox textBox, string placeHolder)
        {
            if (textBox.Text == placeHolder)
                textBox.Text = "";
        }

        public void ShowPlaceHolder(TextBox textBox, string placeHolder)
        {
            if (textBox.Text == "")
                textBox.Text = placeHolder;
        }

        public void CorrectQuestion(Button answerCorrectButton, Label veryficationLabel, PictureBox veryficationPictureBox)
        {
            answerCorrectButton.BackColor = Color.SeaGreen;
            veryficationLabel.Visible = true;
            veryficationPictureBox.Visible = true;
            veryficationLabel.Text = "Correct answer";
        }

        public void WrongQuestion(Button answerButton, Label veryficationLabel, PictureBox veryficationPictureBox)
        {
            answerButton.BackColor = Color.Brown;
            veryficationLabel.Visible = true;
            veryficationPictureBox.Visible = true;
            veryficationLabel.Text = "Wrong answer";
        }
    }
}
