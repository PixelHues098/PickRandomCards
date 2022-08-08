using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
        class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards (int numberofCards)
        {
            string[] pickedCards = new string [numberofCards];
            for (int i = 0; i < numberofCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // get a random a number from 1 to 4
            int value = random.Next(1, 5);
            //if it's 1 return the string Spades
            if (value == 1) return "Spades";
            //if it's 2 return the string Hearts
            if (value == 2) return "Hearts";
            //if it's 3 return the string Clubs
            if (value == 3) return "Clubs";
            //if we haven't reurned yet, return Diamonds
            return "Diamonds";        
        }

        private static string RandomValue()
        {
            //get a random value from the listed values
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();

        }
    }
}
