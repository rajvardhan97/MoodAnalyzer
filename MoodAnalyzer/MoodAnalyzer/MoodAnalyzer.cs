using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerTestProject
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer()
        {
            this.message = "I am in any mood";
        }
        public string analyzeMood(string message)
        {
            this.message = message;
            if (this.message.Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
        //summary
        //Refactor code to take message through Constructor
        //summary

        public MoodAnalyzer(string Message)
        {
            this.message= "im in happy";
        }
        public string analyzeMood()
        {
            this.message = message;
            try
            {
                if (this.message.Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                return "Happy";
            }
        }
    }
}
