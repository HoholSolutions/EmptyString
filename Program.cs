using System.Text;

namespace EmptyStringProgram
{
    public class EmptyString
    {
        readonly StringType sType;

        public enum StringType
        {
            Empty
        }

        public string ReturnStringType()
        {
            if (sType == StringType.Empty) { return string.Empty; }

            return string.Empty;
        }

        public EmptyString(StringType sArgs)
        {
            sType = sArgs;
        }
    }

    class Program
    {
        static void Main()
        {
            string myEmptyString = new StringBuilder()
                                       .Append(new EmptyString(EmptyString.StringType.Empty)
                                       .ReturnStringType())
                                       .ToString();
        }
    }
}
