using System;
using System.Collections.Generic;
using System.Linq;

namespace NaiveBayesClassifier
{

    /// <summary>
    /// Классификатор
    /// </summary>
    public class Classifier
    {

        /// <summary>
        /// Инициализация нового классификатора
        /// </summary>
        /// <param name="train">Документы для обучения классификатора</param>
        public Classifier(List<Document> train)
        {
            DocsCount = train.Count;
            UniqueWordsCount = train
                .SelectMany(document => document.Text.Split(' ').Select(word => word.ToLower()))
                .GroupBy(word => word)
                .Count();

            Classes = train
                .GroupBy(document => document.Class)
                .Select(group => new ClassInfo(group.Key, group.Select(document => document.Text).ToList()))
                .ToList();
        }


        /// <summary>
        /// Общее количество изученных документов
        /// </summary>
        public int DocsCount { get; private set; }

        /// <summary>
        /// Количество уникальных слов в текстах всех документов
        /// </summary>
        public int UniqueWordsCount { get; private set; }

        /// <summary>
        /// Список классов
        /// </summary>
        public List<ClassInfo> Classes { get; private set; }


        /// <summary>
        /// Вычислить вероятность нахождения текста в классе
        /// </summary>
        /// <param name="className">Имя класса, в котором вычисляется вероятность нахождения документа</param>
        /// <param name="text">Текст</param>
        /// <returns>Вероятность нахождения текста в классе</returns>
        public double IsInClassProbability(string className, string text)
        {
            var words = text.Parse();

            var classResults = Classes
                .Select(classInfo => new {
                    Result = CalculateProbability(classInfo.DocsCount, DocsCount, words, classInfo, classInfo.WordsCount, UniqueWordsCount),
                    ClassName = classInfo.Name
                })
                .ToArray();

            for (int i = 0; i < classResults.Length; i++)
            {
                if (classResults[i].Result.Equals(double.NaN))
                {
                    classResults[i] = new { Result = 0.0, ClassName = classResults[i].ClassName };
                }
            }
            

            var probability = classResults.Single(classResult => classResult.ClassName == className).Result / classResults.Sum(x => x.Result);
            probability = probability.Equals(double.NaN) ? 0 : probability;
            
            return probability;
        }

        /// <summary>
        /// Вычислить вероятность отношения n-грамма к классу
        /// </summary>
        /// <param name="classDocsCount">Количество изученных документов определенного класса</param>
        /// <param name="totalDocsCount">Общее количество изученных документов</param>
        /// <param name="words">Слова анализируемого текста</param>
        /// <param name="@class">Информация о классе</param>
        /// <param name="classWordsCount">Общее количество слов определенного класса, учавствовавших в обучении</param>
        /// <param name="uniqueWordsCount">Количество уникальных слов, учавствоваших в обучении</param>
        /// <returns>Результат промежуточных вычислений</returns>
        private static double CalculateProbability(double classDocsCount, double totalDocsCount, List<string> words, ClassInfo @class, double classWordsCount, double uniqueWordsCount)
        {
            // return classDocsCount / totalDocsCount * words.Sum(word => (@class.NumberOfOccurencesInTrainDocs(word) + 1) / (classWordsCount + uniqueWordsCount));
            return Math.Pow(Math.E, Math.Log(classDocsCount / totalDocsCount) + words.Sum(word => Math.Log((@class.NumberOfOccurencesInTrainDocs(word) + 1) / (classWordsCount + uniqueWordsCount))));
        }

    }

}
