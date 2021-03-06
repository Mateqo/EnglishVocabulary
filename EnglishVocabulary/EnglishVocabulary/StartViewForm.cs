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
    public partial class StartViewForm : Form
    {
        UserPanelForm userPanel;

        public StartViewForm()
        {
            InitializeComponent();
        }

        private void UserPanelPictureBoxStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            userPanel = new UserPanelForm(this);
            userPanel.ShowDialog();
        }

        private void QuitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
