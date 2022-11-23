using Mood_Analyzer_Problem;
namespace Mood_Analyzer_Test
{
    [TestClass]
    public class AnalyzeMoodTest
    {
        [TestMethod]
        public void Given_HappyOrSad_return_HappyOrSad()
        {
            Mood_Analyzer mood = new Mood_Analyzer();
            string result = mood.AnalyzeMood("Happy");

            Assert.AreEqual("Happy".ToUpper(), result);
        }
    }
}