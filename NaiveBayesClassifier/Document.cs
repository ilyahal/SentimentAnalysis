
namespace NaiveBayesClassifier
{

    /// <summary>
    /// Обучающий документ
    /// </summary>
    public class Document
    {

        /// <summary>
        /// Инициализация нового документа, используемого при обучении классификатора
        /// </summary>
        /// <param name="@class">Класс документа</param>
        /// <param name="text">Текст документа</param>
        public Document(string @class, string text)
        {
            Class = @class;
            Text = text;
        }


        /// <summary>
        /// Класс документа
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// Текст документа
        /// </summary>
        public string Text { get; set; }

    }

}
