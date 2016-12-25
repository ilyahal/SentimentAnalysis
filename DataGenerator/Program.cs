using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using CsQuery;

namespace DataGenerator
{

    class Program
    {

        /// <summary>
        /// Тип контента
        /// </summary>
        enum ContentType
        {
            /// <summary>
            /// Положительные отзывы
            /// </summary>
            Good,
            /// <summary>
            /// Отрицательные отзывы
            /// </summary>
            Bad,
            /// <summary>
            /// Нейтральные отзывы
            /// </summary>
            Neutral
        }

        /// <summary>
        /// Преобразовать enum значение в строковое
        /// </summary>
        /// <param name="type">Исходное enum значение</param>
        /// <returns>Результат преобразования</returns>
        static string ConvertContentTypeToString(ContentType type)
        {
            switch (type)
            {
                case ContentType.Good:
                    return "good";
                case ContentType.Bad:
                    return "bad";
                case ContentType.Neutral:
                    return "neutral";
            }

            return string.Empty;
        }

        static void Main(string[] args)
        {
            // Цель
            Console.Write("Введите целевое количество рецензий (от 1 до 600): ");
            var targetCountInput = Console.ReadLine();
            var targetCount = Convert.ToInt32(targetCountInput);
            // Рецензий в запросе
            Console.Write("Введите количество рецензий, скачиваемое за раз (от 1 до 200): ");
            var perpageCountInput = Console.ReadLine();
            var perpageCount = Convert.ToInt32(perpageCountInput);

            Console.WriteLine();
            Console.WriteLine();

            // Типы рецензий
            var types = new ContentType[] { ContentType.Good, ContentType.Bad, ContentType.Neutral };
            foreach (var type in types)
            {

                // Конечная коллекция
                var collection = new List<string>();
                for (int i = 1; i <= targetCount / perpageCount; i++)
                {
                    // Номер текущей стриницы
                    var page = i;

                    // Конечный URL
                    var url = "https://www.kinopoisk.ru/reviews/type/comment/status/" + ConvertContentTypeToString(type) + "/period/month/page/" + page.ToString() + "/perpage/" + perpageCount.ToString() + "/";

                    Console.WriteLine(DateTime.Now.ToString() + " Загрузка начата: " + url);

                    var request = WebRequest.Create(url);
                    var response = request.GetResponse();

                    Console.WriteLine(DateTime.Now.ToString() + " Загрузка завершена");

                    using (StreamReader stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1251)))
                    {
                        CQ dom = stream.ReadToEnd();
                        var reachBanners = dom["._reachbanner_"];
                        var texts = reachBanners.Select(reachBanner => reachBanner.InnerText);

                        collection.AddRange(texts);
                    }

                    Console.WriteLine(DateTime.Now.ToString() + " Обработка завершена");
                    Console.WriteLine();
                }

                // Записываем в файл
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ConvertContentTypeToString(type) + "_collection.csv");
                using (var streamWriter = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.ReadWrite), Encoding.UTF8))
                {
                    Console.WriteLine(DateTime.Now.ToString() + " Запись в файл: " + Path.GetFileName(path));

                    foreach (var element in collection)
                    {
                        var line = string.Empty;
                        line += element.Replace("\r", "").Replace("\n", "");
                        line += ";";

                        streamWriter.WriteLine(line);
                    }

                    Console.WriteLine(DateTime.Now.ToString() + " Запись завершена");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Успешно выполнено!");
            Console.ReadKey();
        }

    }

}
