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
    public partial class UserPanelForm : Form
    {
        QuestionService questionService = new QuestionService();
        DataService dataService;
        QuizForm quizForm;
        QuestionsPanelForm questionsPanelForm;
        AddNewQuestionForm addNewQuestionForm;
        RemoveQuestionForm removeQuestionForm;
        StartViewForm startViewForm;

        public UserPanelForm(StartViewForm startViewForm)
        {
            InitializeComponent();
            this.startViewForm = startViewForm;
        }

        private void StartQuizLabel_Click(object sender, EventArgs e)
        {
            if (questionService.IsAnyQuestion() && questionService.IsEnoughToQuiz())
            {
                quizForm = new QuizForm(questionService, this);
                this.Visible = false;
                quizForm.ShowDialog();
            }
            else
                MessageBox.Show("Not enough questions or all completed");
        }

        private void ShowQuestionsLabel_Click(object sender, EventArgs e)
        {
            questionsPanelForm = new QuestionsPanelForm(questionService, this);
            this.Visible = false;
            questionsPanelForm.ShowDialog();
        }

        private void AddNewQuestionLabel_Click(object sender, EventArgs e)
        {
            addNewQuestionForm = new AddNewQuestionForm(questionService, this);
            this.Visible = false;
            addNewQuestionForm.ShowDialog();
        }

        private void RemoveQuestionLabel_Click(object sender, EventArgs e)
        {
            removeQuestionForm = new RemoveQuestionForm(questionService, this);
            this.Visible = false;
            removeQuestionForm.ShowDialog();
        }

        private void UpdateProgressTimer_Tick(object sender, EventArgs e)
        {
            completedTasksProgressBar.Value = questionService.UpdateProgress();
            progressPercentLabel.Text = completedTasksProgressBar.Value + " %";
        }

        private void RestartProgressPictureBox_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Do you want to restart progress?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                questionService.RestartProgress();
        }

        private void ReturnToStartViewLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            startViewForm.Visible = true;
        }

        private void SaveLabel_Click(object sender, EventArgs e)
        {
            dataService = new DataService(questionService);

            using (var fbd = new FolderBrowserDialog())
            {

                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    var status = dataService.SaveData(fbd.SelectedPath);

                    if (status)
                        MessageBox.Show("Save Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Something went wrong, please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LoadLabel_Click(object sender, EventArgs e)
        {
            dataService = new DataService(questionService);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "xml files (*.xml)|*.xml";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var status = dataService.LoadData(openFileDialog.FileName);

                    if (status)
                        MessageBox.Show("Load Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Something went wrong, please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }

}
