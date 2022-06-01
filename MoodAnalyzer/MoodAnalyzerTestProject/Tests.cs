using NUnit.Framework;

namespace MoodAnalyzerTestProject
{
    public class Tests
    {
        MoodAnalyzer analyzer;
        MoodAnalyzerFactory factory;
        MoodAnalyzerFactory moodAnalyzerFactory = new MoodAnalyzerFactory();

        [SetUp]
        public void Setup()
        {
            analyzer = new MoodAnalyzer();
            factory = new MoodAnalyzerFactory();
        }

        // <summary>
        // TC 1.1: Given "I am  in Sad Mood" message Should Return SAD.
        // </summary>
        [Test]
        public void GivenIaminSadMoodReturnSAD()
        {
            string message = "I am in sad mood";
            analyzer = new MoodAnalyzer();

            string expected = "Sad";
            string actual = analyzer.analyzeMood(message);

            Assert.AreEqual(expected, actual);
        }

        // <summary>
        /// TC 1.2: Given "I am  in Any Mood" message Should Return HAPPY.
        // </summary>
        [Test]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            string message = "I am in Any Mood";
            analyzer = new MoodAnalyzer();

            string expected = "Happy";
            string actual = analyzer.analyzeMood(message);

            Assert.AreEqual(expected, actual);
        }

        // <summary>
        // Refactor TC 1.1:Given “I am in Sad Mood” message in Constructor Should Return SAD
        // </summary>
        [Test]
        public void GiveMessageinConstructorandReturnSAD()
        {
            string message = "I am in Sad mood";
            MoodAnalyzer moodanalyzer = new MoodAnalyzer();

            string expected = "Sad";
            string actual = moodanalyzer.analyzeMood(message);

            Assert.AreEqual(expected, actual);
        }
        // <summary>
        // Refactor TC 1.2:Given “I am in Happy Mood” message in Constructor Should Return SAD
        // </summary>
        [Test]
        public void GiveMessageInAnyMoodshouldReturnSAD()
        {
            string message = "I am in Happy mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

            string expected = "Sad";
            string actual = moodAnalyzer.analyzeMood(message);

            Assert.AreEqual(expected, actual);
        }

        // <summary>
        // TC 2.1:Given Null Mood Should Return Happy
        // </summary>
        [Test]
        public void HandleNullExceptionReturnHappy()
        {
            string message = null;
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

            string expected = "Happy";
            string actual = moodAnalyzer.analyzeMood();

            Assert.AreEqual(expected, actual);
        }

        // <summary>
        // TC 3.1:Given NULL Mood Should Throw MoodAnalysisException
        // </summary>
        [Test]
        public void NullMoodShouldThrowCustomException()
        {
            string message = null;
            string expected = "Mood should not be NULL";
            try
            {
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            }
            catch (CustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        // <summary>
        // TC 3.2: Given Empty Mood Should Throw MoodAnalysisException indicating Empty Mood
        // </summary>
        [Test]
        public void EmptyMoodShouldThrowCustomException()
        {
            string message = " ";
            string expected = "Mood should not be Empty";
            try
            {
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            }
            catch (CustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        // <summary>
        // TC 4.1: Given MoodAnalyser Class Name Should Return MoodAnalyser Object
        // </summary>
        [Test]
        public void MoodAnalyzerClassShouldReturnMoodAnalyzerObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            object obj = MoodAnalyzerFactory.MoodAnalyser("MoodAnalyzerFactory.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        // <summary>
        // TC 4.2: Given Class Name When Improper Should Throw MoodAnalysisException
        // </summary>
        [Test]
        public void ClassNameWhenImproperThrowMoodAnalysisException()
        {
            string expected = "No such class";
            try
            {
                object obj = MoodAnalyzerFactory.MoodAnalyser("MoodAnalyzerFactory.MoodAnalyser", "MoodAnalyser");

            }
            catch(CustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        // <summary>
        // TC 4.3: Given Class When Constructor Not Proper Should Throw MoodAnalysisException
        // </summary>
        [Test]
        public void ClassMoodAnalyserWhenConstructorImproperThrowMoodAnalysisException()
        {
            object obj = null;
            string expected = "Constructor Not Found";
            try
            {
                obj = MoodAnalyzerFactory.MoodAnalyser("MoodAnalyzerFactory.MoodAnalyser", "MoodAnalyzer");
            }
            catch(CustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        // <summary>
        // TC 5.1: Given MoodAnalyser When Proper Return MoodAnalyser Object
        // </summary>
        [Test]
        public void MoodAnalyserClass_Should_Return_Object_Using_ParameterisedConstructor()
        {
            object expected = new MoodAnalyzer();
            object obj = moodAnalyzerFactory.MoodAnalyzerParameterisedConstructor("MoodAnalyzerFactory.MoodAnalyzerParameterisedConstructor", "MoodAnalyzerParameterisedConstructor");
            Assert.AreEqual(expected, obj);
        }

        // <summary>
        // TC 5.2: Given Class Name When Improper Should Throw MoodAnalysisException
        // </summary>
        [Test]
        public void MoodAnalyserClass_Improper_ThrowMoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object obj = moodAnalyzerFactory.MoodAnalyzerParameterisedConstructor("MoodAnalyzerFactory.MoodAnalyzerParameterisedConstructor", "MoodAnalyzerParameterisedConstructor");
            }
            catch(CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // <summary>
        // TC 5.3:Given Class When Constructor Not Proper Should Throw MoodAnalysisException
        // </summary>
        [Test]
        public void MoodAnalyzerClass_ConstructorImproper_ThrowMoodAnalysisException()
        {
            string expected = "Constructor Not Found";
            try
            {
                object obj = moodAnalyzerFactory.MoodAnalyzerParameterisedConstructor("MoodAnalyzerFactory.MoodAnalyzerParaneterisedConstructor", "MoodAnalyzerParameterisedConstructor");
            }
            catch(CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // <summary>
        // TC 6.1:Given Happy Message Using Reflection When Proper Should Return HAPPY Mood
        // </summary>
        [Test]
        public void GiveHappyMessage_ReturnHappyMood()
        {
            string expected = "Happy";
            string actual = moodAnalyzerFactory.AnalyzeMood("AnalyzeMood", "Happy");
            Assert.AreEqual(expected, actual);
        }

        // <summary>
        // TC 6.2:Given Happy Message When Improper Method Should Throw MoodAnalysisException
        // </summary>
        [Test]
        public void GiveHappyMessage_WhenImproperMethod_ThrowException()
        {
            string expected = "Constrcutor Not Found";
            try
            {
                string mood = moodAnalyzerFactory.AnalyzeMood("Analyzer", "happy Mood");
            }
            catch(CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}