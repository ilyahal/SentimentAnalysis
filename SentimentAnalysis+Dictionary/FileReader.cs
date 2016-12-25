using System;
using System.Text;
using System.IO;

namespace SentimentAnalysis_Dictionary
{

    /// <summary>
    /// Класс, отвечающий за чтение текста из файла
    /// </summary>
    public static class FileReader
    {

        /// <summary>
        /// Ошибка при чтении текста
        /// </summary>
        public class ReadFileException : Exception
        {
            /// <summary>
            /// Инициализация нового экземпляра класса ReadFileException, используя указанное сообщение об ошибке.
            /// </summary>
            /// <param name="message">Сообщение об ошибке</param>
            public ReadFileException(string message) : base(message) { }
        }


        /// <summary>
        /// Прочитать текст из файла
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        /// <returns>Текст из файла</returns>
        public static FileData ReadText(string filePath)
        {
            var text = string.Empty;

            try
            {
                using (StreamReader streamReader = new StreamReader(filePath, Encoding.GetEncoding(1251)))
                {
                    text = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new ReadFileException(ex.Message);
            }

            return new FileData(text);
        }

    }

}
