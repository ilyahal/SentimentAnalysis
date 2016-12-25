using System.Linq;
using System.Text.RegularExpressions;

namespace SentimentAnalysis_Dictionary
{

    /// <summary>
    /// Данные файла
    /// </summary>
    public class FileData
    {

        /// <summary>
        /// Инициализация нового экземпляра класса, хранящего данные файла
        /// </summary>
        /// <param name="text">Текст файла</param>
        public FileData(string text)
        {
            Text = text;
        }


        /// <summary>
        /// Текст файла
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Слова текста
        /// </summary>
        public string[] Words
        {
            get
            {
                return ParseText();
            }
        }


        /// <summary>
        /// Распарсить текст
        /// </summary>
        /// <returns>Массив слов текста</returns>
        private string[] ParseText()
        {
            var words = Regex.Matches(Text, @"[А-Яа-я\-]+")
                .OfType<Match>()
                .Select(match => match.Value.ToLower())
                .ToArray();

            return words;
        }

    }

}
