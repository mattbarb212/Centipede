using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centipede
{
    public partial class HighscoreSaveScreen : UserControl
    {
        int tempVal = 0;
        int tempVal2 = 0;
        int tempVal3 = 0;


        string tempString;

        public HighscoreSaveScreen()
        {
            InitializeComponent();
        }



        private void letter1Up_Click(object sender, EventArgs e)
        {
            tempVal++;

            if (tempVal > 26)
            {
                tempVal = 0;
            }
            ChangeLetters();
        }

        private void letter2Up_Click(object sender, EventArgs e)
        {
            tempVal2++;

            if (tempVal2 > 26)
            {
                tempVal2 = 0;
            }
            ChangeLetters();
        }

        private void letter3Up_Click(object sender, EventArgs e)
        {
            tempVal3++;

            if (tempVal3 > 26)
            {
                tempVal3 = 0;
            }
            ChangeLetters();
        }

        public void ChangeLetters()
        {
            #region Letter 1
            if (tempVal == 0)
            {
                letter1.Text = "A";
            }
            if (tempVal == 1)
            {
                letter1.Text = "B";
            }
            if (tempVal == 2)
            {
                letter1.Text = "C";
            }
            if (tempVal == 3)
            {
                letter1.Text = "D";
            }
            if (tempVal == 4)
            {
                letter1.Text = "E";
            }
            if (tempVal == 5)
            {
                letter1.Text = "F";
            }
            if (tempVal == 6)
            {
                letter1.Text = "G";
            }
            if (tempVal == 7)
            {
                letter1.Text = "H";
            }
            if (tempVal == 8)
            {
                letter1.Text = "I";
            }
            if (tempVal == 9)
            {
                letter1.Text = "J";
            }
            if (tempVal == 10)
            {
                letter1.Text = "K";
            }
            if (tempVal == 11)
            {
                letter1.Text = "L";
            }
            if (tempVal == 12)
            {
                letter1.Text = "M";
            }
            if (tempVal == 13)
            {
                letter1.Text = "N";
            }
            if (tempVal == 14)
            {
                letter1.Text = "N";
            }
            if (tempVal == 15)
            {
                letter1.Text = "O";
            }
            if (tempVal == 16)
            {
                letter1.Text = "P";
            }
            if (tempVal == 17)
            {
                letter1.Text = "Q";
            }
            if (tempVal == 18)
            {
                letter1.Text = "R";
            }
            if (tempVal == 19)
            {
                letter1.Text = "S";
            }
            if (tempVal == 20)
            {
                letter1.Text = "T";
            }
            if (tempVal == 21)
            {
                letter1.Text = "U";
            }
            if (tempVal == 22)
            {
                letter1.Text = "V";
            }
            if (tempVal == 23)
            {
                letter1.Text = "W";
            }
            if (tempVal == 24)
            {
                letter1.Text = "X";
            }
            if (tempVal == 25)
            {
                letter1.Text = "Y";
            }
            if (tempVal == 26)
            {
                letter1.Text = "Z";
            }
            #endregion

            #region Letter 2
            if (tempVal2 == 0)
            {
                letter2.Text = "A";
            }
            if (tempVal2 == 1)
            {
                letter2.Text = "B";
            }
            if (tempVal2 == 2)
            {
                letter2.Text = "C";
            }
            if (tempVal2 == 3)
            {
                letter2.Text = "D";
            }
            if (tempVal2 == 4)
            {
                letter2.Text = "E";
            }
            if (tempVal2 == 5)
            {
                letter2.Text = "F";
            }
            if (tempVal2 == 6)
            {
                letter2.Text = "G";
            }
            if (tempVal2 == 7)
            {
                letter2.Text = "H";
            }
            if (tempVal2 == 8)
            {
                letter2.Text = "I";
            }
            if (tempVal2 == 9)
            {
                letter2.Text = "J";
            }
            if (tempVal2 == 10)
            {
                letter2.Text = "K";
            }
            if (tempVal2 == 11)
            {
                letter2.Text = "L";
            }
            if (tempVal2 == 12)
            {
                letter2.Text = "M";
            }
            if (tempVal2 == 13)
            {
                letter2.Text = "N";
            }
            if (tempVal2 == 14)
            {
                letter2.Text = "N";
            }
            if (tempVal2 == 15)
            {
                letter2.Text = "O";
            }
            if (tempVal2 == 16)
            {
                letter2.Text = "P";
            }
            if (tempVal2 == 17)
            {
                letter2.Text = "Q";
            }
            if (tempVal2 == 18)
            {
                letter2.Text = "R";
            }
            if (tempVal2 == 19)
            {
                letter2.Text = "S";
            }
            if (tempVal2 == 20)
            {
                letter2.Text = "T";
            }
            if (tempVal2 == 21)
            {
                letter2.Text = "U";
            }
            if (tempVal2 == 22)
            {
                letter2.Text = "V";
            }
            if (tempVal2 == 23)
            {
                letter2.Text = "W";
            }
            if (tempVal2 == 24)
            {
                letter2.Text = "X";
            }
            if (tempVal2 == 25)
            {
                letter2.Text = "Y";
            }
            if (tempVal2 == 26)
            {
                letter2.Text = "Z";
            }
            #endregion

            #region Letter 3
            if (tempVal3 == 0)
            {
                letter3.Text = "A";
            }
            if (tempVal3 == 1)
            {
                letter3.Text = "B";
            }
            if (tempVal3 == 2)
            {
                letter3.Text = "C";
            }
            if (tempVal3 == 3)
            {
                letter3.Text = "D";
            }
            if (tempVal3 == 4)
            {
                letter3.Text = "E";
            }
            if (tempVal3 == 5)
            {
                letter3.Text = "F";
            }
            if (tempVal3 == 6)
            {
                letter3.Text = "G";
            }
            if (tempVal3 == 7)
            {
                letter3.Text = "H";
            }
            if (tempVal3 == 8)
            {
                letter3.Text = "I";
            }
            if (tempVal3 == 9)
            {
                letter3.Text = "J";
            }
            if (tempVal3 == 10)
            {
                letter3.Text = "K";
            }
            if (tempVal3 == 11)
            {
                letter3.Text = "L";
            }
            if (tempVal3 == 12)
            {
                letter3.Text = "M";
            }
            if (tempVal3 == 13)
            {
                letter3.Text = "N";
            }
            if (tempVal3 == 14)
            {
                letter3.Text = "N";
            }
            if (tempVal3 == 15)
            {
                letter3.Text = "O";
            }
            if (tempVal3 == 16)
            {
                letter3.Text = "P";
            }
            if (tempVal3 == 17)
            {
                letter3.Text = "Q";
            }
            if (tempVal3 == 18)
            {
                letter3.Text = "R";
            }
            if (tempVal3 == 19)
            {
                letter3.Text = "S";
            }
            if (tempVal3 == 20)
            {
                letter3.Text = "T";
            }
            if (tempVal3 == 21)
            {
                letter3.Text = "U";
            }
            if (tempVal3 == 22)
            {
                letter3.Text = "V";
            }
            if (tempVal3 == 23)
            {
                letter3.Text = "W";
            }
            if (tempVal3 == 24)
            {
                letter3.Text = "X";
            }
            if (tempVal3 == 25)
            {
                letter3.Text = "Y";
            }
            if (tempVal3 == 26)
            {
                letter3.Text = "Z";
            }
            #endregion

            Refresh();
        }

        private void HighscoreSaveScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void letter1Down_Click(object sender, EventArgs e)
        {
            tempVal--;

            if (tempVal < 0)
            {
                tempVal = 26;
            }

            ChangeLetters();
        }

        private void letter2Down_Click(object sender, EventArgs e)
        {
            tempVal2--;

            if (tempVal2 < 0)
            {
                tempVal2 = 26;
            }
            ChangeLetters();
        }

        private void letter3Down_Click(object sender, EventArgs e)
        {
            tempVal3--;

            if (tempVal3 < 0)
            {
                tempVal3 = 26;
            }
            ChangeLetters();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Saves the Score and the name
            tempString = $"{letter1.Text}{letter2.Text}{letter3.Text}";

            HighScore hs = new HighScore(tempString, GameScreen.score);
            Centipede.scores.Add(hs);

            //Changes back to the menu screen
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
