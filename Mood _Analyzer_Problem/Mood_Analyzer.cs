
using Mood__Analyzer_Problem;

namespace Mood_Analyzer_Problem
{
    public class Mood_Analyzer
    {
        string message;
        public Mood_Analyzer() { }
        public Mood_Analyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.EMPTY_MESSAGE, "Mood Should not be Empty");
                }

                bool result1 = message.Contains("Happy", StringComparison.OrdinalIgnoreCase);

                if (result1)
                {
                    return "HAPPY";
                }
                else
                {
                    return "SAD";
                }
            }
            catch(NullReferenceException)
            {
                throw new ExceptionTest(ExceptionTest.ExceptionType.EMPTY_MESSAGE, "Mood Should not be Empty");

            }
        }
    }
}
