
using Mood_Analyzer_Problem;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Mood__Analyzer_Problem
{

    public class MoodAnalyserFactory
    {
        /// <summary>
        /// Creates the mood analyser object.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructorName">Name of the constructor.</param>
        /// <returns></returns>
        /// <exception cref="Mood__Analyzer_Problem.ExceptionTest">
        /// Class Not Found
        /// or
        /// Constructor Not Found
        /// </exception>
        public static object CreateMoodAnalyserObject(string className, [Optional] string constructorName, [Optional] string message)
        {
            Type moodAnalyserType = Type.GetType(className);
            try
            {
                if (moodAnalyserType == null)
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
                if (moodAnalyserType.Name != constructorName)
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.NO_SUCH_CLASS, "Constructor Not Found");
                }
                ConstructorInfo ctor = moodAnalyserType.GetConstructor(new[] { typeof(string) });
                object[] parameters = { message };
                return ctor.Invoke(new object[] { message });
            }
            catch (ExceptionTest ex)
            {
                return ex.Message;
            }
        }
        public override bool Equals(object? obj)
        {
            string className = "Mood_Analyzer_Problem.Mood_Analyzer";
            string constructorName = "Mood_Analyer";
            var xyz = obj as Mood_Analyzer;
            if (!(obj is Mood_Analyzer))
            {
                return false;
            }
            else
            {
                Mood_Analyzer mood = (Mood_Analyzer)obj;
                bool result = (className == constructorName);
                return result;
            }
            //if (xyz == null)
            //{
            //    return false;
            //}
            //if (className != xyz.GetType().Name)
            //{
            //    return false;
            //}
            return true;
        }
        //public override bool Equals(object? obj)
        //{
        //    MoodAnalyserFactory personObj = obj as MoodAnalyserFactory;
        //    if (obj == null)
        //    {
        //        return false;
        //    }
        //    if(
        //    {

        //    }
        //}
    }
}
