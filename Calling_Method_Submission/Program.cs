//Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
//The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.

//In the Main() program, ask the user what number they want to do the math operations on.

//Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Calling_Method_Submission
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number"); //request user input
            string numberInput = Console.ReadLine(); //collect user input
            int userinput = Convert.ToInt32(numberInput); // convert user input into an integer


            addition(userinput);
            subtractingUser(userinput);
            mulitplicationOfUser(userinput);


        }
    }
}
