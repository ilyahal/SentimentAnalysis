using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NaiveBayesClassifier;

namespace SentimentAnalysis_MachineLearning
{

    public partial class MainForm : Form
    {

        /// <summary>
        /// Классификатор
        /// </summary>
        private Classifier classifier = null;


        public MainForm()
        {
            InitializeComponent();

            configureUI();
        }

        /// <summary>
        /// Настроить UI
        /// </summary>
        private void configureUI()
        {
            analysisGroupBox.Enabled = false;
            infoGroupBox.Enabled = false;
            statisticsGroupBox.Enabled = false;

            cleanButton.Enabled = false;

            resultTitleLabel.Hide();
            resultLabel.ResetText();

            successButton.Enabled = false;
            successButton.Hide();
            failedButton.Enabled = false;
            failedButton.Hide();

            refreshInfo();
            refreshStatistics();
        }

        /// <summary>
        /// Обновление данных в группе "Инфо"
        /// </summary>
        private void refreshInfo()
        {
            var placeholder = "-";

            if (classifier == null)
            {
                typeCountLabel.Text = placeholder;
                allDocsCountLabel.Text = placeholder;
                allWordsCountLabel.Text = placeholder;

                typesListBox.Items.Add(placeholder);
                classDocsCountLabel.Text = placeholder;
                classWordsCountLabel.Text = placeholder;
            }
            else
            {
                typeCountLabel.Text = classifier.Classes.Count.ToString();
                allDocsCountLabel.Text = classifier.DocsCount.ToString();
                allWordsCountLabel.Text = classifier.UniqueWordsCount.ToString();

                var listBoxSelectedIndex = typesListBox.SelectedIndex;

                typesListBox.Items.Clear();
                foreach (var @class in classifier.Classes)
                {
                    typesListBox.Items.Add(Helper.translateStringSentimentType(@class.Name));
                }
                listBoxSelectedIndex = listBoxSelectedIndex < typesListBox.Items.Count ? (listBoxSelectedIndex >= 0 ? listBoxSelectedIndex : 0) : 0;

                typesListBox.SetSelected(listBoxSelectedIndex, true);
            }
        }

        /// <summary>
        /// Обновление данных в группе "Статистика"
        /// </summary>
        private void refreshStatistics()
        {
            testsCountLabel.Text = Statistics.TestsCount.ToString();
            successTestsPercentLabel.Text = Statistics.SuccessTestsPercent.ToString();
            failedTestsPercentLabel.Text = Statistics.FailedTestsPercent.ToString();
        }


        /// <summary>
        /// Кликнута кнопка "Обучить"
        /// </summary>
        /// <param name="sender">Кликнутая кнопка</param>
        private void trainButton_Click(object sender, EventArgs e)
        {
            var trainingForm = new TrainingForm();
            trainingForm.GetClassifierDelegateEvent += TrainingForm_GetClassifier;

            trainingForm.ShowDialog();
        }

        /// <summary>
        /// В списке тональностей выбрано новое значение
        /// </summary>
        private void typesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typesListBox.SelectedIndex < classifier.Classes.Count)
            {
                classDocsCountLabel.Text = classifier.Classes[typesListBox.SelectedIndex].DocsCount.ToString();
                classWordsCountLabel.Text = classifier.Classes[typesListBox.SelectedIndex].WordsCount.ToString();
            }
        }

        /// <summary>
        /// Текст был изменен
        /// </summary>
        private void sourceTextBox_TextChanged(object sender, EventArgs e)
        {
            cleanButton.Enabled = !(sourceTextBox.Text.Length == 0);

            resultTitleLabel.Hide();
            resultLabel.ResetText();

            successButton.Enabled = false;
            successButton.Hide();
            failedButton.Enabled = false;
            failedButton.Hide();

            processButton.Enabled = true;
        }

        /// <summary>
        /// Нажата кнопка "Верная работа"
        /// </summary>
        private void successButton_Click(object sender, EventArgs e)
        {
            successButton.Enabled = false;
            failedButton.Enabled = false;


            Statistics.SuccessTestsCount++;

            refreshStatistics();
        }

        /// <summary>
        /// Нажата кнопка "Неверная тональность"
        /// </summary>
        private void failedButton_Click(object sender, EventArgs e)
        {
            successButton.Enabled = false;
            failedButton.Enabled = false;


            Statistics.FailedTestsCount++;

            refreshStatistics();
        }

        /// <summary>
        /// Нажата кнопка "Очистить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cleanButton_Click(object sender, EventArgs e)
        {
            sourceTextBox.ResetText();
        }

        /// <summary>
        /// Кликнута кнопка "Обработать"
        /// </summary>
        /// <param name="sender">Кликнутая кнопка</param>
        private void processButton_Click(object sender, EventArgs e)
        {
            var words = sourceTextBox.Text.Parse();

            var @class = SentimentType.Unknown;

            var availableClassesNames = classifier.Classes
                .Select(classInfo => classInfo.Name)
                .ToArray();

            var results = availableClassesNames.ToDictionary(className => className, className => words.Select(word => classifier.IsInClassProbability(className, word)));
            if (results.GroupBy(result => result.Value.Sum() / result.Value.Count()).Count() > 1)
            {
                var maxProbabilityClass = results.MaxBy(result => result.Value.Sum() / result.Value.Count());
                @class = Helper.convertStringToSentimentType(maxProbabilityClass.Key);
            }

            var text = string.Empty;
            switch (@class)
            {
                case SentimentType.Positive:
                    text = "Текст имеет позитивную тональность";
                    resultLabel.ForeColor = Color.Green;
                    break;
                case SentimentType.Negative:
                    text = "Текст имеет негативную тональность";
                    resultLabel.ForeColor = Color.Red;
                    break;
                case SentimentType.Neutral:
                    text = "Текст имеет нейтральную тональность.";
                    resultLabel.ForeColor = Color.Yellow;
                    break;

                case SentimentType.Unknown:
                    text = "Для анализа недостаточно данных.";
                    resultLabel.ForeColor = Color.Black;
                    break;
            }

            resultTitleLabel.Show();
            resultLabel.Text = text;

            if (@class != SentimentType.Unknown)
            {
                successButton.Enabled = true;
                successButton.Show();
                failedButton.Enabled = true;
                failedButton.Show();
            }

            processButton.Enabled = false;
        }
        
        /// <summary>
        /// Классификатор был получен
        /// </summary>
        /// <param name="classifier">Созданный классификатор</param>
        void TrainingForm_GetClassifier(Classifier classifier)
        {
            this.classifier = classifier;

            analysisGroupBox.Enabled = true;
            infoGroupBox.Enabled = true;
            statisticsGroupBox.Enabled = true;

            refreshInfo();
        }
        
    }

}
