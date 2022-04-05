using System;

namespace Day20_MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mood analyzer!");
            MoodAnalyzer mood = new MoodAnalyzer(null);
            Console.WriteLine(mood.AnalyzeMood());
        }
    }
}
