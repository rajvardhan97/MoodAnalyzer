using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerTestProject
{
    public class CustomException : Exception
    {
        Exceptiontype type;
        public enum Exceptiontype
        {
            EmptyMood,
            EmptyNULL
        }
        public CustomException(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
