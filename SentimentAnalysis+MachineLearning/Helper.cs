using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SentimentAnalysis_MachineLearning
{

    /// <summary>
    /// Виды тональности
    /// </summary>
    public enum SentimentType
    {
        /// <summary>
        /// Положительная тональность
        /// </summary>
        Positive,
        /// <summary>
        /// Отрицательная тональность
        /// </summary>
        Negative,
        /// <summary>
        /// Нейтральная тональность
        /// </summary>
        Neutral,

        /// <summary>
        /// Неизвестная тональность
        /// </summary>
        Unknown
    }

    static class Helper
    {

        /// <summary>
        /// Конвертировать вид тональности в строку
        /// </summary>
        /// <param name="type">Тип тональности</param>
        /// <returns>Строковое представление вида тональности</returns>
        public static string convertSentimentTypeToString(SentimentType type)
        {
            switch (type)
            {
                case SentimentType.Positive:
                    return "Positive";
                case SentimentType.Negative:
                    return "Negative";
                case SentimentType.Neutral:
                    return "Neutral";

                case SentimentType.Unknown:
                    return "Unknown";
            }

            return string.Empty;
        }

        /// <summary>
        /// Конвертировать строку в вид тональности
        /// </summary>
        /// <param name="type">Тип тональности</param>
        /// <returns>Результат конвертирования</returns>
        public static SentimentType convertStringToSentimentType(string type)
        {
            if (type == "Positive")
            {
                return SentimentType.Positive;
            }
            else if (type == "Negative")
            {
                return SentimentType.Negative;
            }
            else if (type == "Neutral")
            {
                return SentimentType.Neutral;
            }
            else
            {
                return SentimentType.Unknown;
            }
        }

        public static string translateStringSentimentType(string type)
        {
            if (type == "Positive")
            {
                return "Позитивная";
            }
            else if (type == "Negative")
            {
                return "Негативная";
            }
            else if (type == "Neutral")
            {
                return "Нейтральная";
            }
            else
            {
                return "Неизвестная";
            }
        }


        /// <summary>
        /// Преобразовать текст в список слов
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Список слов исходного текста</returns>
        public static List<string> Parse(this string text)
        {
            return Regex.Matches(text, @"[A-Za-zА-Яа-я\-]+")
                .OfType<Match>()
                .Select(match => match.Value.ToLower())
                .ToList();
        }


        /// <summary>
        /// Получение максимального элемента, удовлетворяющего правилам
        /// </summary>
        /// <param name="en">Перечисление, в котором ищется максимальный элемент</param>
        /// <param name="evaluate">Функция сравнения</param>
        /// <returns>Максимальный элемент</returns>
        public static T MaxBy<T, R>(this IEnumerable<T> en, Func<T, R> evaluate) where R : IComparable<R>
        {
            return en
                .Select(t => new Tuple<T, R>(t, evaluate(t)))
                .Aggregate((max, next) => next.Item2.CompareTo(max.Item2) > 0 ? next : max).Item1;
        }

        /// <summary>
        /// Получение минимального элемента, удовлетворяющего правилам
        /// </summary>
        /// <param name="en">Перечисление, в котором ищется минимальный элемент</param>
        /// <param name="evaluate">Функция сравнения</param>
        /// <returns>Минимальный элемент</returns>
        public static T MinBy<T, R>(this IEnumerable<T> en, Func<T, R> evaluate) where R : IComparable<R>
        {
            return en
                .Select(t => new Tuple<T, R>(t, evaluate(t)))
                .Aggregate((max, next) => next.Item2.CompareTo(max.Item2) < 0 ? next : max).Item1;
        }

    }

}
