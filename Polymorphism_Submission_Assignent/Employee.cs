using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Submission_Assignent
{
    internal class Employee:Person, IQuittable
    {
        public void quit()
        { 
         Console.WriteLine(FirstName + " " + LastName + " " + " has quit school, and will not be returing");
        
        }
       
    }
}
