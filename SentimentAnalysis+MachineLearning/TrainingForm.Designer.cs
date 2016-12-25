namespace SentimentAnalysis_MachineLearning
{
    partial class TrainingForm
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
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.neutralOpenButton = new System.Windows.Forms.Button();
            this.neutralPathTextBox = new System.Windows.Forms.TextBox();
            this.neutralTitleLabel = new System.Windows.Forms.Label();
            this.negativeOpenButton = new System.Windows.Forms.Button();
            this.negativePathTextBox = new System.Windows.Forms.TextBox();
            this.negativeTitleLabel = new System.Windows.Forms.Label();
            this.positiveOpenButton = new System.Windows.Forms.Button();
            this.positivePathTextBox = new System.Windows.Forms.TextBox();
            this.positiveTitleLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.filesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesGroupBox.Controls.Add(this.neutralOpenButton);
            this.filesGroupBox.Controls.Add(this.neutralPathTextBox);
            this.filesGroupBox.Controls.Add(this.neutralTitleLabel);
            this.filesGroupBox.Controls.Add(this.negativeOpenButton);
            this.filesGroupBox.Controls.Add(this.negativePathTextBox);
            this.filesGroupBox.Controls.Add(this.negativeTitleLabel);
            this.filesGroupBox.Controls.Add(this.positiveOpenButton);
            this.filesGroupBox.Controls.Add(this.positivePathTextBox);
            this.filesGroupBox.Controls.Add(this.positiveTitleLabel);
            this.filesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(540, 161);
            this.filesGroupBox.TabIndex = 2;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "Файлы с примерами текстов различных тональных оценок";
            // 
            // neutralOpenButton
            // 
            this.neutralOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.neutralOpenButton.Location = new System.Drawing.Point(457, 120);
            this.neutralOpenButton.Name = "neutralOpenButton";
            this.neutralOpenButton.Size = new System.Drawing.Size(75, 23);
            this.neutralOpenButton.TabIndex = 8;
            this.neutralOpenButton.Tag = "Neutral";
            this.neutralOpenButton.Text = "Обзор";
            this.neutralOpenButton.UseVisualStyleBackColor = true;
            this.neutralOpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // neutralPathTextBox
            // 
            this.neutralPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neutralPathTextBox.Enabled = false;
            this.neutralPathTextBox.Location = new System.Drawing.Point(9, 122);
            this.neutralPathTextBox.Name = "neutralPathTextBox";
            this.neutralPathTextBox.ReadOnly = true;
            this.neutralPathTextBox.Size = new System.Drawing.Size(442, 20);
            this.neutralPathTextBox.TabIndex = 7;
            // 
            // neutralTitleLabel
            // 
            this.neutralTitleLabel.AutoSize = true;
            this.neutralTitleLabel.Location = new System.Drawing.Point(6, 106);
            this.neutralTitleLabel.Name = "neutralTitleLabel";
            this.neutralTitleLabel.Size = new System.Drawing.Size(77, 13);
            this.neutralTitleLabel.TabIndex = 6;
            this.neutralTitleLabel.Text = "Нейтральная:";
            // 
            // negativeOpenButton
            // 
            this.negativeOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.negativeOpenButton.Location = new System.Drawing.Point(457, 77);
            this.negativeOpenButton.Name = "negativeOpenButton";
            this.negativeOpenButton.Size = new System.Drawing.Size(75, 23);
            this.negativeOpenButton.TabIndex = 5;
            this.negativeOpenButton.Tag = "Negative";
            this.negativeOpenButton.Text = "Обзор";
            this.negativeOpenButton.UseVisualStyleBackColor = true;
            this.negativeOpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // negativePathTextBox
            // 
            this.negativePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.negativePathTextBox.Enabled = false;
            this.negativePathTextBox.Location = new System.Drawing.Point(9, 79);
            this.negativePathTextBox.Name = "negativePathTextBox";
            this.negativePathTextBox.ReadOnly = true;
            this.negativePathTextBox.Size = new System.Drawing.Size(442, 20);
            this.negativePathTextBox.TabIndex = 4;
            // 
            // negativeTitleLabel
            // 
            this.negativeTitleLabel.AutoSize = true;
            this.negativeTitleLabel.Location = new System.Drawing.Point(6, 63);
            this.negativeTitleLabel.Name = "negativeTitleLabel";
            this.negativeTitleLabel.Size = new System.Drawing.Size(70, 13);
            this.negativeTitleLabel.TabIndex = 3;
            this.negativeTitleLabel.Text = "Негативная:";
            // 
            // positiveOpenButton
            // 
            this.positiveOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.positiveOpenButton.Location = new System.Drawing.Point(457, 34);
            this.positiveOpenButton.Name = "positiveOpenButton";
            this.positiveOpenButton.Size = new System.Drawing.Size(75, 23);
            this.positiveOpenButton.TabIndex = 2;
            this.positiveOpenButton.Tag = "Positive";
            this.positiveOpenButton.Text = "Обзор";
            this.positiveOpenButton.UseVisualStyleBackColor = true;
            this.positiveOpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // positivePathTextBox
            // 
            this.positivePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positivePathTextBox.Enabled = false;
            this.positivePathTextBox.Location = new System.Drawing.Point(9, 36);
            this.positivePathTextBox.Name = "positivePathTextBox";
            this.positivePathTextBox.ReadOnly = true;
            this.positivePathTextBox.Size = new System.Drawing.Size(442, 20);
            this.positivePathTextBox.TabIndex = 1;
            // 
            // positiveTitleLabel
            // 
            this.positiveTitleLabel.AutoSize = true;
            this.positiveTitleLabel.Location = new System.Drawing.Point(6, 20);
            this.positiveTitleLabel.Name = "positiveTitleLabel";
            this.positiveTitleLabel.Size = new System.Drawing.Size(71, 13);
            this.positiveTitleLabel.TabIndex = 0;
            this.positiveTitleLabel.Text = "Позитивная:";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(230, 179);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(248, 188);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(68, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Обработка..";
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 216);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.filesGroupBox);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainingForm";
            this.ShowIcon = false;
            this.Text = "Обучение классификатора";
            this.filesGroupBox.ResumeLayout(false);
            this.filesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.Button neutralOpenButton;
        private System.Windows.Forms.TextBox neutralPathTextBox;
        private System.Windows.Forms.Label neutralTitleLabel;
        private System.Windows.Forms.Button negativeOpenButton;
        private System.Windows.Forms.TextBox negativePathTextBox;
        private System.Windows.Forms.Label negativeTitleLabel;
        private System.Windows.Forms.Button positiveOpenButton;
        private System.Windows.Forms.TextBox positivePathTextBox;
        private System.Windows.Forms.Label positiveTitleLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label statusLabel;
    }
}