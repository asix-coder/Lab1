using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public class Guy
    {
        public string Name; // Imię faceta
        public Bet MyBet; // Instancja klasy Bet przechowująca dane o zakładzie
        public int Cash; // Jak dużo pieniędzy posiada
        
        // Ostatnie dwa pola są kontrolkami GUI na formularzu
        public RadioButton MyRadioButton; // Moje pole wyboru
        public Label MyLabel; // Moja etykieta

        public void UpdateLabels()
        {
            // Ustaw moje pole tekstowe na opis zakładu, a napis obok
            // pola wybru tak, aby pokazywał ilość pieniędzy ("Janek ma 43 zł")
        }

        public void ClearBet() { } // Wyczyść mój zakład, aby był równy zero

        public void PlaceBet(int Amount, int DogToWin)
        {
            // Ustal nowy zakład i przechowaj go w polu MyBet
            // Zwróć true, jeżeli facet ma wystarczającą ilość pieniędzy, aby obstawić
        }

        public void Collect(int Winner)
        {
            // Poproś o wypłatę zakładu i zaktualizuj etykiety
        }
    }
}
