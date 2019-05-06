using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1, letter2, letter3;

            Console.Write("Input letter1: ");
            letter1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Input letter2: ");
            letter2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Input letter3: ");
            letter3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letter3, letter2, letter1);
            Console.ReadKey();

        }
    }
}
