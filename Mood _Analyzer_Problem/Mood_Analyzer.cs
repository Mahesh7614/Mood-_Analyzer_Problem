
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
            catch
            { 
                return "HAPPY";
            }
        }
    }
}
