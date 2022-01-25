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
    public partial class HighscoreScreen : UserControl
    {
        public HighscoreScreen()
        {
            InitializeComponent();
        }

        public void ShowScores()
        {
            foreach (HighScore hs in Centipede.scores)
            {
                //outputLabel.Text = ...
            }
        }

        private void HighscoreScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
