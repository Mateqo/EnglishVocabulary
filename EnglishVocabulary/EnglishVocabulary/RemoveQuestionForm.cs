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
    public partial class RemoveQuestionForm : Form
    {
        QuestionService questionService;
        UserPanelForm userPanelForm;
        int indexSelectedQuestion;

        public RemoveQuestionForm(QuestionService questionService, UserPanelForm userPanelForm)
        {
            InitializeComponent();
            this.questionService = questionService;
            this.userPanelForm = userPanelForm;
            questionsDataGridView.DataSource = questionService.ShowAllQuestions();
            questionsDataGridView.Columns["IsDeleted"].Visible = false;
            questionsDataGridView.Columns["CreatedDateTime"].Visible = false;
            questionsDataGridView.Columns["DeletedDateTime"].Visible = false;
        }

        private void ShowSelectedQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexSelectedRow = e.RowIndex;
            if (indexSelectedRow != -1)
            {
                DataGridViewRow selectedRow = questionsDataGridView.Rows[indexSelectedRow];
                selectedQuestionLabel.Text = String.Format("[{0}] {1} - {2} ({3})",
                selectedRow.Cells[6].Value.ToString(),
                selectedRow.Cells[0].Value.ToString(),
                selectedRow.Cells[1].Value.ToString(),
                selectedRow.Cells[2].Value.ToString());
                indexSelectedQuestion = Convert.ToInt32(selectedRow.Cells[6].Value);
            }
        }

        private void RemoveQuestionButton_Click(object sender, EventArgs e)
        {
            if (indexSelectedQuestion != 0)
            {
                var result = MessageBox.Show($"Do you want to delete the word with id {indexSelectedQuestion}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    questionService.DeleteQuestionById(indexSelectedQuestion);
                    questionsDataGridView.DataSource = questionService.ShowAllQuestions();
                    questionsDataGridView.CurrentRow.Selected = false;
                    selectedQuestionLabel.Text = "";
                    indexSelectedQuestion = 0;
                }
            }
            else
                MessageBox.Show("Please select a question.","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void UnselectDefault_Load(object sender, EventArgs e)
        {
            questionsDataGridView.CurrentRow.Selected = false;
        }

        private void ReturnToUserPanelPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            userPanelForm.Visible = true;
        }
    }
}
