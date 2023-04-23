using SampleConApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class assgn3
    {
        #region data
        const string filepath = @"C:\Users\sahanar\OneDrive - First American Corporation\Documents\FAI-April2023\Assignments\SampleAssgn\Assignments\TextFile1.txt";
   
        #endregion

       


        static void Main(string[] args)
        {
            try
            {
                do
                {
                    string menu = File.ReadAllText(filepath);
                    string choice = UIConsole.GetString(menu);
                    if (choice == "QUIT" || choice == "quit") break;
                    //if (choice != "+" || choice != "-" || choice != "*" || choice != "/") break;
                       //validateChoice(choice);
                    double No1 = UIConsole.GetDouble("Enter the First Value");
                    double No2 = UIConsole.GetDouble("Enter the Second Value");
                    double result = PerformOperation(No1, No2, choice);
                    Console.WriteLine("The result of the operation is " + result);
                    Console.WriteLine("Press any key to clear the screen");
                    Console.ReadKey();
                    Console.Clear();
                } while (true);
            }
            catch (FormatException)
            {
                Console.WriteLine("enter a valid input");
                
            }
            
           
        }

       

        private static double PerformOperation(double No1,double No2,string choice)
        {
            double result = 0;
            switch (choice)
            {
                case "+": result = AddOperation(No1,No2); break;
                case "-": result = SubOperation(No1, No2); break;
                case "X": result = DivOperation(No1, No2); break;
                case "/": result = MulOperation(No1, No2); break;
                default:
                    break;
            }
            return result;

        }

        
        private static  Double DivOperation(double No1, double No2)
        {
            double add = No1 / No2;
            return add;
            
        }

        private static Double MulOperation(double No1, double No2)
        {
            double add = No1 * No2;
            return add;
        }

        private static Double SubOperation(double No1, double No2)
        {
            double add = No1 - No2;
            return add;
        }

        private static Double AddOperation(double No1, double No2)
        {
            double add = No1 + No2;
            return add;
        }
    }
}
