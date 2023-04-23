using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    using SampleConApp;
    class Assgn6
    {

        static bool isValidDate(int year, int month, int day)
        {
            // do stuff here
            if (year < 1 || year > 9999)
                return false;

            if (month < 1 || month > 12)
                return false;
               
            if (year < 1 || year > 9999)
                return false;

            int MaxDaysInMonth = DateTime.DaysInMonth(year, month);
            if (day < 1 || day > MaxDaysInMonth)
                return false;

            return true;

        }
        static void Main(string[] args)
        {
            userInput();
        }

        private static void userInput()
        {
        RETRY:
            try
            {

                int day = UIConsole.GetNumber("Enter the day");
                int month = UIConsole.GetNumber("Enter the month");
                int year = UIConsole.GetNumber("Enter the year");
                
                bool result = isValidDate(year, month, day);

                if (result == true)
                {
                    Console.WriteLine("Entered Date is Valid");
                }
                else
                {
                    Console.WriteLine("Entered Date is InValid");

                }

                userInput();


            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Input");
                goto RETRY;
            }


        }

       
      

        
    }

}
