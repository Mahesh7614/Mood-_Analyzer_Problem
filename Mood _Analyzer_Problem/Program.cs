﻿using Mood_Analyzer_Problem;

namespace Mood_Analyzer_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String to check Mood");
            string mood = Console.ReadLine();
            Mood_Analyzer analyzer = new Mood_Analyzer(mood);
            analyzer.AnalyzeMood();
        }
    }
}