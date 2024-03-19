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
            // Assignment part one
            string []str1;
            str1 = ["Dogs","Chickens","Cats","Ducks","Cows"];
            Console.WriteLine("Please enter your favorite animal bellow:  ");
            string useranimal = Console.ReadLine();
            for (int i = 0; i < str1.Length; i++)
                {
                str1[i] = str1[i] + useranimal;
                }
            for (int i = 0;i < useranimal.Length; i++)
            {
                Console.WriteLine(str1 + useranimal);
            }

            //Assignment Part 2 
                
            //x = 1;
            //while (x == 1);
            //Console.WriteLine("What is your name?");
            //y = Console.ReadLine();
            //Console.WriteLine()"Hello! Welcome";
            //Since x will always equal 1 this will run constantly we need to change it to one that has an end

            int x = 5;
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
                while (int k = 1; k <= 10; k++)
                                {Console.WriteLine("This should post 10 times however");}

                            //Assignment Part 4
                            
            
                                //A list of strings where each item in the list is unique.
                                string[] str2 = {'mouse','horse','leopard','zebra','orangatang'}
                                
                                {Console.WriteLine("Let's see if your favorite animal is in the list. Please enter your favorite animal:   ");
                                string[] userinput = Console.ReadLine().ToLower;
                                
                                for (int m = 0; m>str2.Length; m++)
                                    {
                                        if (str2[m] == userinput)
                                        {Console.WriteLine("Your Favorite Animal is on the list!" + userinput.IndexOf(userinput));
                                        }
                                    
                                        else
                                        {
                                    Console.WriteLine( "Your Animal is not on the list");
                                        }
                                    }
                                
                                

                        

                            //Assignment Part 5

                        string[] color = ["red","orange","yellow","green","blue","purple","black","brown","gray","grey", "yellow"];
                            Console.WriteLine("Please enter your favorite color bellow:  ");
                                string usercolor = Console.ReadLine();
                                for (int n = 0; n < str1.Length; n++)
                    {
                                    if (color  == usercolor);
                                    Console.WriteLine("Your Color is on the list" +usercolor.IndexOf(usercolor));
                                    else 
                                    Console.WriteLine("Your color is not on the lsit")
                                    }
                                                

                                            //Assignment Part 6
                                            foreach (string z in color)

                                            {
                                                if (color.Equals(color[]) = true)
                                                
                                                {Console.WriteLine(color[z] + "This item is not Unique");}

                                                else
                                                Console.WriteLine(color[z]+ "This item is Unique")
                                            }

                                            Console.ReadLine();
                                            }
                                        }
                                    }
                                    }


//Unfortunately, I'm not able to get this to run. Many errors are preventing this from running, as I'm seeing 36 errors in the Error List. The bulk of these look like they're either syntax errors or typos when referencing variables. For example, on line 105 you have the following:

//{Console.WriteLine(color[z] + "This item is not Unique");}

//Because this is in a foreach loop you can't put color[z], instead you can just use z. Here's what I mean:

//{Console.WriteLine(z + "This item is not Unique");}

//Please work on all of the errors that are preventing this from running. Don't forget to test your application to make sure it's working without any errors. Feel free to reach out to us if you have any questions or need any help resolving these errors.
