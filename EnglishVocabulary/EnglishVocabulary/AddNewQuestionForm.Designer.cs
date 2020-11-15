namespace EnglishVocabulary
{
    partial class AddNewQuestionForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newQuestionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newAnswerTextBox = new System.Windows.Forms.TextBox();
            this.addNewQuestionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newLevelTextBox = new System.Windows.Forms.TextBox();
            this.infoLevelPictureBox = new System.Windows.Forms.PictureBox();
            this.levelToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.infoLevelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(225, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add a question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(185, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Translate the word:";
            // 
            // newQuestionTextBox
            // 
            this.newQuestionTextBox.BackColor = System.Drawing.Color.SandyBrown;
            this.newQuestionTextBox.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuestionTextBox.Location = new System.Drawing.Point(516, 162);
            this.newQuestionTextBox.Name = "newQuestionTextBox";
            this.newQuestionTextBox.Size = new System.Drawing.Size(209, 47);
            this.newQuestionTextBox.TabIndex = 4;
            this.newQuestionTextBox.TabStop = false;
            this.newQuestionTextBox.Text = "czerwony";
            this.newQuestionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newQuestionTextBox.Enter += new System.EventHandler(this.HidePlaceHolderQuestionTextBox_Enter);
            this.newQuestionTextBox.Leave += new System.EventHandler(this.ShowPlaceHolderQuestionTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(185, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Answer:";
            // 
            // newAnswerTextBox
            // 
            this.newAnswerTextBox.BackColor = System.Drawing.Color.SandyBrown;
            this.newAnswerTextBox.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAnswerTextBox.Location = new System.Drawing.Point(331, 236);
            this.newAnswerTextBox.Name = "newAnswerTextBox";
            this.newAnswerTextBox.Size = new System.Drawing.Size(215, 47);
            this.newAnswerTextBox.TabIndex = 6;
            this.newAnswerTextBox.TabStop = false;
            this.newAnswerTextBox.Text = "red";
            this.newAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newAnswerTextBox.Enter += new System.EventHandler(this.HidePlaceHolderAnswerTextBox_Enter);
            this.newAnswerTextBox.Leave += new System.EventHandler(this.ShowPlaceHolderAnswerTextBox_Leave);
            // 
            // addNewQuestionButton
            // 
            this.addNewQuestionButton.BackColor = System.Drawing.Color.DarkGreen;
            this.addNewQuestionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewQuestionButton.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuestionButton.Location = new System.Drawing.Point(331, 409);
            this.addNewQuestionButton.Name = "addNewQuestionButton";
            this.addNewQuestionButton.Size = new System.Drawing.Size(150, 48);
            this.addNewQuestionButton.TabIndex = 7;
            this.addNewQuestionButton.Text = "Add";
            this.addNewQuestionButton.UseVisualStyleBackColor = false;
            this.addNewQuestionButton.Click += new System.EventHandler(this.AddNewQuestionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(180, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Level:";
            // 
            // newLevelTextBox
            // 
            this.newLevelTextBox.BackColor = System.Drawing.Color.SandyBrown;
            this.newLevelTextBox.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLevelTextBox.Location = new System.Drawing.Point(300, 318);
            this.newLevelTextBox.Name = "newLevelTextBox";
            this.newLevelTextBox.Size = new System.Drawing.Size(215, 47);
            this.newLevelTextBox.TabIndex = 9;
            this.newLevelTextBox.TabStop = false;
            this.newLevelTextBox.Text = "easy";
            this.newLevelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newLevelTextBox.Enter += new System.EventHandler(this.HidePlaceHolderLeveTextBox_Enter);
            this.newLevelTextBox.Leave += new System.EventHandler(this.ShowPlaceHolderLevelTextBox_Leave);
            // 
            // infoLevelPictureBox
            // 
            this.infoLevelPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.infoLevelPictureBox.BackgroundImage = global::EnglishVocabulary.Properties.Resources.info;
            this.infoLevelPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoLevelPictureBox.Location = new System.Drawing.Point(516, 318);
            this.infoLevelPictureBox.Name = "infoLevelPictureBox";
            this.infoLevelPictureBox.Size = new System.Drawing.Size(35, 26);
            this.infoLevelPictureBox.TabIndex = 10;
            this.infoLevelPictureBox.TabStop = false;
            this.infoLevelPictureBox.MouseEnter += new System.EventHandler(this.ShowInfoAboutLevelPictureBox_MouseEnter);
            // 
            // AddNewQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnglishVocabulary.Properties.Resources.panelBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 490);
            this.Controls.Add(this.infoLevelPictureBox);
            this.Controls.Add(this.newLevelTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addNewQuestionButton);
            this.Controls.Add(this.newAnswerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newQuestionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English vocabulary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnToUserPanel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.infoLevelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newQuestionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newAnswerTextBox;
        private System.Windows.Forms.Button addNewQuestionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newLevelTextBox;
        private System.Windows.Forms.PictureBox infoLevelPictureBox;
        private System.Windows.Forms.ToolTip levelToolTip;
    }
}