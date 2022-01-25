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
            List<string> scoreList = File.ReadAllLines("scoreFile.txt").ToList();

            for (int i = 0; i < scoreList.Count; i += 2)
            {
                string name = scoreList[i];
                int score = Convert.ToInt32(scoreList[i + 1]);

                HighScore hs = new HighScore(name, score);
                scores.Add(hs);
            }


            MenuScreen ms = new MenuScreen();
           
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
