
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static List<string> FileCSV()
        {
            return new List<string>
            {
                "1;Client 1;25",
                "2;Client 2;50",
                "3;Client 3;30"
            };
        }

        static List<string> CustomFile()
        {
            return new List<string>
            {
                "1|Client 1|25",
                "2|Client 2|50",
                "3|Client 3|30"
            };
        }
    }
}
