using System;
using System.IO;

namespace SentimentAnalysis_Dictionary
{

    class Program
    {

        /// <summary>
        /// Получить путь к файлу
        /// </summary>
        /// <returns>Путь к файлу</returns>
        private static string GetFilePath()
        {
            var path = string.Empty;

            var isValidPath = false;
            do
            {
                Console.Write("Укажите путь к Вашему тексту: ");
                path = Console.ReadLine();

                isValidPath = File.Exists(path);
                if (!isValidPath)
                {
                    Console.WriteLine("Не валидный путь к файлу. Попробуйте заново.");
                }
            } while (!isValidPath);

            return path;
        }

        /// <summary>
        /// Продолжить ли выполнение
        /// </summary>
        private static bool IsContinue()
        {
            Console.WriteLine("Проанализировать другой текст? (y/n)");

            var answer = Console.ReadLine();
            answer = answer.ToLower();

            Console.WriteLine();

            return answer.StartsWith("y") || answer.StartsWith("д");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Анализ тональности текста.");
            Console.WriteLine("Подход со словарем.");
            Console.WriteLine();

            // Инициализируем базу знаний
            KnowledgeBase knowledgeBase = null;
            try
            {
                knowledgeBase = new KnowledgeBase();
            }
            catch (KnowledgeBase.ReadDictionaryException ex)
            {
                Console.WriteLine("При чтении словаря возникла ошибка: " + ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }

            do
            {
                // Получаем путь к файлу
                var path = GetFilePath();

                // Получаем данные из файла
                FileData fileData = null;
                try
                {
                    fileData = FileReader.ReadText(path);
                }
                catch (FileReader.ReadFileException ex)
                {
                    Console.WriteLine("При чтении текста возникла ошибка: " + ex.Message);
                    Console.WriteLine();
                    continue;
                }


                // Определяем тональность текста
                var orientation = SentimentClassifier.Process(knowledgeBase.Dictionary, fileData.Words);

                var message = string.Empty;
                switch (orientation)
                {
                    case SentimentClassifier.SentimentType.Unknown:
                        message = "Для анализа недостаточно данных.";
                        break;

                    case SentimentClassifier.SentimentType.Positive:
                        Console.ForegroundColor = ConsoleColor.Green;
                        message = "Текст имеет позитивную тональность.";
                        break;
                    case SentimentClassifier.SentimentType.Neutral:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        message = "Текст имеет нейтральную тональность.";
                        break;
                    case SentimentClassifier.SentimentType.Negative:
                        Console.ForegroundColor = ConsoleColor.Red;
                        message = "Текст имеет негативную тональность.";
                        break;
                }
                Console.WriteLine(message);
                Console.ResetColor();

                Console.WriteLine();
            } while (IsContinue());


            Console.Write("Для закрытия нажмите любую клавишу...");
            Console.ReadKey();
        }

    }

}
