using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstVSStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Please input your name.");
            String name =Console.ReadLine();
            Console.Out.WriteLine("Please input your age.");
            int age = Int32.Parse(Console.ReadLine());
            Console.Out.WriteLine(name);
            Console.Out.WriteLine(age);
            Console.ReadLine();
        }
    }
}
