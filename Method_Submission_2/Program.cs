//Perform these actions and create a console app that includes the following:



//Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.

//Call the method in the class, passing in the one or two numbers entered.

//Try various combinations of numbers on the code, including having no second number.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

//Upload your code to GitHub and submit the link below:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Method_Submission_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number"); //request user input
            string numberInput = Console.ReadLine(); //collect user input
            int userint = Convert.ToInt32(numberInput); // convert user input into an integer
            Console.WriteLine("If you would like please enter a second number, this is optional");
            string numberInput2 = Console.ReadLine();
            int optionalInt = Convert.ToInt32(numberInput2);
            IntegerOperation integerOperation = new IntegerOperation();

            IntegerOperation.userOperation(userint, 3);


        }
    }
}
