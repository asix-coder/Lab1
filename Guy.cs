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
            // pola wuboru tak, aby pokqazywał ilość pieniędzy ("Janek ma 45 zł")
            MyRadioButton.Text = Name + " has " + Cash + " backs";
            if (MyBet == null)
            {
                MyLabel.Text = Name + " has not place a bet";
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
        }

        public void ClearBet() 
        {
            MyBet = new Bet();
            MyBet.Amount = 0;
            MyBet.Bettor = this;
            UpdateLabels();

        } // Wyczyść mój zakład, aby był równy zero

        public bool PlaceBet(int Amount, int DogToWin)
        {
            // Ustal nowy zakład i przchowaj go w polu MyBet
            // Zwróć true, jeżeli facet ma wystarczającą ilość pieniędzy, aby obstawić

            MyBet.Amount = Amount;
            MyBet.Dog = DogToWin;
      

            if(this.Cash >= Amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)
        {
            // Poproś o wypłatę zakładu i zaktualizuj etykiety
            this.Cash += MyBet.PayOut(Winner);
            UpdateLabels();
        }
    }
}
