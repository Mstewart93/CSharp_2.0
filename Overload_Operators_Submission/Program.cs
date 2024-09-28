//Create an Employee class with Id, FirstName and LastName properties.
//In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
//Remember that comparison operators must be overloaded in pairs.
//In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties.
//Then compare the two Employee objects using the newly overloaded operators and display the results.


using Overload_Operators_Submission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Over
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Employee employee = new Employee(); //instantiate the new class
            employee.FirstName = "Sandi"; //assign a value to First Name, something Employee inherits from person
            employee.LastName = "Sheriff"; //same as above but last name
            employee.Id = 32;
            Employee employee2 = new Employee();
            employee2.FirstName = "Sheila";
            employee2.LastName = "Stevens";
            employee2.Id = 64;

            if (employee.Id == employee2.Id)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + "and" + employee2.FirstName + " " + employee2.LastName + " are the same employee's !");
            }
            else if (employee.Id != employee2.Id)

            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + "and" + employee2.FirstName + " " + employee2.LastName + " are not the same employee.");
            
            }
            else {

                Console.WriteLine("There was an error please try again");
            }

           

        }
    }

}