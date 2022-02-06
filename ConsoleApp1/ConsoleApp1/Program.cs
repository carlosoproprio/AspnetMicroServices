using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new test();
            x = null;
            Console.WriteLine($"Hello World!{x.asd}");
        }

        public class test
        {
                public int asd;
        }
    }
}
