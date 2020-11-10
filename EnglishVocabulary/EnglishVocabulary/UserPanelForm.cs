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
        QuestionsPanelForm questionsPanel = new QuestionsPanelForm();

        public UserPanelForm()
        {
            InitializeComponent();
        }

        public UserPanelForm(Form form)
        {
            InitializeComponent();
            form.Close();
        }

        private void ShowQuestionsLabel_Click(object sender, EventArgs e)
        {
            questionsPanel.ShowDialog();
            this.Visible = false;
        }
    }
}
