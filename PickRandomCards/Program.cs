using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbe kart do wybrania: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                //CardPicker.PickSomeCards(numberOfCards);
                //string[] wyniki;

                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }

            }
            else {
                Console.WriteLine("Nieprawidlowa liczba");
            }
            //string[] cards = PickRandomCards(5);
        }
    }
}
