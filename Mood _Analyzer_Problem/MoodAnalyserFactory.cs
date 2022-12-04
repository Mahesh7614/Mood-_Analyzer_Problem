
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
                if (constructorName != null)
                {
                    if (moodAnalyserType.Name != constructorName)
                    {
                        throw new ExceptionTest(ExceptionTest.ExceptionType.NO_SUCH_CLASS, "Constructor Not Found");
                    }
                }
                if (message != null)
                {
                    ConstructorInfo ctor = moodAnalyserType.GetConstructor(new[] { typeof(string) });
                    object[] parameters = { message };
                    return ctor.Invoke(new object[] { message });
                }
                return moodAnalyserType;
            }
            catch (ExceptionTest ex)
            {
                return ex.Message;
            }
        }
    }
}
