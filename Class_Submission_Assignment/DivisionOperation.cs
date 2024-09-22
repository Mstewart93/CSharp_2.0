using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    public  class DivisionOperation
    {


        public static void userDivision(int userNumber)
        {

            Console.WriteLine(userNumber / 2);
        }

        public static void userDivision(out int userNumber)
        {
            userNumber = 0;  
            
        }
    }
}