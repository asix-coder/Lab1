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
        public Random MyRandom = 0; // Instancja klasy random

        public bool Run()
        {
            // Przesuń się losowo o 1, 2, 3 lub 4 punkty
            // Zaktualizuj położenie PictureBox na formularzu
            // Zwróć true, jeżeli wygrałem wyścig
        }

        public void TakeStartingPosition()
        {
            // Wyzeruj położenie i ustaw na linii startowej
        }
    }
}
