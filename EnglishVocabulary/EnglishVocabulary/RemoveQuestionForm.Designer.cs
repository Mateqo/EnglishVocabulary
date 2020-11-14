namespace EnglishVocabulary
{
    partial class RemoveQuestionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.removeQuestionButton = new System.Windows.Forms.Button();
            this.selectedQuestionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(302, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a question";
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.questionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.questionsDataGridView.Location = new System.Drawing.Point(192, 89);
            this.questionsDataGridView.MultiSelect = false;
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.ReadOnly = true;
            this.questionsDataGridView.Size = new System.Drawing.Size(686, 291);
            this.questionsDataGridView.TabIndex = 4;
            this.questionsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowSelectedQuestion_CellClick);
            // 
            // removeQuestionButton
            // 
            this.removeQuestionButton.BackColor = System.Drawing.Color.Maroon;
            this.removeQuestionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeQuestionButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeQuestionButton.Location = new System.Drawing.Point(192, 462);
            this.removeQuestionButton.Name = "removeQuestionButton";
            this.removeQuestionButton.Size = new System.Drawing.Size(107, 49);
            this.removeQuestionButton.TabIndex = 5;
            this.removeQuestionButton.Text = "Delete";
            this.removeQuestionButton.UseVisualStyleBackColor = false;
            this.removeQuestionButton.Click += new System.EventHandler(this.RemoveQuestionButton_Click);
            // 
            // selectedQuestionLabel
            // 
            this.selectedQuestionLabel.AutoSize = true;
            this.selectedQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectedQuestionLabel.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedQuestionLabel.Location = new System.Drawing.Point(186, 415);
            this.selectedQuestionLabel.Name = "selectedQuestionLabel";
            this.selectedQuestionLabel.Size = new System.Drawing.Size(0, 34);
            this.selectedQuestionLabel.TabIndex = 6;
            // 
            // RemoveQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnglishVocabulary.Properties.Resources.panelBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 531);
            this.Controls.Add(this.selectedQuestionLabel);
            this.Controls.Add(this.removeQuestionButton);
            this.Controls.Add(this.questionsDataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RemoveQuestionForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English vocabulary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnToUserPanel_FormClosed);
            this.Load += new System.EventHandler(this.UnselectDefault_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.Button removeQuestionButton;
        private System.Windows.Forms.Label selectedQuestionLabel;
    }
}