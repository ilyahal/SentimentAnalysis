using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NaiveBayesClassifier
{

    /// <summary>
    /// Помощники
    /// </summary>
    static class Helpers
    {

        /// <summary>
        /// Преобразовать текст в список слов
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Список слов исходного текста</returns>
        public static List<string> Parse(this string text)
        {
            //return Regex.Replace(text, @"\p{P}+", "").Split(' ')
            //    .Select(word => word.ToLower())
            //    .ToList();
            return Regex.Matches(text, @"[A-Za-zА-Яа-я\-]+")
                .OfType<Match>()
                .Select(match => match.Value.ToLower())
                .ToList();
        }

    }

}
