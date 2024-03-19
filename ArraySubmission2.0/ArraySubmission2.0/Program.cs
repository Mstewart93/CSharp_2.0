



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
            //Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

        string [] animal = ["chicken", "dog", "cat", "duck",]; //decare the string array
        Console.WriteLine("Pick a number 0-3 to see what animal matches your personality"); //ask for user input
        int userInput = Convert.ToInt32(Console.ReadLine()); //get user input and convert it to an integer
        if (userInput < animal.Length) //if else to try and catch errors
        {
            Console.WriteLine(animal[userInput]); //use user input inplace of the index number if it is less than or equal to animal.length
        }

        else {
            Console.WriteLine("Error please select a number 0-3"); //anything other than a number throws this error message
            
        }

        //Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen. include error message
        int [] numbers = [1995,1993,1994,1995,1992];
        Console.WriteLine("Please Pick a number 0-4");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber < numbers.Length)
        {
            Console.WriteLine(numbers[userNumber]);

        }

        else {
            Console.WriteLine("Error Please pick a number 0-4");
        }



        //Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.

        List<string> stringlist = new List<string>();
            stringlist.Add("Apple");
            stringlist.Add("Fruit");
            stringlist.Add("Raspberry");
            stringlist.Add("Strawberry");
            stringlist.Add("Grape");
            stringlist.Add("Peach");
            stringlist.Add("Cherry");

        Console.WriteLine("Please Pick a number 0-6");
        int userPick = Convert.ToInt32(Console.ReadLine());
        if (userPick < stringlist.Count)
        {
            Console.WriteLine(stringlist[userPick]);

        }

        else {
            Console.WriteLine("Error Please pick a number 0-6");
        }

        }
    }
}