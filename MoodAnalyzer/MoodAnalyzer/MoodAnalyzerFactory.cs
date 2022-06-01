using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace MoodAnalyzerTestProject
{
    public class MoodAnalyzerFactory
    {
        // UC 4: Use Reflection to Create MoodAnalyser with default Constructor
        public static object MoodAnalyser(string ClassName, string ConstructorName)
        {
            string pattern = @"." + ConstructorName + "$";
            Regex regex = new Regex(pattern);
            if (regex.Match(ClassName).Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type type = assembly.GetType(ClassName);
                    return Activator.CreateInstance(type);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.Exceptiontype.NoClass, "No such class");
                }
            }
            else
            {
                throw new CustomException(CustomException.Exceptiontype.NoConstructor, "Constructor Not Found");
            }
        }
    }
}