
namespace SentimentAnalysis_MachineLearning
{

    public static class Statistics
    {

        /// <summary>
        /// Количество тестов
        /// </summary>
        public static int TestsCount {
            get
            {
                return SuccessTestsCount + FailedTestsCount;
            }
        }
        /// <summary>
        /// Количество успешных тестов
        /// </summary>
        public static int SuccessTestsCount { get; set; } = 0;
        /// <summary>
        /// Количество неуспешных тестов
        /// </summary>
        public static int FailedTestsCount { get; set; } = 0;

        /// <summary>
        /// Процент успешных тестов
        /// </summary>
        public static double SuccessTestsPercent
        {
            get
            {
                if (SuccessTestsCount == 0)
                {
                    return 0;
                }

                return SuccessTestsCount / (double)TestsCount * 100;
            }
        }
        /// <summary>
        /// Процента неуспешных тестов
        /// </summary>
        public static double FailedTestsPercent
        {
            get
            {
                if (FailedTestsCount == 0)
                {
                    return 0;
                }

                return FailedTestsCount / (double)TestsCount * 100;
            }
        }

    }

}
