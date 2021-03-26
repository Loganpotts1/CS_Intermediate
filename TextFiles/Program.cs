using System;
using System.IO;

namespace TextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "line 1", "line 2", "line 3..." };

            File.WriteAllLines("C:/Web_Dev/Learning/C#/textFile.txt", lines);
        }
    }
}
