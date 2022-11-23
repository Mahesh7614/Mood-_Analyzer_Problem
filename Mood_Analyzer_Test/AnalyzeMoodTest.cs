using Mood_Analyzer_Problem;
namespace Mood_Analyzer_Test
{
    [TestClass]
    public class AnalyzeMoodTest
    {
        [TestMethod]
        public void Given_HappyOrSad_Return_HappyOrSad()
        {
            Mood_Analyzer mood = new Mood_Analyzer();
            string result = mood.AnalyzeMood("Happy");

            Assert.AreEqual("Happy".ToUpper(), result);
        }
        [TestMethod]
        public void Given_Sad_Return_Sad()
        {
            Mood_Analyzer mood = new Mood_Analyzer();
            string result = mood.AnalyzeMood("I am in Sad Mood");

            Assert.AreEqual("Sad".ToUpper(), result);
        }
    }
}