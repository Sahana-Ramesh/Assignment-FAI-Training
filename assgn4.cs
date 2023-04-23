using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SampleConApp;

namespace Assignments
{
    class assgn4
    {
        static void Main(string[] args)
        {
            ArrayInputs();
        }

        #region data
        const string filepath = @"C:\Users\sahanar\OneDrive - First American Corporation\Documents\FAI-April2023\Assignments\SampleAssgn\Assignments\InputMenu.txt";

        #endregion

        static void ArrayInputs()
        {
            RETRY:
            Console.WriteLine("Enter the size of the Array");
            try
            {
                int size = int.Parse(Console.ReadLine());
                GOBACK:
                string menu = File.ReadAllText(filepath);
                //Console.WriteLine("Enter the CTS equivalent Data type for the Array");
                string typeName = UIConsole.GetString(menu);
                Type selectedDataType = Type.GetType(typeName, false, true);
                if (selectedDataType == null)
                {
                    Console.WriteLine("Invalid CTS type, not supported");
                    goto GOBACK;
                }

                CreateArray(selectedDataType, size);
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid Input");
                goto RETRY;
            }
            
        }

        static void CreateArray(Type selectedDataType, int size)
        {
            Array instance = Array.CreateInstance(selectedDataType, size);
            //Console.WriteLine("Enter the Values to the Array");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value for the index {i} of the data type {selectedDataType.Name}");
                string input = Console.ReadLine();
                instance.SetValue(Convert.ChangeType(input, selectedDataType), i);
            }
            Console.WriteLine("All the values are set, Now its time to read the data");
            foreach (var item in instance)
                Console.Write(item+" ");

            Console.WriteLine();
        }

    }
}

