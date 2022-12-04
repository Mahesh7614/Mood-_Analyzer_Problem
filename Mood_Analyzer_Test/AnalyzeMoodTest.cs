using Mood__Analyzer_Problem;
using Mood_Analyzer_Problem;
using Newtonsoft.Json;
using System.Xml.Linq;
using System;

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
            Assert.IsInstanceOfType(expected, (Type)actual);
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
        // TC - 5.1
        [TestMethod]
        public void Given_MoodAnalyserClass_return_MoodAnalyserObject_Using_ParameterizedConstructor()
        {
            object expected = new Mood_Analyzer("Happy");
            string exp = JsonConvert.SerializeObject(expected);
            object actual = MoodAnalyserFactory.CreateMoodAnalyserObject("Mood_Analyzer_Problem.Mood_Analyzer", "Mood_Analyzer", "Happy");
            string act = JsonConvert.SerializeObject(actual);
            Assert.AreEqual(exp, act);
        }
        // TC - 5.2
        [TestMethod]
        public void Given_ClassNameImproper_Throw_Exception_Using_ParameterizedConstructor()
        {
            object actual = MoodAnalyserFactory.CreateMoodAnalyserObject("Mood_Analyzer_Problem.Mood_Analzer", "Mood_Analyzer", "Happy");
            Assert.AreEqual("Class Not Found", actual);
        }
        // TC - 5.3
        [TestMethod]
        public void Given_ConstructorNameImproper_Throw_Exception_Using_ParameterizedConstructor()
        {
            object actual = MoodAnalyserFactory.CreateMoodAnalyserObject("Mood_Analyzer_Problem.Mood_Analyzer", "Mood_Analyer", "Happy");
            Assert.AreEqual("Constructor Not Found", actual);
        }
    }
}