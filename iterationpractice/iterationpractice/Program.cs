using System;
using System.Collections.Generic;
using System.Globalization;

class Program 
{
    static void Main(string [] args)

{

        //int[] testScores = {98, 99, 85, 70, 82, 34, 91, 90, 94};

        //Let's start with only logging the grades higher than 85.

        //for (int i =0; i < testScores.Length; i++)
       // {
        //    if (testScores[i] > 85)
         //   {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
       // }
       // Console.ReadLine();

       string [] names = {"Jesse","Daniel","Adam","Erik"};

       for (int j = 0; j<names.Length; j++)
       {
        if (names [j] == "Jesse")
        {
            Console.WriteLine(names[j]);
        }
       }

}

}
