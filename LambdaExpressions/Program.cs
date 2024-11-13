
//In the Main() method, create a list of at least 10 employees. At least two employees should have the first name “Joe”.

//Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking.
//Perform the same action again, but this time with a lambda expression.

//Using a lambda expression, make a list of all employees with an Id number greater than 5.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> EmployeeListFirstName = new List<string> { "Joe", "Jason", "Joe", "John", "Elizabeth", "Rachel", "Phoney", "Gandalf", "Sauroman", "Sauron" };

            List<string> EmployeeListLastName = new List<string> { "Smith", "Rubio", "Betsy", "Doe", "Smith", "Wilder", "Name", "Grey", "White", "Eye" };

            List<string> EmployeeListJoe = new List<string>();

            foreach (string i in EmployeeListFirstName)

            {
                if (EmployeeListJoe.Contains(i))
                {
                    EmployeeListJoe.Add(i);
                }
                else if (!EmployeeListLastName.Contains(i))
                {
                    EmployeeListJoe.Add(i);

                }
            }

           int EmployeeJoe = EmployeeListFirstName.Contains(x => x.EmployeeFirstName == EmployeeListFirstName.joe);

        }
    }
}



