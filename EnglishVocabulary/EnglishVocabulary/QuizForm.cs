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
    public partial class QuizForm : Form
    {
        DesignService designService = new DesignService();
        QuestionService questionService;
        UserPanelForm userPanelForm;
        int actualIdQuestion;

        public QuizForm(QuestionService questionService, UserPanelForm userPanelForm)
        {
            InitializeComponent();
            this.questionService = questionService;
            this.userPanelForm = userPanelForm;
            actualIdQuestion = questionService.LoadQuestion(questionLabel, answerButton1, answerButton2, answerButton3, answerButton4);
        }

        private void ReturnToUserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            userPanelForm.Visible = true;
        }

        private void NextQuestionPictureBox_Click(object sender, EventArgs e)
        {
            nextQuestionPictureBox.Visible = false;
            answerButton1.BackColor = Color.PapayaWhip;
            answerButton2.BackColor = Color.PapayaWhip;
            answerButton3.BackColor = Color.PapayaWhip;
            answerButton4.BackColor = Color.PapayaWhip;
            actualIdQuestion = questionService.LoadQuestion(questionLabel, answerButton1, answerButton2, answerButton3, answerButton4);
        }

        #region check answer

        private void CheckAnswerButton1_Click(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
            {
                bool status = questionService.CheckAnswer(answerButton1, actualIdQuestion);

                if (status)
                    designService.CorrectQuestion(answerButton1);
                else
                    designService.WrongQuestion(answerButton1);

                nextQuestionPictureBox.Visible = true;
            }
        }

        private void CheckAnswerButton2_Click(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
            {
                bool status = questionService.CheckAnswer(answerButton2, actualIdQuestion);

                if (status)
                    designService.CorrectQuestion(answerButton2);
                else
                    designService.WrongQuestion(answerButton2);

                nextQuestionPictureBox.Visible = true;
            }
        }

        private void CheckAnswerButton3_Click(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
            {
                bool status = questionService.CheckAnswer(answerButton3, actualIdQuestion);

                if (status)
                    designService.CorrectQuestion(answerButton3);
                else
                    designService.WrongQuestion(answerButton3);

                nextQuestionPictureBox.Visible = true;
            }
        }

        private void CheckAnswerButton4_Click(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
            {
                bool status = questionService.CheckAnswer(answerButton4, actualIdQuestion);

                if (status)
                    designService.CorrectQuestion(answerButton4);
                else
                    designService.WrongQuestion(answerButton4);

                nextQuestionPictureBox.Visible = true;
            }
        }

        #endregion check answer

        #region answer:hover

        private void ChangeColorButton1Active_MouseEnter(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
                answerButton1.BackColor = Color.Tan;
        }

        private void ChangeColorButton1Inactive_MouseLeave(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
                answerButton1.BackColor = Color.PapayaWhip;
        }

        private void ChangeColorButton2Active_MouseEnter(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
                answerButton2.BackColor = Color.Tan;
        }

        private void answerButton2_MouseLeave(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
                answerButton2.BackColor = Color.PapayaWhip;
        }

        private void ChangeColorButton3Active_MouseEnter(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
                answerButton3.BackColor = Color.Tan;
        }

        private void answerButton3_MouseLeave(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
                answerButton3.BackColor = Color.PapayaWhip;
        }

        private void ChangeColorButton4Active_MouseEnter(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
                answerButton4.BackColor = Color.Tan;
        }

        private void answerButton4_MouseLeave(object sender, EventArgs e)
        {
            if (nextQuestionPictureBox.Visible == false)
                answerButton4.BackColor = Color.PapayaWhip;
        }

        #endregion answer:hover

    }
}
