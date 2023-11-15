using HalloStandardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNetFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(System.Diagnostics.FileVersionInfo.GetVersionInfo(typeof(int).Assembly.Location).ProductVersion);

            var calc = new Calc();
            var sum = calc.Sum(4, 5);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
