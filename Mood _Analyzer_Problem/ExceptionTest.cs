
namespace Mood__Analyzer_Problem
{
    public class ExceptionTest : Exception
    {
        private readonly ExceptionType type;
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
        }
        public ExceptionTest(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
