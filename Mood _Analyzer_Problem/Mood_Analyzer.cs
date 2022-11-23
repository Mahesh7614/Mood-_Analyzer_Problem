using System;
using System.Text;

namespace Mood_Analyzer_Problem
{
    public class Mood_Analyzer
    {
        public string AnalyzeMood(string message)
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
            return null;
        }
    }
}
