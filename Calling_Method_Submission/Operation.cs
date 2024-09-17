using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Method_Submission
{
    public class Operation
    {
        public int userinput;
        public void addUser()
        {
            
            Console.WriteLine(userinput + 6);
        }

        public void subtractingUser()
        {
            Console.WriteLine(userinput - 7);
        }

        public void  multiplicationOfUser(int a)
        {
            Console.WriteLine(userinput * 8);
        }
        }
    }



