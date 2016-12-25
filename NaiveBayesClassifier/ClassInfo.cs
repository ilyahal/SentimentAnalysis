using System.Collections.Generic;
using System.Linq;

namespace NaiveBayesClassifier
{

    /// <summary>
    /// Информация о классе
    /// </summary>
    public class ClassInfo
    {

        /// <summary>
        /// Инициализация нового объекта, хронящего информацию о классе
        /// </summary>
        /// <param name="name">Имя класса</param>
        /// <param name="trainDocs">Документы для тренировки</param>
        public ClassInfo(string name, List<string> trainDocs)
        {
            Name = name;

            var words = trainDocs.SelectMany(trainDoc => trainDoc.Parse());
            WordsCount = words.Count();
            WordCount = words
                .GroupBy(word => word)
                .ToDictionary(group => group.Key, group => group.Count());

            DocsCount = trainDocs.Count;
        }


        /// <summary>
        /// Имя класса
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Количество слов во всех документах класса
        /// </summary>
        public int WordsCount { get; private set; }

        /// <summary>
        /// Количество вхождений каждого слова в тексты документов класса
        /// </summary>
        public Dictionary<string, int> WordCount { get; private set; }

        /// <summary>
        /// Количество изученных документов
        /// </summary>
        public int DocsCount { get; private set; }


        /// <summary>
        /// Получить количества вхождений слова в тексты документов класса
        /// </summary>
        /// <param name="word">Искомое слово</param>
        /// <returns>Количества вхождений слова в текст</returns>
        public int NumberOfOccurencesInTrainDocs(string word)
        {
            if (WordCount.Keys.Contains(word))
            {
                return WordCount[word];
            }

            return 0;
        }

    }

}
