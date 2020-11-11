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
    public partial class QuestionsPanelForm : Form
    {
        QuestionService questionService;
        public QuestionsPanelForm(QuestionService questionService)
        {
            InitializeComponent();
            this.questionService = questionService;

            questionsDataGridView.DataSource = questionService.ShowAllQuestions();
            questionService.ShowAllLevels(levelsComboBox);
        }

        private void FilterButtonApply_Click(object sender, EventArgs e)
        {
            if (levelsComboBox.SelectedIndex != -1)
            {
                questionsDataGridView.DataSource = questionService.ShowQuestionsByLevel(levelsComboBox.SelectedItem.ToString());
                removeFilterButton.Visible = true;
            }
            else
                MessageBox.Show("Please select the level of difficulty");
        }

        private void FilterButtonRemove_Click(object sender, EventArgs e)
        {
            questionsDataGridView.DataSource = questionService.ShowAllQuestions();
            removeFilterButton.Visible = false;
        }
    }
}
