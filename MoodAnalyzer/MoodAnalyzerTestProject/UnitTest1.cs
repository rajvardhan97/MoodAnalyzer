using NUnit.Framework;

namespace MoodAnalyzerTestProject
{
    public class Tests
    {
        // <summary>
        // TC 1.1: Given "I am  in Sad Mood" message Should Return SAD.
        // </summary>
        [Test]
        public void GivenIaminSadMoodReturnSAD()
        {
            string message = "I am in sad mood";
            MoodAnalyzer analyzer = new MoodAnalyzer();

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
            MoodAnalyzer Analyzer = new MoodAnalyzer();

            string expected = "HAPPY";
            string actual = Analyzer.analyzeMood(message);

            Assert.AreEqual(expected, actual);
        }
    }
}