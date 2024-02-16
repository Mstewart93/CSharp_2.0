using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How old are you?"); //takes their age
            int UserAge = Convert.ToInt32(Console.ReadLine()); // converts age from integer to string
            Console.WriteLine("Have you ever had a DUI? Please enter Yes or No."); //Takes bool DUI
            bool DUI = Console.ReadLine().ToLower() == "yes";
            Console.WriteLine("How many speeding tickets do you have?"); //Takes amount of Tickets
            string ticket = Console.ReadLine().ToLower(); //Input is a string
            int SpeedingTicket = Convert.ToInt32(ticket);//Converts to integer for comparison
            bool qualified = ((UserAge>15) && !DUI && (SpeedingTicket <=3)); // asseses if they are qulified for insurance 
            Console.WriteLine(qualified);
        }
    }
}
