using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class CardPicker
    {
        // pole statyczne do generowania liczb
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards) {

            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }

            return pickedCards;
        }

        private static string RandomSuit()
        {
            //Pobieranie losowej od 1 do 4
            int value = random.Next(1,5);

            //Jesli liczba to 1, nalezy zwrocic lancuch znakow "pik"
            if (value == 1)
                return "pik";

            //Jezeli liczba to 2, nalezy zwrocic lancuch znakow "kier"
            if (value == 2)
                return "kier";


            //Jezeli liczba to 3, nalezy zwrocic lancuch znakow "trefl"
            if (value == 3)
                return "trefl";

            //Jezeli do tej pory metoda nie zwrocila sterowania, nalezy zwrocic "karo"
            return "karo";
        }

        private static string RandomValue()
        {

            // Pobieranie losowej od 1 do 13
            int value = random.Next(1, 14);

            //Jesli liczba 1 to zwroc lancuch znakow "as"
            if (value == 1)
                return "As";


            //Jesli liczba 11 to zwroc lancuch znakow ""walet"
            if (value == 11)
                return "Walet";


            //Jesli liczba 12 to zwroc lancuch znakow "dama"
            if (value == 12)
                return "Dama";


            //Jesli liczba 13 to zwroc lancuch znakow "krol"
            if (value == 13)
                return "Krol";


            //Zwroc lancuch znakow
            return value.ToString();
        }
    }
}
