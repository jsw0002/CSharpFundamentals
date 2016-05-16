/*
1.) You can declare variables with or without a value assigned to them.

2.) Once the variable is declared you can assign a value without the declaration tags.

3.) Concatenating string can be done it two different ways. You can use curly braces with the index values to pass variables into strings or you can add each one together using the + sign.

4.) Parse is how you convert variables into another type such as string into an integer.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* - 1 - */
            int luckyNumber;
            int yearGraduatedHighSchool = 2003;

            string lastName;
            string firstName = "Jordan";

            bool isMarried;
            bool isHappy = true;

            float amountOfSnow;
            float temperature = 57.2F;

            double latitude;
            double oneThird = 3.333333333333333;

            decimal bankAccount;
            decimal costOfGroceries = 123.45M;

            Console.WriteLine(yearGraduatedHighSchool);
            Console.WriteLine(firstName);

            /* - 2 - */
            lastName = "Willis";
            /* - 3 - */
            Console.WriteLine("{0} {1}", firstName, lastName);
            Console.WriteLine(firstName + " " + lastName);

            string yearBorn = "1985";
            /* - 4 - */
            int numYearBorn = Int32.Parse(yearBorn);
            Console.WriteLine("I was born in {0}.", numYearBorn);

            string cityOfBirth = "Indianapolis";
            string parentsNames = "Scott and Tina";

            Console.WriteLine("Jordan was born in {1} in {0} to {2}.", cityOfBirth, yearBorn, parentsNames);

            Console.ReadLine();
        }
    }
}
