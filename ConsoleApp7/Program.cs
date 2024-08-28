using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0; // the int declares variable named "count" gives value of zero
            string words; // variable declares name "words" as string type
            string vowels = "aeiou"; // variable declares name "vowels" as string type
            Console.Write("Enter a string: ");// User input for string
            words = Console.ReadLine(); //this ask for user then input 

            foreach (char chars in words) // foreach is a loop  and char chars will temporay hold each charater from "words "
            {
                foreach (char vowel in vowels) //foreach is a loop  and char will temporay hold each charater from "vowels "
                {
                    if (chars == vowel) // if statement that checks if the current charater is a vowel
                    {
                        count++;// declares variable count and ++ increases value of variable 
                    }
                }
            }

            Console.WriteLine("The number of vowels in the string is: "+ count);// this prints out the statement with variable count
            Console.ReadLine();// Pause the program so u can see it.
        }
    }
}