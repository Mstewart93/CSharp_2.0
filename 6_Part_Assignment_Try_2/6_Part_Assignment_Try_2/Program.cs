using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arraysubmission
{
    class Program
    {
        static void Main()
        {
            // Assignment part one

            List<string> animalList = ["dogs", "chickens", "cats", "ducks", "cows"];
            Console.WriteLine("Please Enter your favorite animal bellow:  ");
            string useranimal = Console.ReadLine();
            for (int i = 0; i < animalList.Count; i++)
            { Console.WriteLine(animalList[i]); };




            //Assignment Part 2 

            //x = 1;
            //while (x == 1);
            //Console.WriteLine("What is your name?");
            //y = Console.ReadLine();
            //Console.WriteLine()"Hello! Welcome";
            //Since x will always equal 1 this will run constantly we need to change it to one that has an end

            int x = 1;
            while (x > 0)
            {
                Console.WriteLine("Please Enter Your name ");
                Console.ReadLine();
                Console.WriteLine("Welcome!");
                x--;
            }



            //Assignment part 3

            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            //Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Hello, this should post 9 times :)");
            }
            int k = 1;
            while (k <= 10)
            { Console.WriteLine("This should post 10 times however");

                k++;
            }



            //Assignment Part 4 
            //A list of strings where each item in the list is unique.
            string[] animalStr;
            animalStr = ["mouse", "horse", "leopard", "zebra", "orangatang"];

            { Console.WriteLine("Let's see if your favorite animal is in the list. Please enter your favorite animal:   ");
                string userinput = Console.ReadLine();
                string lowerUser = userinput.ToLower();

                for (int m = 0; m < animalStr.Length; m++)
                {
                    if (animalStr[m] == userinput)
                    { Console.WriteLine("Your Favorite Animal is on the list!" + m);
                    }

                    else if (!animalStr.Contains(lowerUser))
                    {
                        Console.WriteLine("Your Animal is not on the list");
                        break;
                    }
                }





                //Assignment Part 5

                string[] color;
                color = ["red", "orange", "yellow", "green", "blue", "purple", "black", "brown", "gray", "grey", "yellow"];
                Console.WriteLine("Please enter your favorite color bellow:  ");
                string usercolor = Console.ReadLine();
                for (int n = 0; n < color.Length; n++)
                {
                    if (color[n] == usercolor)
                    { Console.WriteLine("Your Color is on the list" + n);
                    }

                    else if (!color.Contains(usercolor))
                    {
                        Console.WriteLine("Your Color is not on the list");

                    }
                }


                //Assignment Part 6
                List<string> booklist = new List<string>()["Harry Potter", "Lord of the Rings", "Hobbit", "Howls Moving Castle", "Harry Potter"];
                List<string> duplicate = new List<string>()[];
                foreach (string z in booklist)

                {
                    if (duplicate.Contains(z)) // loop that will compare itehm to eachother 
                        Console.WriteLine("This Item is unique");
                        duplicate.Add(z); }
                    else
                    Console.WriteLine("This book entry is a duplicate");
            }
        }
            }
        }
    }
 }
