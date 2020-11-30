using EnglishVocabulary.App.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishVocabulary
{
    public partial class AddNewQuestionForm : Form
    {
        DesignService designService = new DesignService();
        ValidationService validationService = new ValidationService();
        QuestionService questionService;
        UserPanelForm userPanelForm;

        public const string PlaceHolderQuestion = "czerwony";
        const string PlaceHolderAnswer = "red";
        const string PlaceHolderLevel = "easy";


        public AddNewQuestionForm(QuestionService questionService, UserPanelForm userPanelForm)
        {
            InitializeComponent();
            this.questionService = questionService;
            this.userPanelForm = userPanelForm;
        }

        private void ShowInfoAboutLevelPictureBox_MouseEnter(object sender, EventArgs e)
        {
            levelToolTip.ToolTipTitle = "Proposed difficulty levels";
            levelToolTip.SetToolTip(infoLevelPictureBox, "easy / medium / hard");
        }

        private void AddNewQuestionButton_Click(object sender, EventArgs e)
        {
            bool status = true;

            if (!validationService.CheckPolishWorld(newQuestionTextBox.Text)|| newQuestionTextBox.Text==PlaceHolderQuestion)
            {
                MessageBox.Show("Incorrect question!", "",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                status = false;
            }
            else if (!validationService.CheckEnglishWorld(newAnswerTextBox.Text) || newAnswerTextBox.Text == PlaceHolderAnswer)
            {
                MessageBox.Show("Incorrect answer!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                status = false;
            }
            else if (!validationService.CheckEnglishWorld(newLevelTextBox.Text))
            {
                MessageBox.Show("Incorrect level!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                status = false;
            }

            if (status)
            {
                questionService.AddNewQuestion(newQuestionTextBox.Text, newAnswerTextBox.Text, newLevelTextBox.Text);
                MessageBox.Show($"Added successfully\n{newQuestionTextBox.Text} - {newAnswerTextBox.Text}\nLevel: {newLevelTextBox.Text}", "Information");
                newQuestionTextBox.Text = PlaceHolderQuestion;
                newAnswerTextBox.Text = PlaceHolderAnswer;
                newLevelTextBox.Text = PlaceHolderLevel;
            }
        }

        private void ReturnToUserPanelPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            userPanelForm.Visible = true;
        }

        #region Placeholder
        private void HidePlaceHolderQuestionTextBox_Enter(object sender, EventArgs e)
        {
            designService.HidePlaceHolder(newQuestionTextBox, PlaceHolderQuestion);
        }

        private void ShowPlaceHolderQuestionTextBox_Leave(object sender, EventArgs e)
        {
            designService.ShowPlaceHolder(newQuestionTextBox, PlaceHolderQuestion);
        }

        private void HidePlaceHolderAnswerTextBox_Enter(object sender, EventArgs e)
        {
            designService.HidePlaceHolder(newAnswerTextBox, PlaceHolderAnswer);
        }

        private void ShowPlaceHolderAnswerTextBox_Leave(object sender, EventArgs e)
        {
            designService.ShowPlaceHolder(newAnswerTextBox, PlaceHolderAnswer);
        }

        private void HidePlaceHolderLeveTextBox_Enter(object sender, EventArgs e)
        {
            designService.HidePlaceHolder(newLevelTextBox, PlaceHolderLevel);
        }

        private void ShowPlaceHolderLevelTextBox_Leave(object sender, EventArgs e)
        {
            designService.ShowPlaceHolder(newLevelTextBox, PlaceHolderLevel);
        }
        #endregion Placeholder

    }
}
