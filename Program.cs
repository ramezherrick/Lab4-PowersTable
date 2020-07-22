using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Lab6_PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 0; int square = 0; int cube = 0;

            string cont = "y";

            while (cont == "y")
            {

                int input = GetNumber("Enter a number");

                Console.WriteLine($"number  square  cube");

                for (int i = 0; i <= input; i++)
                {
                    number = i;
                    square = squareMethod(i);
                    cube = CubeMethod(i);

                    Console.WriteLine($"{number} \t {square}\t{cube}");
                }

                cont = Continue("Continue? (y/n)");
               
                if (cont == "n") break;
            }
        }
        public static int squareMethod(int num)
        {
            num = (int) Math.Pow(num, 2);
            return num;
        }
        public static int CubeMethod(int num)
        {
            num = (int) Math.Pow(num,3);
            return num;
        }
        public static int GetNumber (string message)
        {
            Console.Write(message);
            int number_1;

            while (!int.TryParse(Console.ReadLine(), out number_1))
            {
                Console.WriteLine("invalid try again");
            }
            return number_1;
        }
        public static string Continue (string message)
        {
            string cont;
            Console.WriteLine(message);
            cont = Console.ReadLine();
            return cont.ToLower();
        }
    }
}

