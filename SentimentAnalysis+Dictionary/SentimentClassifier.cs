using System.Collections.Generic;

namespace SentimentAnalysis_Dictionary
{

    /// <summary>
    /// Классификатор тональности
    /// </summary>
    public class SentimentClassifier
    {

        /// <summary>
        /// Тип вида тональности
        /// </summary>
        public enum SentimentType
        {
            /// <summary>
            /// Положительная тональность
            /// </summary>
            Positive,
            /// <summary>
            /// Нейтральная тональность
            /// </summary>
            Neutral,
            /// <summary>
            /// Отрицательная тональность
            /// </summary>
            Negative,

            /// <summary>
            /// Неизвестная тональность
            /// </summary>
            Unknown
        }


        /// <summary>
        /// Вычислить тональность текста
        /// </summary>
        /// <param name="dictionary">Словарь тональности</param>
        /// <param name="words">Слова текста</param>
        /// <returns>Тип тональности</returns>
        public static SentimentType Process(Dictionary<string, double> dictionary, string[] words)
        {
            var count = 0;
            var weight = 0.0;
            foreach (var word in words)
            {
                var value = 0.0;
                if (dictionary.TryGetValue(word, out value))
                {
                    count++;
                    weight += value;
                }
            }

            if (count == 0)
            {
                return SentimentType.Unknown;
            }

            var averageValue = weight / count;

            return averageValue == 0 ? SentimentType.Neutral : averageValue < 0 ? SentimentType.Negative : SentimentType.Positive;
        }

    }

}
