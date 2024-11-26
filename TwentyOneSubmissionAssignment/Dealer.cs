using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneSubmissionAssignment
{
    public  class Dealer
    {
        public string Name { get; set; }
        public string Deck {  get; set; }

        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(Card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Documents\GitHub\CSharp_2.0\logs\log.txt", true))
            { 
            file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0);
        }
        
        
    }
}
