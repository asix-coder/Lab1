using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public class Greyhound
    {
        public int StartingPosition; // Miejsce, gdzie zaczyna się PictureBox
        public int RacetrackLength; // Jak długa jest trasa
        public PictureBox MyPictureBox = null; // Mój obiekt PictureBox
        public int Location = 0; // Moje położenie na torze wyścigowym
        public Random MyRandom; // Instancja klasy random

        public bool Run()
        {
            int distance = MyRandom.Next(5); // Przesuń się losowo o 1, 2, 3 lub 4 punkty
            Location += distance; // Zaktualizuj położenie PictureBox na formularzu
            if (Location >= RacetrackLength) // Zwróć true, jeżeli wygrałem wyścig
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            StartingPosition = 0; // Wyzeruj położenie i ustaw na linii startowej
        }
    }
}
