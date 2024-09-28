using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operators_Submission
{
    public class Employee
    {
       public int Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }

       public static bool operator ==(Employee Id)
        {
           bool status = false;

            if (Id == Id)
            { 
                status = true;
            }
            return status;
        
        }
        public static bool operator !=(Employee Id)

        {
            bool status = false;

            if (Id != Id)
            { 
                status |= true;

            }

            return status;
           
        }
    }
}
