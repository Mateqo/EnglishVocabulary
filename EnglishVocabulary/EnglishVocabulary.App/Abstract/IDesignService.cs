using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabulary.App.Abstract
{
    public interface IDesignService
    {
        void HidePlaceHolder(TextBox textBox, string placeHolder);
        void ShowPlaceHolder(TextBox textBox, string placeHolder);
        void CorrectQuestion(Button answerCorrectButton, Label veryficationLabel, PictureBox veryficationPictureBox);
        void WrongQuestion(Button answerButton, Label veryficationLabel, PictureBox veryficationPictureBox);
    }
}
