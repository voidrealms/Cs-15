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
            Wizzard cWizzard = new Wizzard();
            cWizzard.Age = 300;
            
            Console.WriteLine(cWizzard.Age);

            Console.Read();
        }
    }
}
