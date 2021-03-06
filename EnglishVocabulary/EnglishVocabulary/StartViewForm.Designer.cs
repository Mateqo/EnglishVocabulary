﻿namespace EnglishVocabulary
{
    partial class StartViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartViewForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.startPictureBox = new System.Windows.Forms.PictureBox();
            this.quitAppPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitAppPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Indigo;
            this.welcomeLabel.Location = new System.Drawing.Point(79, 159);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(593, 38);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Let\'s go Learning English Together";
            // 
            // startPictureBox
            // 
            this.startPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.startPictureBox.BackgroundImage = global::EnglishVocabulary.Properties.Resources.start;
            this.startPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startPictureBox.Location = new System.Drawing.Point(338, 360);
            this.startPictureBox.Name = "startPictureBox";
            this.startPictureBox.Size = new System.Drawing.Size(116, 123);
            this.startPictureBox.TabIndex = 1;
            this.startPictureBox.TabStop = false;
            this.startPictureBox.Click += new System.EventHandler(this.UserPanelPictureBoxStart_Click);
            // 
            // quitAppPictureBox
            // 
            this.quitAppPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.quitAppPictureBox.BackgroundImage = global::EnglishVocabulary.Properties.Resources.quit;
            this.quitAppPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitAppPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitAppPictureBox.Location = new System.Drawing.Point(702, 433);
            this.quitAppPictureBox.Name = "quitAppPictureBox";
            this.quitAppPictureBox.Size = new System.Drawing.Size(70, 66);
            this.quitAppPictureBox.TabIndex = 2;
            this.quitAppPictureBox.TabStop = false;
            this.quitAppPictureBox.Click += new System.EventHandler(this.QuitApp_Click);
            // 
            // StartViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnglishVocabulary.Properties.Resources.startBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.quitAppPictureBox);
            this.Controls.Add(this.startPictureBox);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Vocabulary";
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitAppPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox startPictureBox;
        private System.Windows.Forms.PictureBox quitAppPictureBox;
    }
}

