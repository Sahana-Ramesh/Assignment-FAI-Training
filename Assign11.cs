using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleConApp;

namespace Assignments
{
    class Assign11
    {
        static void Main(string[] args)
        {
            inputValues();
        }

        private static void inputValues()
        {
            Retry:
            try
            {
                
                double Amt = UIConsole.GetDouble("Enter the Principle ammount:");
                int term = UIConsole.GetNumber("Enter the term in years:");
                float rate = UIConsole.GetFloat("Enter the interest rate:");

                InterestCal(Amt, term, rate);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
                goto Retry;
            }
        }

        private static void InterestCal(double amt, int term, float rate)
        {
            double IntAmt = amt *(1+ (term * (rate/100)));
            Console.WriteLine("Interest amount: "+ IntAmt);
        }
    }
}
