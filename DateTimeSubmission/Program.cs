using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;


Console.WriteLine(DateTime.Now); // this prints the current time right now

Console.WriteLine("Please entrer a number"); //asks for user input
string UserInput = Console.ReadLine(); //assigns user input to an  variable
int UserNumber = Int32.Parse(UserInput);
int FutureTime = UserNumber + DateTime.Now.Hour; //adds userinput to curent time hours. 
Console.WriteLine(FutureTime);
Console.ReadLine();
