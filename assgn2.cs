using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    
    class assgn2
    {
        
        static Array CreateArray(int size)
        {
            Retry:
            Console.WriteLine("Enter the elements one by one:");
            try
            {
                int[] array = new int[size];
                

                for (int i = 0; i < size; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());

                }

                OddArray(array);
                evenArray(array);


                return array;
            }
            catch (FormatException)
            {

                Console.WriteLine("The entry shld be in valid numeric form");
                goto Retry;
            }


        }

        private static void OddArray(int[] array)
        {
            Console.Write("Odd Numbers: ");

            foreach (int item in array)
            {
                if(item % 2 != 0)
                {
                    Console.Write(item +",");
                }

            }

            Console.WriteLine();

        }

        private static void evenArray(int[] array)
        {
            Console.Write("Even Numbers: ");

            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item+ ",");
                }

            }
        }

        


        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of elements in Array");
            int ArraySize = Convert.ToInt32(Console.ReadLine());
            CreateArray(ArraySize);

        }
    }
}
