namespace EnglishVocabulary
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.answerButton1 = new System.Windows.Forms.Button();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton4 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.nextQuestionPictureBox = new System.Windows.Forms.PictureBox();
            this.veryficationLabel = new System.Windows.Forms.Label();
            this.veryficationPictureBox = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.answerTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.completedTasksProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressPercentLabel = new System.Windows.Forms.Label();
            this.ReturnToUserPanelPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nextQuestionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veryficationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnToUserPanelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // answerButton1
            // 
            this.answerButton1.BackColor = System.Drawing.Color.PapayaWhip;
            this.answerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerButton1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton1.Location = new System.Drawing.Point(178, 110);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(188, 74);
            this.answerButton1.TabIndex = 0;
            this.answerButton1.TabStop = false;
            this.answerButton1.Text = "example";
            this.answerButton1.UseVisualStyleBackColor = false;
            this.answerButton1.Click += new System.EventHandler(this.CheckAnswerButton1_Click);
            this.answerButton1.MouseEnter += new System.EventHandler(this.ChangeColorButton1Active_MouseEnter);
            this.answerButton1.MouseLeave += new System.EventHandler(this.ChangeColorButton1Inactive_MouseLeave);
            // 
            // answerButton2
            // 
            this.answerButton2.BackColor = System.Drawing.Color.PapayaWhip;
            this.answerButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerButton2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton2.Location = new System.Drawing.Point(414, 110);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(188, 74);
            this.answerButton2.TabIndex = 1;
            this.answerButton2.TabStop = false;
            this.answerButton2.Text = "example";
            this.answerButton2.UseVisualStyleBackColor = false;
            this.answerButton2.Click += new System.EventHandler(this.CheckAnswerButton2_Click);
            this.answerButton2.MouseEnter += new System.EventHandler(this.ChangeColorButton2Active_MouseEnter);
            this.answerButton2.MouseLeave += new System.EventHandler(this.answerButton2_MouseLeave);
            // 
            // answerButton4
            // 
            this.answerButton4.BackColor = System.Drawing.Color.PapayaWhip;
            this.answerButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerButton4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton4.Location = new System.Drawing.Point(414, 205);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(188, 74);
            this.answerButton4.TabIndex = 2;
            this.answerButton4.TabStop = false;
            this.answerButton4.Text = "example";
            this.answerButton4.UseVisualStyleBackColor = false;
            this.answerButton4.Click += new System.EventHandler(this.CheckAnswerButton4_Click);
            this.answerButton4.MouseEnter += new System.EventHandler(this.ChangeColorButton4Active_MouseEnter);
            this.answerButton4.MouseLeave += new System.EventHandler(this.answerButton4_MouseLeave);
            // 
            // answerButton3
            // 
            this.answerButton3.BackColor = System.Drawing.Color.PapayaWhip;
            this.answerButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerButton3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton3.Location = new System.Drawing.Point(178, 205);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(188, 74);
            this.answerButton3.TabIndex = 3;
            this.answerButton3.TabStop = false;
            this.answerButton3.Text = "example";
            this.answerButton3.UseVisualStyleBackColor = false;
            this.answerButton3.Click += new System.EventHandler(this.CheckAnswerButton3_Click);
            this.answerButton3.MouseEnter += new System.EventHandler(this.ChangeColorButton3Active_MouseEnter);
            this.answerButton3.MouseLeave += new System.EventHandler(this.answerButton3_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "How do you translate?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionLabel.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.questionLabel.Location = new System.Drawing.Point(0, 38);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(788, 38);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "\"przykład\" ";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextQuestionPictureBox
            // 
            this.nextQuestionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.nextQuestionPictureBox.BackgroundImage = global::EnglishVocabulary.Properties.Resources.next;
            this.nextQuestionPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextQuestionPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextQuestionPictureBox.Location = new System.Drawing.Point(622, 159);
            this.nextQuestionPictureBox.Name = "nextQuestionPictureBox";
            this.nextQuestionPictureBox.Size = new System.Drawing.Size(120, 89);
            this.nextQuestionPictureBox.TabIndex = 6;
            this.nextQuestionPictureBox.TabStop = false;
            this.nextQuestionPictureBox.Visible = false;
            this.nextQuestionPictureBox.Click += new System.EventHandler(this.NextQuestionPictureBox_Click);
            // 
            // veryficationLabel
            // 
            this.veryficationLabel.AutoSize = true;
            this.veryficationLabel.BackColor = System.Drawing.Color.Transparent;
            this.veryficationLabel.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veryficationLabel.ForeColor = System.Drawing.Color.Black;
            this.veryficationLabel.Location = new System.Drawing.Point(210, 297);
            this.veryficationLabel.Name = "veryficationLabel";
            this.veryficationLabel.Size = new System.Drawing.Size(238, 36);
            this.veryficationLabel.TabIndex = 7;
            this.veryficationLabel.Text = "Correct answer";
            this.veryficationLabel.Visible = false;
            // 
            // veryficationPictureBox
            // 
            this.veryficationPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.veryficationPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.veryficationPictureBox.Location = new System.Drawing.Point(454, 285);
            this.veryficationPictureBox.Name = "veryficationPictureBox";
            this.veryficationPictureBox.Size = new System.Drawing.Size(78, 61);
            this.veryficationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.veryficationPictureBox.TabIndex = 8;
            this.veryficationPictureBox.TabStop = false;
            this.veryficationPictureBox.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLabel.Location = new System.Drawing.Point(372, 370);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(35, 38);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "9";
            // 
            // answerTimer
            // 
            this.answerTimer.Interval = 1000;
            this.answerTimer.Tick += new System.EventHandler(this.AnswerTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EnglishVocabulary.Properties.Resources.clock;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(343, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 80);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // completedTasksProgressBar
            // 
            this.completedTasksProgressBar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.completedTasksProgressBar.ForeColor = System.Drawing.Color.Green;
            this.completedTasksProgressBar.Location = new System.Drawing.Point(586, 407);
            this.completedTasksProgressBar.Name = "completedTasksProgressBar";
            this.completedTasksProgressBar.Size = new System.Drawing.Size(190, 31);
            this.completedTasksProgressBar.Step = 1;
            this.completedTasksProgressBar.TabIndex = 11;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.progressLabel.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.ForeColor = System.Drawing.Color.Black;
            this.progressLabel.Location = new System.Drawing.Point(580, 370);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(129, 31);
            this.progressLabel.TabIndex = 12;
            this.progressLabel.Text = "Progress:";
            // 
            // progressPercentLabel
            // 
            this.progressPercentLabel.AutoSize = true;
            this.progressPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressPercentLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.progressPercentLabel.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPercentLabel.ForeColor = System.Drawing.Color.Black;
            this.progressPercentLabel.Location = new System.Drawing.Point(707, 373);
            this.progressPercentLabel.Name = "progressPercentLabel";
            this.progressPercentLabel.Size = new System.Drawing.Size(51, 31);
            this.progressPercentLabel.TabIndex = 13;
            this.progressPercentLabel.Text = "0 %";
            // 
            // ReturnToUserPanelPictureBox
            // 
            this.ReturnToUserPanelPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ReturnToUserPanelPictureBox.BackgroundImage = global::EnglishVocabulary.Properties.Resources.home;
            this.ReturnToUserPanelPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnToUserPanelPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnToUserPanelPictureBox.Location = new System.Drawing.Point(699, 0);
            this.ReturnToUserPanelPictureBox.Name = "ReturnToUserPanelPictureBox";
            this.ReturnToUserPanelPictureBox.Size = new System.Drawing.Size(77, 64);
            this.ReturnToUserPanelPictureBox.TabIndex = 14;
            this.ReturnToUserPanelPictureBox.TabStop = false;
            this.ReturnToUserPanelPictureBox.Click += new System.EventHandler(this.ReturnToUserPanelPictureBox_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnglishVocabulary.Properties.Resources.panelBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.ReturnToUserPanelPictureBox);
            this.Controls.Add(this.progressPercentLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.completedTasksProgressBar);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.veryficationPictureBox);
            this.Controls.Add(this.veryficationLabel);
            this.Controls.Add(this.nextQuestionPictureBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerButton3);
            this.Controls.Add(this.answerButton4);
            this.Controls.Add(this.answerButton2);
            this.Controls.Add(this.answerButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English vocabulary";
            ((System.ComponentModel.ISupportInitialize)(this.nextQuestionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veryficationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnToUserPanelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton4;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.PictureBox nextQuestionPictureBox;
        private System.Windows.Forms.Label veryficationLabel;
        private System.Windows.Forms.PictureBox veryficationPictureBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer answerTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar completedTasksProgressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label progressPercentLabel;
        private System.Windows.Forms.PictureBox ReturnToUserPanelPictureBox;
    }
}