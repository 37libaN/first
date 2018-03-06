using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstVSStuff
{
    class TestStuff
    {
        public static void main(String[] args)
        {
            String yes = ",";
            String sentence = "";
            while (yes.Equals(","))
                {
                Console.Out.WriteLine("Write Your Sentence");
                sentence = Console.ReadLine();
                if (sentence.IndexOf(yes) != sentence.Length) {
                    Console.Out.WriteLine("Cool");
                }
                Console.Out.WriteLine("Write Your Sentence");
                yes = Console.ReadLine();
            }
        }
    }
}
