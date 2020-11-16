﻿using System;
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
        QuizForm quizForm;
        QuestionsPanelForm questionsPanelForm;
        AddNewQuestionForm addNewQuestionForm;
        RemoveQuestionForm removeQuestionForm;
        StartViewForm startViewForm;

        public UserPanelForm(StartViewForm startViewForm)
        {
            InitializeComponent();
            Initialize(questionService);
            this.startViewForm = startViewForm;
        }

        private void StartQuizLabel_Click(object sender, EventArgs e)
        {
            if (questionService.IsAnyQuestion())
            {
                quizForm = new QuizForm(questionService, this);
                this.Visible = false;
                quizForm.ShowDialog();
            }
        }

        private void ShowQuestionsLabel_Click(object sender, EventArgs e)
        {
            questionsPanelForm = new QuestionsPanelForm(questionService,this);
            this.Visible = false;
            questionsPanelForm.ShowDialog();         
        }

        private void AddNewQuestionLabel_Click(object sender, EventArgs e)
        {          
            addNewQuestionForm = new AddNewQuestionForm(questionService,this);
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

        private static void Initialize(QuestionService questionService)
        {
            questionService.AddNewQuestion("samochód", "car", "easy");
            questionService.AddNewQuestion("dom", "house", "easy");
            questionService.AddNewQuestion("kwiat", "flower", "easy");
            questionService.AddNewQuestion("pies", "dog", "easy");
            questionService.AddNewQuestion("pokój", "room", "easy");
            questionService.AddNewQuestion("zapach", "smell", "easy");
            questionService.AddNewQuestion("dotyk", "touch", "easy");
            questionService.AddNewQuestion("wzrok", "eyesight", "easy");
            questionService.AddNewQuestion("trawnik", "lawn", "easy");
            questionService.AddNewQuestion("lodówka", "fridge", "easy");
            questionService.AddNewQuestion("przewodniczący klasy", "prefect", "medium");
            questionService.AddNewQuestion("nieobecność", "absence", "medium");
            questionService.AddNewQuestion("nadużywać", "abuse", "medium");
            questionService.AddNewQuestion("krzew", "bush", "medium");
            questionService.AddNewQuestion("zdolność", "capacity", "medium");
            questionService.AddNewQuestion("wózek", "cart", "medium");
            questionService.AddNewQuestion("przyłapać", "catch", "medium");
            questionService.AddNewQuestion("powodować", "cause", "medium");
            questionService.AddNewQuestion("pewność siebie", "confidence", "medium");
            questionService.AddNewQuestion("zamieszanie", "confusion", "medium");
            questionService.AddNewQuestion("nieuchwytny", "elusive", "hard");
            questionService.AddNewQuestion("śluza", "floodgate", "hard");
            questionService.AddNewQuestion("piesza wycieczka", "hike", "hard");
            questionService.AddNewQuestion("zrzeczenie się", "waiver", "hard");
            questionService.AddNewQuestion("wypowiedzenie", "termination", "hard");
            questionService.AddNewQuestion("spółka zależna", "subsidiary", "hard");
            questionService.AddNewQuestion("opłaty", "surcharges", "hard");
            questionService.AddNewQuestion("CV", "resume", "hard");
            questionService.AddNewQuestion("kapitał", "asset", "hard");
            questionService.AddNewQuestion("likwidacja spółki", "dissolution", "hard");
            questionService.AddNewQuestion("współpracownik", "associate", "hard");
            questionService.AddNewQuestion("uspokojony", "relieved", "hard");
            questionService.AddNewQuestion("tajniak", "sleuth", "hard");
        }

    }

}
