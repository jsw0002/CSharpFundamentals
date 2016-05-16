/*
1.) Create 5 different string variables and concatenate them into one string.

2.) Create a note to a your future self that states your goals. Include the date in the string by creating a date string that is converted to a short date string.

3.) Create 2 strings: Your username for something in lower case, and your username in uppercase. Write code that compares two similar strings and prints whether or not they are equal. Print one sentence that says that they are equal. Print another string that says that they are not equal.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            /* - 1 - */

            string husband = "Jordan";
            string wife = "Trisha";
            string kidOne = "Caden";
            string kidTwo = "Jaxon";
            string funTimes = "go to the park";

            Console.WriteLine("{0} and {1} have two children, {2} and {3}. They love to {4} as a family.", husband, wife, kidOne, kidTwo, funTimes);


            /* - 2 - */

            string greetings = "Hello Mr. Willis,";
            string todaysDate = DateTime.Today.ToShortDateString();
            string body = "I'm enjoying C# immensely. I'm hoping that after these lessons not only will I have a job as a developer, but that I will also be an expert in C#.";

            Console.WriteLine("{0} today is {1}. {2}", greetings, todaysDate, body);

            /* - 3 - */

            string userNameLowercase = "jordanwillis";
            string userNameUppercase = "JORDANWILLIS";
            bool result1 = userNameLowercase.Equals(userNameUppercase, StringComparison.Ordinal);
            bool result2 = userNameLowercase.Equals(userNameUppercase, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine("Ordinal comparison: {0} and {1} are {2}", userNameLowercase, userNameUppercase, result1 ? "equal." : "not equal.");
            Console.WriteLine("Ordinal ignore case: {0} and {1} are {2}", userNameLowercase, userNameUppercase, result2 ? "equal." : "not equal.");

            Console.ReadLine();
        }
    }
}
