//Perform these actions and create a console app that includes the following:

//Create a method with output parameters.

//Overload a method.

//Declare a class to be static., static and void is what I have been doing the entire tiem 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Class_Submission_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be divided by 2"); //request user input
            string numberInput = Console.ReadLine(); //collect user input
            int userNumber = Convert.ToInt32(numberInput);
        
            DivisionOperation divisionOperation = new DivisionOperation();
            DivisionOperation.userDivision(userNumber);
            DivisionOperation.userDivision(userNumber);
            //OperationHold operationHold = new OperationHold();
            //OperationHold.UserOperation(userNumber, userNumber2);

        }

    }
}





