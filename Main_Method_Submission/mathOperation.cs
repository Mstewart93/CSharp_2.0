using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Submission
{
    public class mathOperation
    {
        //operation.Addition(userInput);
          //  Console.Readline();
         
            public  mathOperation (int a)
            {
                Console.WriteLine(a + 6);
            }

            public mathOperation (int b)
            {
                Console.WriteLine(b * 34);
            }

            public mathOperation(int c)
            {
                decimal d = Convert.ToInt32(c);
                Console.WriteLine(d / 24);
            }
        }
    }

