using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nameLabel.Text = "Joe";
            minimumBetLabel.Text = "Minimum bet: " + numericUpDown1.Minimum + " bucks";

           

            guys[0] = new Guy()
            {
                 Name = "Joe",
                 MyBet = null,
                 Cash = 50,
                 MyRadioButton = joeRadioButton,
                 MyLabel = joeBetLabel
            };

            guys[1] = new Guy()
            {
                Name = "Bob",
                MyBet = null,
                Cash = 75,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };

            guys[2] = new Guy()
            {
                Name = "Al",
                MyBet = null,
                Cash = 45,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };

            for (int i = 0; i < 3; i++)
            {
                guys[i].ClearBet();
                guys[i].UpdateLabels();
            }
        }

        Random Random = new Random();
        Greyhound[] greyhounds = new Greyhound[4];
        Guy[] guys = new Guy[3];
        int guyid;


        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                nameLabel.Text = "Joe";
                guyid = 0;
            }
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bobRadioButton.Checked)
            {
                nameLabel.Text = "Bob";
                guyid = 1;
            }
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (alRadioButton.Checked)
            {
                nameLabel.Text = "Al";
                guyid = 2;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            greyhounds[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                MyRandom = Random
            };

            greyhounds[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox2.Width,
                MyRandom = Random
            };

            greyhounds[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox3.Width,
                MyRandom = Random
            };

            greyhounds[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox4.Width,
                MyRandom = Random
            };

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (greyhounds[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Dog #" + (i + 1) + " won the race!", "We have a winner!");
                    for (int j = 0; j < 3; j++)
                    {
                        guys[j].Collect(i+1);
                        guys[j].ClearBet();
                    }
                    for (int k = 0; k < 4; k++)
                    {
                        greyhounds[k].TakeStartingPosition();
                    }
                }
            }
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            guys[guyid].MyBet.Amount = Convert.ToInt32(numericUpDown1.Value);
            guys[guyid].MyBet.Dog = Convert.ToInt32(numericUpDown2.Value);
            guys[guyid].UpdateLabels();
        }
    }
}
