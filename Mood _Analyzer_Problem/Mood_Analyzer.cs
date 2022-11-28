
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
            bool result1 = message.Contains("Happy", StringComparison.OrdinalIgnoreCase);

            if (result1)
            {
                return "HAPPY";
            }
            bool result2 = message.Contains("Sad", StringComparison.OrdinalIgnoreCase);

            if (result2)
            {
                return "SAD";
            }
            return "HAPPY";
        }
    }
}
