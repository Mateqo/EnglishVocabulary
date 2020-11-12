namespace EnglishVocabulary
{
    partial class QuestionsPanelForm
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
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.levelsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apllyFilterButton = new System.Windows.Forms.Button();
            this.removeFilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.questionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.questionsDataGridView.Location = new System.Drawing.Point(189, 77);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.ReadOnly = true;
            this.questionsDataGridView.Size = new System.Drawing.Size(686, 291);
            this.questionsDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Questions";
            // 
            // levelsComboBox
            // 
            this.levelsComboBox.FormattingEnabled = true;
            this.levelsComboBox.Location = new System.Drawing.Point(447, 418);
            this.levelsComboBox.MaxDropDownItems = 5;
            this.levelsComboBox.Name = "levelsComboBox";
            this.levelsComboBox.Size = new System.Drawing.Size(140, 21);
            this.levelsComboBox.TabIndex = 3;
            this.levelsComboBox.Text = "  --- select a level ---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(469, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Level";
            // 
            // apllyFilterButton
            // 
            this.apllyFilterButton.BackColor = System.Drawing.Color.DarkGreen;
            this.apllyFilterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apllyFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apllyFilterButton.ForeColor = System.Drawing.Color.Black;
            this.apllyFilterButton.Location = new System.Drawing.Point(747, 393);
            this.apllyFilterButton.Margin = new System.Windows.Forms.Padding(0);
            this.apllyFilterButton.Name = "apllyFilterButton";
            this.apllyFilterButton.Size = new System.Drawing.Size(128, 46);
            this.apllyFilterButton.TabIndex = 5;
            this.apllyFilterButton.Text = "Apply filter";
            this.apllyFilterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.apllyFilterButton.UseVisualStyleBackColor = false;
            this.apllyFilterButton.Click += new System.EventHandler(this.FilterButtonApply_Click);
            // 
            // removeFilterButton
            // 
            this.removeFilterButton.BackColor = System.Drawing.Color.Maroon;
            this.removeFilterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeFilterButton.ForeColor = System.Drawing.Color.Black;
            this.removeFilterButton.Location = new System.Drawing.Point(747, 456);
            this.removeFilterButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeFilterButton.Name = "removeFilterButton";
            this.removeFilterButton.Size = new System.Drawing.Size(128, 46);
            this.removeFilterButton.TabIndex = 6;
            this.removeFilterButton.Text = "Remove filter";
            this.removeFilterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.removeFilterButton.UseVisualStyleBackColor = false;
            this.removeFilterButton.Visible = false;
            this.removeFilterButton.Click += new System.EventHandler(this.FilterButtonRemove_Click);
            // 
            // QuestionsPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnglishVocabulary.Properties.Resources.panelBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 511);
            this.Controls.Add(this.removeFilterButton);
            this.Controls.Add(this.apllyFilterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.levelsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuestionsPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English vocabulary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnToUserPanel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox levelsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button apllyFilterButton;
        private System.Windows.Forms.Button removeFilterButton;
    }
}