
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

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
        public static object CreateMoodAnalyserObject(string className, [Optional] string constructorName)
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
                return Activator.CreateInstance(moodAnalyserType);
            }
            catch (ExceptionTest ex)
            {
                return ex.Message;
            }
        }
    }
}
