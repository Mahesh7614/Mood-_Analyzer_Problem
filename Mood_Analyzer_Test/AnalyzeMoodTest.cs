using Mood__Analyzer_Problem;
using Mood_Analyzer_Problem;
namespace Mood_Analyzer_Test
{
    [TestClass]
    public class AnalyzeMoodTest
    {
        [TestMethod]
        public void Given_Sad_Return_Sad()
        {
            Mood_Analyzer mood = new Mood_Analyzer("I am in Sad Mood");
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Sad".ToUpper(), result);
        }
        [TestMethod]
        public void Given_Happy_Return_Happy()
        {
            Mood_Analyzer mood = new Mood_Analyzer("I am in Happy Mood");
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Happy".ToUpper(), result);
        }
        [TestMethod]
        public void Given_Null_Return_Happy()
        {
            Mood_Analyzer mood = new Mood_Analyzer(null);
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Happy".ToUpper(), result);
        }
        [TestMethod]
        public void Given_Null_Throw_MoodAnalserException()
        {
            try
            {
                Mood_Analyzer mood = new Mood_Analyzer(null);
                string result = mood.AnalyzeMood();
            }
            catch (ExceptionTest ex)
            {
                Assert.AreEqual("Mood Should not be Null", ex.Message);
            }

        }
        [TestMethod]
        public void Given_Empty_Throw_MoodAnalserException()
        {
            try
            {
                Mood_Analyzer mood = new Mood_Analyzer("");
                string result = mood.AnalyzeMood();
            }
            catch (ExceptionTest ex)
            {
                Assert.AreEqual("Mood Should not be Empty", ex.Message);
            }

        }
    }
}