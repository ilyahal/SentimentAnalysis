using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using NaiveBayesClassifier;

namespace SentimentAnalysis_MachineLearning
{
    
    public partial class TrainingForm : Form
    {

        /// <summary>
        /// Словарь, где ключ - вид тональности, а значение - путь к файлу с примерами текстов данной тональности 
        /// </summary>
        private Dictionary<SentimentType, string> filesNames = new Dictionary<SentimentType, string>();

        /// <summary>
        /// Уведомляет о создании классификатора
        /// </summary>
        /// <param name="classifier">Созданный классификатор</param>
        public delegate void GetClassifierDelegate(Classifier classifier);
        /// <summary>
        /// Событие создания классификатора
        /// </summary>
        public event GetClassifierDelegate GetClassifierDelegateEvent;
        

        public TrainingForm()
        {
            InitializeComponent();

            configureUI();
        }

        /// <summary>
        /// Настроить UI
        /// </summary>
        private void configureUI()
        {
            saveButton.Enabled = false;

            statusLabel.Hide();
        }


        /// <summary>
        /// Кликнута кнопка "Обзор"
        /// </summary>
        /// <param name="sender">Кликнутая кнопка</param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            var @class = SentimentType.Unknown;

            if (sender is Button)
            {
                var button = (Button)sender;

                if (button.Tag is string)
                {
                    var tag = (string)button.Tag;

                    @class = Helper.convertStringToSentimentType(tag);
                }
            }

            if (@class == SentimentType.Unknown)
            {
                return;
            }

            SelectFile(@class);
        }

        /// <summary>
        /// Кликнута кнопка "Сохранить"
        /// </summary>
        /// <param name="sender">Кликнутая кнопка</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
            saveButton.Hide();

            statusLabel.Show();

            Update();


            var docs = new List<Document>();

            foreach (var fileName in filesNames)
            {
                try
                {
                    using (var streamReader = new StreamReader(fileName.Value))
                    {
                        var line = string.Empty;

                        while ((line = streamReader.ReadLine()) != null)
                        {
                            var array = line.Split(';');

                            if (array.Length == 0) { continue; }

                            var @class = Helper.convertSentimentTypeToString(fileName.Key);

                            docs.Add(new Document(@class, array[0]));
                        }
                    }
                }
                catch (Exception ex)
                {
                    saveButton.Enabled = true;
                    saveButton.Show();

                    statusLabel.Hide();


                    MessageBox.Show("При обработке файла произошла ошибка: " + ex.Message);
                    return;
                }
            }

            if (docs.Count == 0)
            {
                saveButton.Enabled = true;
                saveButton.Show();
                
                statusLabel.Hide();


                MessageBox.Show("Не найдено ни одного обучающего текста, выберите другие файлы.");
                return;
            }

            var classifier = new Classifier(docs);
            GetClassifierDelegateEvent(classifier);


            statusLabel.Text = "Готово";

            Update();

            Thread.Sleep(200);
            Close();
        }


        /// <summary>
        /// Выбрать файл
        /// </summary>
        /// <param name="@class">Вид тональности выбираемого файла</param>
        private void SelectFile(SentimentType @class)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы Comma-Separated Value (*.csv) | *.csv";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filesNames[@class] = openFileDialog.FileName;
            }
            else
            {
                filesNames.Remove(@class);
            }

            switch (@class)
            {
                case SentimentType.Positive:
                    if (filesNames.ContainsKey(@class))
                    {
                        positivePathTextBox.Text = filesNames[@class];
                    }
                    else
                    {
                        positivePathTextBox.ResetText();
                    }
                    break;
                case SentimentType.Negative:
                    if (filesNames.ContainsKey(@class))
                    {
                        negativePathTextBox.Text = filesNames[@class];
                    }
                    else
                    {
                        negativePathTextBox.ResetText();
                    }
                    break;
                case SentimentType.Neutral:
                    if (filesNames.ContainsKey(@class))
                    {
                        neutralPathTextBox.Text = filesNames[@class];
                    }
                    else
                    {
                        neutralPathTextBox.ResetText();
                    }
                    break;

                default:
                    break;
            }

            saveButton.Enabled = filesNames.Count != 0;
        }

    }

}
