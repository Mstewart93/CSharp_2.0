using Method_Class_Submission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
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
            int userNumber = Convert.ToInt32(numberInput); // convert user input into an integer
            Console.WriteLine("Please enter a second number");
            string numberInput2 = Console.ReadLine();
            int userNumber2 = Convert.ToInt32(numberInput2);

            OperationHold operationHold = new OperationHold();
            OperationHold.UserOperation(userNumber,userNumber2);

        }

    }
    }



