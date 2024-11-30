using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class constructorChaining
    {
        public string firstName;
        public string lastName;

        public constructorChaining (string firstName, string lastName) : this(firstName, "Jessica")
        { 
        


        }

        public constructorChaining(string firstName, string lastName) 
        
        {
            this.firstName = firstName;
            this.lastName = lastName;
        
        }


    }
}
