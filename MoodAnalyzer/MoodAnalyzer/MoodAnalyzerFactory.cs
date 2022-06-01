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
        // UC 5:Use Reflection to Create MoodAnalyser with Parameter Constructor
        public object MoodAnalyzerParameterisedConstructor(string className, string constructorName)
        {
            Type type = typeof(MoodAnalyzer);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                try
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string[]) });
                    object obj = constructorInfo.Invoke(new object[] { "Im in a mood" });
                    return obj;
                }
                catch
                {
                    throw new CustomException(CustomException.Exceptiontype.NoClass, "No such class");
                }
            }
            else
            {
                throw new CustomException(CustomException.Exceptiontype.NoConstructor, "Constructor Not Found");
            }
        }
        // UC 6:Use Reflection to invoke Method analyseMood
        public string AnalyzeMood(string MethodName, string Message)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzerFactory.MoodAnalyser");
                MoodAnalyzerFactory moodAnalyzerFactory = new MoodAnalyzerFactory();
                Object obj = moodAnalyzerFactory.MoodAnalyzerParameterisedConstructor("MoodAnalyzerFactory.MoodAnalyser", "Happy Mood");
                MethodInfo methodInfo = type.GetMethod(MethodName);
                Object mood = methodInfo.Invoke(obj, null);
                return mood.ToString();
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.Exceptiontype.NoConstructor, "Constructor Not Found");
            }
        }
    }
}