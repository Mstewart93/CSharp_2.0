﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TwentyOneSubmissionAssignment
{
    public class TwentyOneRules
    {
        private static Dictionary<Face,int> _cardValues = new Dictionary<Face, int>()
        {

            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.five] = 5,
            [Face.six] = 6,
            [Face.seven] = 7,
            [Face.eight] = 8,
            [Face.nine] = 9,
            [Face.ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1



        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x  => _cardValues [x.Face]);
            result[0] = value;
            if (result.Length == 1)
            { return result; }

            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;

            }

           
            return result;
        }
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        
        }

        public static bool IsBusted(List<Card> Hand)
        {
        int value = GetAllPossibleHandValues (Hand).Min();
            if (value > 21) return true;
            else return false;
        }
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)

            {
                if (value > 16 && value < 22)
                { return true; }


            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerresults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerresults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }

    }
}
