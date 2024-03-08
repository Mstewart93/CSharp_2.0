



using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Arraysubmission
{
    class Program
    {
        static void Main()
        {

        string [] animal = ["chicken", "dog", "cat", "duck",]; //decare the string array
        Console.WriteLine("Pick a number 0-3 to see what animal matches your personality"); //ask for user input
        int userInput = Convert.ToInt32(Console.ReadLine()); //get user input and convert it to an integer
        if (userInput <= animal.Length) //if else to try and catch errors
        {
            Console.WriteLine(animal[userInput]); //use user input inplace of the index number if it is less than or equal to animal.length
        }

        else {
            Console.WriteLine("Error please select a number 0-3"); //anything other than a number throws this error message
            
        }





        }
    }
}