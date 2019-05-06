using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            int n = 0, m = 0;
            Console.WriteLine("Defaule username and password is : username and password\n");
  
            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();
                if (username == "username" && password == "password")
                {
                    m = 1;
                    n = 3;
                }

                else
                {
                    m = 0;
                    n++;
                }
            }
            while ((username != "username" || password != "password")
                    && (n != 3));
            if (m == 0)
            {
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            }
            else
            if (m == 1)
            {
                Console.Write("\nPassword entered successfull!\n\n");
            }
            Console.ReadKey();
        }
    }
}
