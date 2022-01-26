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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void controlsButton_Click(object sender, EventArgs e)
        {
            ControlsScreen cs = new ControlsScreen();
            Form form = this.FindForm();

            form.Controls.Add(cs);
            form.Controls.Remove(this);

            cs.Location = new Point((this.Width - cs.Width) / 2, (this.Height - cs.Height) / 2);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((this.Width - gs.Width) / 2, (this.Height - gs.Height) / 2);
        }

        private void highscoreButton_Click(object sender, EventArgs e)
        {
            HighscoreScreen hs = new HighscoreScreen();
            Form form = this.FindForm();

            form.Controls.Add(hs);
            form.Controls.Remove(this);

            hs.Location = new Point((this.Width - hs.Width) / 2, (this.Height - hs.Height) / 2);
        }

        private void PlayButton_Enter(object sender, EventArgs e)
        {
            PlayButton.BackColor = Color.Goldenrod;
            controlsButton.BackColor = Color.Black;
        }
    }
}
