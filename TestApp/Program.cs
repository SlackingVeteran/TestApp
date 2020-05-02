using System;
using TestApp.Core.Lib;
using TestApp.Lib;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new Class1();
            Console.WriteLine("Random Int 1: " + class1.GetARandomInt());
            Console.WriteLine("Random Int 2: " + class1.GetARandomInt());
            Console.WriteLine("Random String 1: " + class1.GetARandomString(4));
            Console.WriteLine("Random String 2: " + class1.GetARandomString(6));

            var netCoreTest = new CoreTestClass();
            Console.WriteLine("Random String 2: " + netCoreTest.GetARandomString(6));
        }
    }
}
