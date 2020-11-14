namespace EnglishVocabulary
{
    partial class UserPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuLabel = new System.Windows.Forms.Label();
            this.completedTasksProgressBar = new System.Windows.Forms.ProgressBar();
            this.startLearningLabel = new System.Windows.Forms.Label();
            this.showQuestionsLabel = new System.Windows.Forms.Label();
            this.removeQuestionLabel = new System.Windows.Forms.Label();
            this.addNewQuestionLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressPercentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.Black;
            this.menuLabel.Location = new System.Drawing.Point(325, 29);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(180, 65);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "Menu";
            // 
            // completedTasksProgressBar
            // 
            this.completedTasksProgressBar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.completedTasksProgressBar.ForeColor = System.Drawing.Color.Green;
            this.completedTasksProgressBar.Location = new System.Drawing.Point(582, 468);
            this.completedTasksProgressBar.Name = "completedTasksProgressBar";
            this.completedTasksProgressBar.Size = new System.Drawing.Size(190, 31);
            this.completedTasksProgressBar.TabIndex = 1;
            // 
            // startLearningLabel
            // 
            this.startLearningLabel.AutoSize = true;
            this.startLearningLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLearningLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startLearningLabel.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLearningLabel.ForeColor = System.Drawing.Color.Black;
            this.startLearningLabel.Location = new System.Drawing.Point(263, 132);
            this.startLearningLabel.Name = "startLearningLabel";
            this.startLearningLabel.Size = new System.Drawing.Size(307, 50);
            this.startLearningLabel.TabIndex = 2;
            this.startLearningLabel.Text = "Start learning";
            // 
            // showQuestionsLabel
            // 
            this.showQuestionsLabel.AutoSize = true;
            this.showQuestionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.showQuestionsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showQuestionsLabel.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showQuestionsLabel.ForeColor = System.Drawing.Color.Black;
            this.showQuestionsLabel.Location = new System.Drawing.Point(263, 211);
            this.showQuestionsLabel.Name = "showQuestionsLabel";
            this.showQuestionsLabel.Size = new System.Drawing.Size(218, 50);
            this.showQuestionsLabel.TabIndex = 3;
            this.showQuestionsLabel.Text = "Questions";
            this.showQuestionsLabel.Click += new System.EventHandler(this.ShowQuestionsLabel_Click);
            // 
            // removeQuestionLabel
            // 
            this.removeQuestionLabel.AutoSize = true;
            this.removeQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.removeQuestionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeQuestionLabel.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeQuestionLabel.ForeColor = System.Drawing.Color.Black;
            this.removeQuestionLabel.Location = new System.Drawing.Point(263, 349);
            this.removeQuestionLabel.Name = "removeQuestionLabel";
            this.removeQuestionLabel.Size = new System.Drawing.Size(178, 50);
            this.removeQuestionLabel.TabIndex = 4;
            this.removeQuestionLabel.Text = "Remove";
            this.removeQuestionLabel.Click += new System.EventHandler(this.RemoveQuestionLabel_Click);
            // 
            // addNewQuestionLabel
            // 
            this.addNewQuestionLabel.AutoSize = true;
            this.addNewQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.addNewQuestionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewQuestionLabel.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuestionLabel.ForeColor = System.Drawing.Color.Black;
            this.addNewQuestionLabel.Location = new System.Drawing.Point(263, 283);
            this.addNewQuestionLabel.Name = "addNewQuestionLabel";
            this.addNewQuestionLabel.Size = new System.Drawing.Size(106, 50);
            this.addNewQuestionLabel.TabIndex = 5;
            this.addNewQuestionLabel.Text = "Add";
            this.addNewQuestionLabel.Click += new System.EventHandler(this.AddNewQuestionLabel_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.progressLabel.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.ForeColor = System.Drawing.Color.Black;
            this.progressLabel.Location = new System.Drawing.Point(576, 424);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(121, 31);
            this.progressLabel.TabIndex = 6;
            this.progressLabel.Text = "Progress";
            // 
            // progressPercentLabel
            // 
            this.progressPercentLabel.AutoSize = true;
            this.progressPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressPercentLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.progressPercentLabel.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPercentLabel.ForeColor = System.Drawing.Color.Black;
            this.progressPercentLabel.Location = new System.Drawing.Point(703, 424);
            this.progressPercentLabel.Name = "progressPercentLabel";
            this.progressPercentLabel.Size = new System.Drawing.Size(51, 31);
            this.progressPercentLabel.TabIndex = 7;
            this.progressPercentLabel.Text = "0 %";
            // 
            // UserPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnglishVocabulary.Properties.Resources.panelBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.progressPercentLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.addNewQuestionLabel);
            this.Controls.Add(this.removeQuestionLabel);
            this.Controls.Add(this.showQuestionsLabel);
            this.Controls.Add(this.startLearningLabel);
            this.Controls.Add(this.completedTasksProgressBar);
            this.Controls.Add(this.menuLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English vocabulary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnToStartView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.ProgressBar completedTasksProgressBar;
        private System.Windows.Forms.Label startLearningLabel;
        private System.Windows.Forms.Label showQuestionsLabel;
        private System.Windows.Forms.Label removeQuestionLabel;
        private System.Windows.Forms.Label addNewQuestionLabel;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label progressPercentLabel;
    }
}