using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Insurance
{
    class Program
    {
        static void Main()
        {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Please enter the package weight: ");
        string weight = Console.ReadLine(); // saves the weight as variable to be used later
            

        if (Convert.ToInt32(weight) < 50) { // checks weight fits into parameters 
                Console.WriteLine("Please enter the package width: "); //weight is fine so it takes different measurments W, H, L
                string width = Console.ReadLine();
                Console.WriteLine("Please enter the height: ");
                string height = Console.ReadLine();
                Console.WriteLine("Please enter the length: ");
                string length = Console.ReadLine();
                 if (Convert.ToInt32(width) + Convert.ToInt32(height) + Convert.ToInt32(length) < 50  ) { // if the dimensions added are not too big we get shipping total
                    double shipping = (((Convert.ToInt32(width) * Convert.ToInt32(height) *Convert.ToInt32(length)) * Convert.ToInt32(weight)) / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: " + shipping);
                 }
                 else {
                    Console.WriteLine("Package too big to be shipped via Package Express");} //if dimensions are too big it kicks it out.
        }
        else { //if weight is to heavy kicks it here and ends it 
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
        
      

            Console.ReadLine();





          
        }
    }
}