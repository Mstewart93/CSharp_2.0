using System.ComponentModel;



List<Int32> numberList = new List<Int32>()
            {6,7,8,9 }; //initializes a list with values to divide by 

foreach (var x in numberList) //start a loop that will go through all the values in the list
{
    try // have the program try the main code
    {
        Console.WriteLine("Please enter a non-zero number"); //request user input
        string numberInput = Console.ReadLine(); //collect user input
        int userinput = Convert.ToInt32(numberInput); // convert user input into an integer
        Console.WriteLine(x / userinput); //display the quotient of numberList/ userinput
    }
    catch (Exception) //catch errors such as 0, a string etc.
    {
        Console.WriteLine("That is not a valid Input. Please Enter a non-Zero number"); //this will display if 
        //there is an error, and prompt user input again to get a valid input. Then the user input will be requested
        //for all remaining numbers in the list. 
    }
}