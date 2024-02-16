using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncome
{
    class Program
    {
        static void Main()
        {
            //Begin with printing the welcoming message
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:"); 
            Console.WriteLine("Hourly Rate");
            string rate1 = Console.ReadLine(); //Takes input for person 1 hourly rate
            
            Console.WriteLine("Hours Worked Per Week: ");
            string week1 = Console.ReadLine();//Takes hours per week input
   
            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate");
            string rate2 = Console.ReadLine();//Takes input for person 2 hourly rate
           
            Console.WriteLine("Hours Worked Per Week: ");
            string week2 = Console.ReadLine();//Takes hours per week input
           
            int Salary = Convert.ToInt32(rate1) * Convert.ToInt32(week1) * 52; //Creats the sallary to compare by
            int Salary2 = Convert.ToInt32(rate2) * Convert.ToInt32(week2) * 52;
            Console.WriteLine("Annual salary of Person 1:\n" + Salary); //Prints the salary of both
            Console.WriteLine("Annual salary of Person 2:\n" + Salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?"); 
            bool turefalse = Salary > Salary2; //Makes the comparison
            Console.WriteLine(turefalse); //prints the comparison
            Console.Read(); //keeps open till we close it
        }
    }
}