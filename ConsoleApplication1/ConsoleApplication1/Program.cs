using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey Yo Mater Trunk");
            Console.Read();

            NewFeatureinMain();
            NewBuginR2();
        }
        static void NewFeatureinMain()
        {
            Console.WriteLine("New Feature in Main");
            Console.Read();
        }
        static void NewBuginR2()
        {
            Console.WriteLine("Release Candidate Bug");
            Console.Read();
        }
    }
}
