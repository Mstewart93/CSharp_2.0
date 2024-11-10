
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
        public enum Days
        {

            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday,
        }
    public static void Main(string[] args)
        {


            try
            {
       
                Console.WriteLine("Please Enter Today's Day of the Week:");
               string UserDay = Console.ReadLine();
                string UserLower = UserDay.ToLower();
                if (Enum.IsDefined(typeof(Days), UserLower))
                {
                    Console.WriteLine("You entered " + UserLower);
                }

            }
            
            catch
            {

                Console.WriteLine("Please Enter an actual day of the week");
                    }
        }
    }
}
         


   
