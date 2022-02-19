using System;

namespace TextMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test PascalCase()
            Console.WriteLine("NUMBER OF STUDENTS -->" + UsefulTextUtils.PascalCase("NUMBER OF STUDENTS"));
            // test CheckTimeFormat()
            Console.WriteLine("23:59 --> " + UsefulTextUtils.CheckTimeFormat("23:59"));
        }
    }
}
