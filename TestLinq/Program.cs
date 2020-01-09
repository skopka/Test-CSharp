using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace TestLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program program = new Program();
                program.LinqTest();
            }
            catch (Exception e)
            {
                WriteLine(e);
            }
            finally
            {
                WriteLine($"Press any key for exit");
                ReadKey();
            }
        }

        private void LinqTest()
        {
            var testList = new List<int> { 1, 2, 3 };
            var testLinq = testList.Where(item => item > 2);

            WriteEnumerable(testLinq, "Before adding");

            testList.Add(4);

            WriteEnumerable(testLinq, "After adding");
        }

        private void WriteEnumerable<T>(IEnumerable<T> enumerable, string text)
        {
            WriteLine(text);
            enumerable.ForEach(item => Write($"{item} "));
            WriteLine();
            WriteLine();
        }
    }
}
