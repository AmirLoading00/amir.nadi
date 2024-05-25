using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("hello git");

            for (int i = 0; i <10; i++)
            {
                if (i == 5) Console.WriteLine("hello");

                else if (i == 6) Console.WriteLine("booroo khoonatoon");

            }
            


            Console.ReadKey();
        }
    }
}
