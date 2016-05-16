/*
1.) System is a namespace with pre-built classes and methods. The using keyword is used so that the whole namespace is not required.

2.) A namespace organizes large amounts of code into a group. HelloWorld is the name of the namespace.

3.) We have a class named Program. It is public, which means that anyone can create objects from this class. It is a class, which means that it's going to work like a blueprint.

4.) Static means it is sealed and can't be inherited. If the class is not declared as static, client code can use it by creating objects or instances which are assigned to a variable. Void means that it won't return anything.

5.) Console is a class in the System namespace. If we didn't have the "using System" declaration, we'd be typing out System.Console.WriteLine(); every time that we wanted to use it. That would be annoying, because we use it a lot. This is what we use to print to the Console.

6.) Console Applications run the code and close if there is nothing else for them to do. This allows the user to see the output without the window closing too quickly.
*/

/* - 1 - */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* - 2 - */
namespace HelloWorld
{
    /* - 3 - */
    class Program
    {
        /* - 4 - */
        static void Main(string[] args)
        {
            /* - 5 - */
            Console.WriteLine("Hello World!");
            /* - 6 - */
            Console.ReadLine();
        }
    }
}
