
using Main_Method_Submission;
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
            int a = Convert.ToInt32(numberInput); // convert user input into an integer
            mathOperation mathOperation = new mathOperation();

             mathOperation(a); // call method userOperation passing a through the method 

            Console.WriteLine("Please enter a number with a decimal point ");
            string numberInput2 = Console.ReadLine();
            decimal b = decimal.Parse(numberInput2);

            mathOperation(b); // call the method also named userOperation passing b through it.

            Console.WriteLine("Please enter a number word such as Two, or Three");
            string numberInput3 = Console.ReadLine();
            string c = numberInput3.ToLower();

            mathOperation(c); //Call the method also name userOperatioon passing c through it. 

            




        }
    }
}
