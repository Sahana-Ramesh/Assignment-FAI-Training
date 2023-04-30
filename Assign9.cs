using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleConApp;

namespace Assignments
{

    class Assign9
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
                string Sentence = UIConsole.GetString("Enter the sentence to be reversed:");
                string output = reverseByWords(Sentence);
                Console.WriteLine(output);
                UserInput();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
                goto Retry;
            }
        }

        private static string reverseByWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
