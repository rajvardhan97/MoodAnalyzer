using System;

namespace MoodAnalyzerTestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the message");
            string INPUT = Console.ReadLine();
            string message = INPUT.ToLower();
            MoodAnalyzer analyzer = new MoodAnalyzer();
            Console.WriteLine(analyzer.analyzeMood(message));
        }
    }
}