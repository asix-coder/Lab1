using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Bet
    {
        public int Amount; // Ilość postawionych pieniędzy
        public int Dog; // Numer psa, na którego postawiono
        public Guy Bettor; // Facet, który zawarł zaklad

        public string GetDescription()
        {
            // Zwraca string, który określa, kto obstawił wyścig, jak dużo pieniędzy
            // postawił i na którego psa ("Janek postawił 8 zł na psa nr 4").
            // Jeżeli ilość jest równa 0, zakład nie został zawarty
            // ("Janek nie zawarł zakładu")
            if (Amount > 0)
            {
                return Bettor.Name + " bets " + Amount + " bucks on dog number " + Dog;
            }
            else
            {
                return Bettor.Name + "has not placed a bet";
            }
        }

        public int PayOut(int Winner)
        {
            // Parametrem jest zwycięzca wyścigu. Jeżeli pies wygrał,
            // zwróć wartość postawioną. W przeciwnym razie zwróć wartość
            // postawioną ze znakiem minus
            if (Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }

    }
}
