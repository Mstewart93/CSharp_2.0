using Methods_and_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Object
{
    public class Program
    {
        public static void Main(string[] args)
        {


        Employee employee = new Employee(); //instantiate the new class
        employee.FirstName = "Sample"; //assign a value to First Name, something Employee inherits from person
        employee.LastName = "Student"; //same as above but last name
            employee.SayName(); // calls teh function/method we created in person called sayname






        }
    }
}
