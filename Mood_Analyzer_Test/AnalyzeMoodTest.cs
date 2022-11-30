using Mood__Analyzer_Problem;
using Mood_Analyzer_Problem;

namespace Mood_Analyzer_Test
{
    [TestClass]
    public class AnalyzeMoodTest
    {
        // TC - 1.1
        [TestMethod]
        public void Given_Sad_Return_Sad()
        {
            Mood_Analyzer mood = new Mood_Analyzer("I am in Sad Mood");
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Sad".ToUpper(), result);
        }
        // TC - 1.2
        [TestMethod]
        public void Given_Happy_Return_Happy()
        {
            Mood_Analyzer mood = new Mood_Analyzer("I am in Happy Mood");
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Happy".ToUpper(), result);
        }
        // TC-2.1
        [TestMethod]
        public void Given_Null_Return_Happy()
        {
            Mood_Analyzer mood = new Mood_Analyzer(null);
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Happy".ToUpper(), result);
        }
        // TC - 3.1
        [TestMethod]
        public void Given_Null_Throw_MoodAnalserException()
        {
            Mood_Analyzer mood = new Mood_Analyzer(null);
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Mood Should not be Null", result);
        }
        // TC - 3.2
        [TestMethod]
        public void Given_Empty_Throw_MoodAnalserException()
        {
            Mood_Analyzer mood = new Mood_Analyzer("");
            string result = mood.AnalyzeMood();
            Assert.AreEqual("Mood Should not be Empty", result);
        }
        // TC - 4.1
        [TestMethod]
        public void Given_MoodAnalyserClassName_return_MoodAnalyserObject()
        {
            Mood_Analyzer expected = new Mood_Analyzer();
            object actual = MoodAnalyserFactory.CreateMoodAnalyserObject("Mood_Analyzer_Problem.Mood_Analyzer");
            expected.Equals(actual);
        }
        // TC - 4.2
        [TestMethod]
        public void Given_MoodAnalyserClassNameImproper_Throw_Exception()
        {
            object actual = MoodAnalyserFactory.CreateMoodAnalyserObject("Mood_Analyzer_Problem.Mood_Analer");
            Assert.AreEqual("Class Not Found", actual);
        }
        // TC - 4.3
        [TestMethod]
        public void Given_ConstructorNameNotProper_Throw_Exception()
        {
            object actual = MoodAnalyserFactory.CreateMoodAnalyserObject("Mood_Analyzer_Problem.Mood_Analyzer", "Mood_Analyer");

            Assert.AreEqual("Constructor Not Found", actual);
        }
    }
}