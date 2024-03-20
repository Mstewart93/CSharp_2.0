using System;
class Program 
{
    static void Main()
    {

        int[] numberlist = {1,2,3,4,5,6}; //This creates the list
        Console.WriteLine(numberlist); //Print the list for user to see
    
        bool numValid = false;
        while (!numValid) {
        try { // we put what we want to try in our program here 
                Console.WriteLine("Please enter a divisor, or a number to divide by: "); //Request the user to input a number
                int usernumber = Convert.ToInt32(Console.ReadLine()); //Take usere input and onvert to an interger for division
                Console.WriteLine("One moment we are dividing by " + usernumber); // let user know we are dividing by their selection.
                for (int i = 0; i < numberlist.Length; i++)
                {
                Console.WriteLine(i/usernumber);
                numValid = true;
                }
        }
            
    
        catch (FormatException ex) //Catch if they use a word not a number
        {
           Console.WriteLine("Please write a whole number");
        }
        catch(DivideByZeroException ex)  //Checks to see if they are trying to divide by 0 
        {
            Console.WriteLine("Please do not divide by zero");
        }

        catch(Exception ex) //This can be used as a general catch all.

        {
            Console.WriteLine(ex.Message);
       }

        finally
       {
             Console.ReadLine();
        }
       

    }

}

}
