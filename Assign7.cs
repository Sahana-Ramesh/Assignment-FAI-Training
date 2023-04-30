using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    
    class Assign7
    {
        static void Main(string[] args)
        {
            
            UserInput();
        }

        private static void UserInput()
        {
            Retry:
            try
            {
                Console.WriteLine("Enter a number");
                int No = int.Parse(Console.ReadLine());
                bool output = isPrimeNumber(No);
                if (output == true)
                {
                    Console.WriteLine($"{No} is a Prime No");
                }
                else
                {
                    Console.WriteLine($"{No} is not a Prime No");
                }

                UserInput();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                goto Retry;
            }
        }

        static bool isPrimeNumber(int num)
        {
            if(num <= 1)
            {
                return false; //1 & < 1 not prime no
            }

            if(num == 2 || num == 3)
            {
                return true; //2 & 3 are prime numbers
            }

            if (num % 2 == 0)
            {
                return false; //Even No cant be Prime
            }


            int MaxValue = (int)Math.Sqrt(num);

            for (int i = 3; i < MaxValue; i+=2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
