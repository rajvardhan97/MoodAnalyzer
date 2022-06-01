using System;

namespace MoodAnalyzerTestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using default constructor
            Console.WriteLine("Enter the message");
            string INPUT = Console.ReadLine();
            string message = INPUT.ToLower();
            MoodAnalyzer analyzer = new MoodAnalyzer();
            Console.WriteLine(analyzer.analyzeMood(message));

            //using parametrized constructor
            Console.WriteLine("Enter the message");
            string Input = Console.ReadLine();
            string Message = Input.ToLower();
            MoodAnalyzer Analyzer = new MoodAnalyzer(Message);
            Console.WriteLine(Analyzer.analyzeMood());
            
        }
    }
}