using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public abstract class Person //makes person abstract means that it can never be instantiated only inherited from 
    {
        public string FirstName; //propertie of class Person
        public string LastName; // Propertie of class person
        public void SayName() //method/function to print our the assigned values for FirstName and LastName
        {

            Console.WriteLine("Name:" + " " + FirstName + " " + LastName);
        }

    }
}
