///Matthew Barber
///01/10/2022
///Centipede

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Centipede
{
    public partial class Centipede : Form
    {
        public static List<HighScore> scores = new List<HighScore>();

        public Centipede()
        {
            InitializeComponent();
        }

        private void Centipede_Load(object sender, EventArgs e)
        {
            #region Highscore Load
            List<string> scoreList = File.ReadAllLines("scoreFile.txt").ToList();

            for (int i = 0; i < scoreList.Count; i += 2)
            {
                string name = scoreList[i];
                int score = Convert.ToInt32(scoreList[i + 1]);

                HighScore hs = new HighScore(name, score);
                scores.Add(hs);
            }
            #endregion

            #region Screen Switch
            MenuScreen ms = new MenuScreen();
           
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            #endregion
        }

        private void Centipede_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<string> tempList = new List<string>();

            foreach (HighScore hs in scores)
            {
                tempList.Add(hs.name);
                tempList.Add(Convert.ToString(hs.score));
            }

            File.WriteAllLines("scoreFile.txt", tempList);
        }
    }
}
