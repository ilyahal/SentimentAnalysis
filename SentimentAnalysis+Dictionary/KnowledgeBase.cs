using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SentimentAnalysis_Dictionary
{

    /// <summary>
    /// База знаний
    /// </summary>
    class KnowledgeBase
    {

        /// <summary>
        /// Ошибка при чтении словаря
        /// </summary>
        public class ReadDictionaryException : Exception
        {

            /// <summary>
            /// Инициализация нового экземпляра класса ReadDictionaryException, используя указанное сообщение об ошибке.
            /// </summary>
            /// <param name="message"></param>
            public ReadDictionaryException(string message) : base(message) { }

        }


        /// <summary>
        /// Инициализация новой базы знаний
        /// </summary>
        public KnowledgeBase()
        {
            Dictionary = GetDictionary();
        }


        /// <summary>
        /// Словарь тональности, где ключ - это слово, а значение - это вес
        /// </summary>
        public Dictionary<string, double> Dictionary { get; private set; }


        /// <summary>
        /// Получение словаря тональности
        /// </summary>
        /// <returns>Словарь</returns>
        private Dictionary<string, double> GetDictionary()
        {
            var dictionaryPath = "dictionary.csv";

            Console.WriteLine("Убедитесь что в папке с программой находится файл " + dictionaryPath);
            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();

            var dictionary = new Dictionary<string, double>();
            try
            {
                using (var streamReader = new StreamReader(dictionaryPath, Encoding.GetEncoding(1251)))
                {
                    var line = string.Empty;

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        line = line.Replace("\"", "");
                        var array = line.Split(';');

                        if (array.Length < 2) { continue; }

                        var word = array[0];
                        try
                        {
                            var weight = Convert.ToDouble(array[1]);
                            dictionary[word] = weight;
                        }
                        catch (FormatException) { continue; }
                        catch (OverflowException) { continue; }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ReadDictionaryException(ex.Message);
            }

            if (dictionary.Count == 0)
            {
                throw new ReadDictionaryException("Словарь пустой.");
            }

            Console.WriteLine();
            Console.WriteLine();

            return dictionary;
        }

    }

}
