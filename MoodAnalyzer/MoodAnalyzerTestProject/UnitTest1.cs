using NUnit.Framework;

namespace MoodAnalyzerTestProject
{
    public class Tests
    {
        MoodAnalyzer analyzer;
        [SetUp]
        public void Setup()
        {
            analyzer = new MoodAnalyzer();        
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
        // TC 1.2: Given "I am  in Any Mood" message Should Return HAPPY.
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
            string message = "I am in Sad Mood";
            MoodAnalyzer moodanalyzer = new MoodAnalyzer(message);

            string expected = "Sad";
            string actual = moodanalyzer.analyzeMood();

            Assert.AreEqual(expected, actual);
        }
        // <summary>
        // Refactor TC 1.2:Given “I am in Happy Mood” message in Constructor Should Return SAD
        // </summary>
        [Test]
        public void GiveMessageInAnyMoodshouldReturnSAD()
        {
            string message = "I am in Happy mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

            string expected = "Sad";
            string actual = moodAnalyzer.analyzeMood();

            Assert.AreEqual(expected, actual);
        }
    }
}