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
        public RadioButton MyRadioBytton; // Moje pole wyboru
        public Label MyLabel; // Moja etykieta

        public void UpdateLabels()
        {
            // Ustaw moje pole tekstowe na opis zakładu, a napis obok
            // pola wuboru tak, aby pokqazywał ilość pieniędzy ("Janek ma 45 zł")
            MyLabel.Text = Name + " has " + Cash + " backs";
        }

        public void ClearBet() { } // Wyczyść mój zakład, aby był równy zero

        public bool PlaceBet(int Amount, int DogToWin)
        {
            // Ustal nowy zakład i przchowaj go w polu MyBet
            // Zwróć true, jeżeli facet ma wystarczającą ilość pieniędzy, aby obstawić
            return true;
        }

        public void Collect(int Winner)
        {
            // Poproś o wypłatę zakładu i zaktualizuj etykiety
        }
    }
}
