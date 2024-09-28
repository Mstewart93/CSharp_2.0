//Create an interface called IQuittable and have it define a void method called Quit().

//Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.

//Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Submission_Assignent
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Employee employee = new Employee(); //instantiate the new class
            employee.FirstName = "Sample"; //assign a value to First Name, something Employee inherits from person
            employee.LastName = "Student"; //same as above but last name
            employee.SayName(); // calls teh function/method we created in person called saynam
            employee.quit();


        }
    }

}