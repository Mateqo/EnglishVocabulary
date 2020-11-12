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
        QuestionService questionService;
        UserPanelForm userPanelForm;

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

        private void ReturnToUserPanl_FormClosed(object sender, FormClosedEventArgs e)
        {
            userPanelForm.Visible = true;
        }
    }
}
