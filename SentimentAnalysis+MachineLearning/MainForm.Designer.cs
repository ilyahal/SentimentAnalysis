namespace SentimentAnalysis_MachineLearning
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.trainButton = new System.Windows.Forms.Button();
            this.trainGroupBox = new System.Windows.Forms.GroupBox();
            this.analysisGroupBox = new System.Windows.Forms.GroupBox();
            this.cleanButton = new System.Windows.Forms.Button();
            this.failedButton = new System.Windows.Forms.Button();
            this.successButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTitleLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.typesTitleLabel = new System.Windows.Forms.Label();
            this.classWordsCountLabel = new System.Windows.Forms.Label();
            this.classDocsCountLabel = new System.Windows.Forms.Label();
            this.classWordsCountTitleLabel = new System.Windows.Forms.Label();
            this.classDocsCountTitleLabel = new System.Windows.Forms.Label();
            this.typesListBox = new System.Windows.Forms.ListBox();
            this.allWordsCountLabel = new System.Windows.Forms.Label();
            this.allDocsCountLabel = new System.Windows.Forms.Label();
            this.typeCountLabel = new System.Windows.Forms.Label();
            this.allWordsCountTitleLabel = new System.Windows.Forms.Label();
            this.allDocsCountTitleLabel = new System.Windows.Forms.Label();
            this.typeCountTitleLabel = new System.Windows.Forms.Label();
            this.statisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.failedTestsPercentLabel = new System.Windows.Forms.Label();
            this.successTestsPercentLabel = new System.Windows.Forms.Label();
            this.testsCountLabel = new System.Windows.Forms.Label();
            this.failedTestsPercentTitleLabel = new System.Windows.Forms.Label();
            this.successTestsPercentTitleLabel = new System.Windows.Forms.Label();
            this.testsCountTitleLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.trainGroupBox.SuspendLayout();
            this.analysisGroupBox.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.statisticsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // trainButton
            // 
            this.trainButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainButton.Location = new System.Drawing.Point(6, 21);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(639, 30);
            this.trainButton.TabIndex = 0;
            this.trainButton.Text = "Обучить";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // trainGroupBox
            // 
            this.trainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trainGroupBox.Controls.Add(this.trainButton);
            this.trainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.trainGroupBox.Name = "trainGroupBox";
            this.trainGroupBox.Size = new System.Drawing.Size(651, 67);
            this.trainGroupBox.TabIndex = 1;
            this.trainGroupBox.TabStop = false;
            this.trainGroupBox.Text = "Обучение классификатора";
            // 
            // analysisGroupBox
            // 
            this.analysisGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.analysisGroupBox.Controls.Add(this.cleanButton);
            this.analysisGroupBox.Controls.Add(this.failedButton);
            this.analysisGroupBox.Controls.Add(this.successButton);
            this.analysisGroupBox.Controls.Add(this.resultLabel);
            this.analysisGroupBox.Controls.Add(this.resultTitleLabel);
            this.analysisGroupBox.Controls.Add(this.processButton);
            this.analysisGroupBox.Controls.Add(this.sourceTextBox);
            this.analysisGroupBox.Location = new System.Drawing.Point(12, 85);
            this.analysisGroupBox.Name = "analysisGroupBox";
            this.analysisGroupBox.Size = new System.Drawing.Size(651, 239);
            this.analysisGroupBox.TabIndex = 1;
            this.analysisGroupBox.TabStop = false;
            this.analysisGroupBox.Text = "Анализ";
            // 
            // cleanButton
            // 
            this.cleanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanButton.Location = new System.Drawing.Point(469, 203);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(25, 25);
            this.cleanButton.TabIndex = 6;
            this.cleanButton.Text = "X";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // failedButton
            // 
            this.failedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.failedButton.Image = global::SentimentAnalysis_MachineLearning.Properties.Resources.failed;
            this.failedButton.Location = new System.Drawing.Point(419, 201);
            this.failedButton.Name = "failedButton";
            this.failedButton.Size = new System.Drawing.Size(30, 30);
            this.failedButton.TabIndex = 5;
            this.failedButton.UseVisualStyleBackColor = true;
            this.failedButton.Click += new System.EventHandler(this.failedButton_Click);
            // 
            // successButton
            // 
            this.successButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.successButton.Image = global::SentimentAnalysis_MachineLearning.Properties.Resources.success;
            this.successButton.Location = new System.Drawing.Point(383, 201);
            this.successButton.Name = "successButton";
            this.successButton.Size = new System.Drawing.Size(30, 30);
            this.successButton.TabIndex = 4;
            this.successButton.UseVisualStyleBackColor = true;
            this.successButton.Click += new System.EventHandler(this.successButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(75, 207);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(253, 16);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Результат анализа тональности";
            // 
            // resultTitleLabel
            // 
            this.resultTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resultTitleLabel.AutoSize = true;
            this.resultTitleLabel.Location = new System.Drawing.Point(7, 209);
            this.resultTitleLabel.Name = "resultTitleLabel";
            this.resultTitleLabel.Size = new System.Drawing.Size(62, 13);
            this.resultTitleLabel.TabIndex = 2;
            this.resultTitleLabel.Text = "Результат:";
            // 
            // processButton
            // 
            this.processButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.processButton.Location = new System.Drawing.Point(498, 203);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(132, 25);
            this.processButton.TabIndex = 1;
            this.processButton.Text = "Обработать";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceTextBox.Location = new System.Drawing.Point(7, 20);
            this.sourceTextBox.Multiline = true;
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sourceTextBox.Size = new System.Drawing.Size(638, 174);
            this.sourceTextBox.TabIndex = 0;
            this.sourceTextBox.TextChanged += new System.EventHandler(this.sourceTextBox_TextChanged);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoGroupBox.Controls.Add(this.typesTitleLabel);
            this.infoGroupBox.Controls.Add(this.classWordsCountLabel);
            this.infoGroupBox.Controls.Add(this.classDocsCountLabel);
            this.infoGroupBox.Controls.Add(this.classWordsCountTitleLabel);
            this.infoGroupBox.Controls.Add(this.classDocsCountTitleLabel);
            this.infoGroupBox.Controls.Add(this.typesListBox);
            this.infoGroupBox.Controls.Add(this.allWordsCountLabel);
            this.infoGroupBox.Controls.Add(this.allDocsCountLabel);
            this.infoGroupBox.Controls.Add(this.typeCountLabel);
            this.infoGroupBox.Controls.Add(this.allWordsCountTitleLabel);
            this.infoGroupBox.Controls.Add(this.allDocsCountTitleLabel);
            this.infoGroupBox.Controls.Add(this.typeCountTitleLabel);
            this.infoGroupBox.Location = new System.Drawing.Point(673, 13);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(199, 158);
            this.infoGroupBox.TabIndex = 2;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Информация";
            // 
            // typesTitleLabel
            // 
            this.typesTitleLabel.AutoSize = true;
            this.typesTitleLabel.Location = new System.Drawing.Point(6, 96);
            this.typesTitleLabel.Name = "typesTitleLabel";
            this.typesTitleLabel.Size = new System.Drawing.Size(96, 13);
            this.typesTitleLabel.TabIndex = 11;
            this.typesTitleLabel.Text = "Тип тональности:";
            // 
            // classWordsCountLabel
            // 
            this.classWordsCountLabel.Location = new System.Drawing.Point(139, 134);
            this.classWordsCountLabel.Name = "classWordsCountLabel";
            this.classWordsCountLabel.Size = new System.Drawing.Size(54, 13);
            this.classWordsCountLabel.TabIndex = 10;
            this.classWordsCountLabel.Text = "1000000";
            // 
            // classDocsCountLabel
            // 
            this.classDocsCountLabel.Location = new System.Drawing.Point(139, 117);
            this.classDocsCountLabel.Name = "classDocsCountLabel";
            this.classDocsCountLabel.Size = new System.Drawing.Size(54, 13);
            this.classDocsCountLabel.TabIndex = 9;
            this.classDocsCountLabel.Text = "10000";
            // 
            // classWordsCountTitleLabel
            // 
            this.classWordsCountTitleLabel.AutoSize = true;
            this.classWordsCountTitleLabel.Location = new System.Drawing.Point(7, 134);
            this.classWordsCountTitleLabel.Name = "classWordsCountTitleLabel";
            this.classWordsCountTitleLabel.Size = new System.Drawing.Size(98, 13);
            this.classWordsCountTitleLabel.TabIndex = 8;
            this.classWordsCountTitleLabel.Text = "Обработано слов:";
            // 
            // classDocsCountTitleLabel
            // 
            this.classDocsCountTitleLabel.AutoSize = true;
            this.classDocsCountTitleLabel.Location = new System.Drawing.Point(6, 117);
            this.classDocsCountTitleLabel.Name = "classDocsCountTitleLabel";
            this.classDocsCountTitleLabel.Size = new System.Drawing.Size(115, 13);
            this.classDocsCountTitleLabel.TabIndex = 7;
            this.classDocsCountTitleLabel.Text = "Изучено документов:";
            // 
            // typesListBox
            // 
            this.typesListBox.FormattingEnabled = true;
            this.typesListBox.Location = new System.Drawing.Point(102, 94);
            this.typesListBox.Name = "typesListBox";
            this.typesListBox.Size = new System.Drawing.Size(91, 17);
            this.typesListBox.TabIndex = 6;
            this.typesListBox.SelectedIndexChanged += new System.EventHandler(this.typesListBox_SelectedIndexChanged);
            // 
            // allWordsCountLabel
            // 
            this.allWordsCountLabel.Location = new System.Drawing.Point(139, 54);
            this.allWordsCountLabel.Name = "allWordsCountLabel";
            this.allWordsCountLabel.Size = new System.Drawing.Size(53, 13);
            this.allWordsCountLabel.TabIndex = 5;
            this.allWordsCountLabel.Text = "1000000";
            // 
            // allDocsCountLabel
            // 
            this.allDocsCountLabel.Location = new System.Drawing.Point(139, 37);
            this.allDocsCountLabel.Name = "allDocsCountLabel";
            this.allDocsCountLabel.Size = new System.Drawing.Size(54, 13);
            this.allDocsCountLabel.TabIndex = 4;
            this.allDocsCountLabel.Text = "10000";
            // 
            // typeCountLabel
            // 
            this.typeCountLabel.Location = new System.Drawing.Point(139, 20);
            this.typeCountLabel.Name = "typeCountLabel";
            this.typeCountLabel.Size = new System.Drawing.Size(53, 13);
            this.typeCountLabel.TabIndex = 3;
            this.typeCountLabel.Text = "2";
            // 
            // allWordsCountTitleLabel
            // 
            this.allWordsCountTitleLabel.AutoSize = true;
            this.allWordsCountTitleLabel.Location = new System.Drawing.Point(7, 54);
            this.allWordsCountTitleLabel.Name = "allWordsCountTitleLabel";
            this.allWordsCountTitleLabel.Size = new System.Drawing.Size(79, 13);
            this.allWordsCountTitleLabel.TabIndex = 2;
            this.allWordsCountTitleLabel.Text = "Изучено слов:";
            // 
            // allDocsCountTitleLabel
            // 
            this.allDocsCountTitleLabel.AutoSize = true;
            this.allDocsCountTitleLabel.Location = new System.Drawing.Point(6, 37);
            this.allDocsCountTitleLabel.Name = "allDocsCountTitleLabel";
            this.allDocsCountTitleLabel.Size = new System.Drawing.Size(134, 13);
            this.allDocsCountTitleLabel.TabIndex = 1;
            this.allDocsCountTitleLabel.Text = "Обработано документов:";
            // 
            // typeCountTitleLabel
            // 
            this.typeCountTitleLabel.AutoSize = true;
            this.typeCountTitleLabel.Location = new System.Drawing.Point(6, 20);
            this.typeCountTitleLabel.Name = "typeCountTitleLabel";
            this.typeCountTitleLabel.Size = new System.Drawing.Size(108, 13);
            this.typeCountTitleLabel.TabIndex = 0;
            this.typeCountTitleLabel.Text = "Типов тональности:";
            // 
            // statisticsGroupBox
            // 
            this.statisticsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsGroupBox.Controls.Add(this.failedTestsPercentLabel);
            this.statisticsGroupBox.Controls.Add(this.successTestsPercentLabel);
            this.statisticsGroupBox.Controls.Add(this.testsCountLabel);
            this.statisticsGroupBox.Controls.Add(this.failedTestsPercentTitleLabel);
            this.statisticsGroupBox.Controls.Add(this.successTestsPercentTitleLabel);
            this.statisticsGroupBox.Controls.Add(this.testsCountTitleLabel);
            this.statisticsGroupBox.Location = new System.Drawing.Point(674, 178);
            this.statisticsGroupBox.Name = "statisticsGroupBox";
            this.statisticsGroupBox.Size = new System.Drawing.Size(198, 75);
            this.statisticsGroupBox.TabIndex = 3;
            this.statisticsGroupBox.TabStop = false;
            this.statisticsGroupBox.Text = "Статистика";
            // 
            // failedTestsPercentLabel
            // 
            this.failedTestsPercentLabel.Location = new System.Drawing.Point(139, 54);
            this.failedTestsPercentLabel.Name = "failedTestsPercentLabel";
            this.failedTestsPercentLabel.Size = new System.Drawing.Size(53, 13);
            this.failedTestsPercentLabel.TabIndex = 5;
            this.failedTestsPercentLabel.Text = "100";
            // 
            // successTestsPercentLabel
            // 
            this.successTestsPercentLabel.Location = new System.Drawing.Point(139, 37);
            this.successTestsPercentLabel.Name = "successTestsPercentLabel";
            this.successTestsPercentLabel.Size = new System.Drawing.Size(53, 13);
            this.successTestsPercentLabel.TabIndex = 4;
            this.successTestsPercentLabel.Text = "100";
            // 
            // testsCountLabel
            // 
            this.testsCountLabel.Location = new System.Drawing.Point(139, 20);
            this.testsCountLabel.Name = "testsCountLabel";
            this.testsCountLabel.Size = new System.Drawing.Size(53, 13);
            this.testsCountLabel.TabIndex = 3;
            this.testsCountLabel.Text = "100";
            // 
            // failedTestsPercentTitleLabel
            // 
            this.failedTestsPercentTitleLabel.AutoSize = true;
            this.failedTestsPercentTitleLabel.Location = new System.Drawing.Point(6, 54);
            this.failedTestsPercentTitleLabel.Name = "failedTestsPercentTitleLabel";
            this.failedTestsPercentTitleLabel.Size = new System.Drawing.Size(109, 13);
            this.failedTestsPercentTitleLabel.TabIndex = 2;
            this.failedTestsPercentTitleLabel.Text = "Процент неудачных:";
            // 
            // successTestsPercentTitleLabel
            // 
            this.successTestsPercentTitleLabel.AutoSize = true;
            this.successTestsPercentTitleLabel.Location = new System.Drawing.Point(6, 37);
            this.successTestsPercentTitleLabel.Name = "successTestsPercentTitleLabel";
            this.successTestsPercentTitleLabel.Size = new System.Drawing.Size(106, 13);
            this.successTestsPercentTitleLabel.TabIndex = 1;
            this.successTestsPercentTitleLabel.Text = "Процент успешных:";
            // 
            // testsCountTitleLabel
            // 
            this.testsCountTitleLabel.AutoSize = true;
            this.testsCountTitleLabel.Location = new System.Drawing.Point(6, 20);
            this.testsCountTitleLabel.Name = "testsCountTitleLabel";
            this.testsCountTitleLabel.Size = new System.Drawing.Size(103, 13);
            this.testsCountTitleLabel.TabIndex = 0;
            this.testsCountTitleLabel.Text = "Проведено тестов:";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(740, 275);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(132, 52);
            this.copyrightLabel.TabIndex = 4;
            this.copyrightLabel.Text = "Выполнил студент\r\nРЭУ им. Г. В. Плеханова\r\nгруппы ДКО-142б\r\nХаляпин Илья Игоревич" +
    "";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 336);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.statisticsGroupBox);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.analysisGroupBox);
            this.Controls.Add(this.trainGroupBox);
            this.MinimumSize = new System.Drawing.Size(900, 375);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Анализ тональности текста";
            this.trainGroupBox.ResumeLayout(false);
            this.analysisGroupBox.ResumeLayout(false);
            this.analysisGroupBox.PerformLayout();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.statisticsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.GroupBox trainGroupBox;
        private System.Windows.Forms.GroupBox analysisGroupBox;
        private System.Windows.Forms.Label resultTitleLabel;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label typeCountTitleLabel;
        private System.Windows.Forms.Label allDocsCountTitleLabel;
        private System.Windows.Forms.ListBox typesListBox;
        private System.Windows.Forms.Label allWordsCountLabel;
        private System.Windows.Forms.Label allDocsCountLabel;
        private System.Windows.Forms.Label typeCountLabel;
        private System.Windows.Forms.Label allWordsCountTitleLabel;
        private System.Windows.Forms.Label classDocsCountTitleLabel;
        private System.Windows.Forms.Label typesTitleLabel;
        private System.Windows.Forms.Label classWordsCountLabel;
        private System.Windows.Forms.Label classDocsCountLabel;
        private System.Windows.Forms.Label classWordsCountTitleLabel;
        private System.Windows.Forms.GroupBox statisticsGroupBox;
        private System.Windows.Forms.Label failedTestsPercentLabel;
        private System.Windows.Forms.Label successTestsPercentLabel;
        private System.Windows.Forms.Label testsCountLabel;
        private System.Windows.Forms.Label failedTestsPercentTitleLabel;
        private System.Windows.Forms.Label successTestsPercentTitleLabel;
        private System.Windows.Forms.Label testsCountTitleLabel;
        private System.Windows.Forms.Button successButton;
        private System.Windows.Forms.Button failedButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Label copyrightLabel;
    }
}

