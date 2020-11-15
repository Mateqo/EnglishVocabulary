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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.answerButton1 = new System.Windows.Forms.Button();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton4 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.nextQuestionPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nextQuestionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // answerButton1
            // 
            this.answerButton1.BackColor = System.Drawing.Color.PapayaWhip;
            this.answerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerButton1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton1.Location = new System.Drawing.Point(178, 151);
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
            this.answerButton2.Location = new System.Drawing.Point(414, 151);
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
            this.answerButton4.Location = new System.Drawing.Point(414, 274);
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
            this.answerButton3.Location = new System.Drawing.Point(178, 274);
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
            this.label1.Size = new System.Drawing.Size(803, 38);
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
            this.questionLabel.Size = new System.Drawing.Size(803, 38);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "\"przykład\" ";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextQuestionPictureBox
            // 
            this.nextQuestionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.nextQuestionPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextQuestionPictureBox.BackgroundImage")));
            this.nextQuestionPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextQuestionPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextQuestionPictureBox.Location = new System.Drawing.Point(634, 338);
            this.nextQuestionPictureBox.Name = "nextQuestionPictureBox";
            this.nextQuestionPictureBox.Size = new System.Drawing.Size(136, 122);
            this.nextQuestionPictureBox.TabIndex = 6;
            this.nextQuestionPictureBox.TabStop = false;
            this.nextQuestionPictureBox.Visible = false;
            this.nextQuestionPictureBox.Click += new System.EventHandler(this.NextQuestionPictureBox_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnglishVocabulary.Properties.Resources.panelBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.nextQuestionPictureBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerButton3);
            this.Controls.Add(this.answerButton4);
            this.Controls.Add(this.answerButton2);
            this.Controls.Add(this.answerButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English vocabulary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnToUserPanel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nextQuestionPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton4;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.PictureBox nextQuestionPictureBox;
    }
}