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

namespace Centipede
{
    public partial class GameScreen : UserControl
    {
        #region Global Variables
        Rectangle player = new Rectangle(250, 420, 10, 15);

        int pSpeed = 5;

        bool aDown = false;
        bool dDown = false;

        SolidBrush whiteBrush = new SolidBrush(Color.White);

        #endregion
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(whiteBrush, player);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (aDown == true && player.X > 0)
            {
                player.X -= pSpeed;
            }

            if (dDown == true && player.X < 500 - player.Width)
            {
                player.X += pSpeed;
            }

            Refresh();
        }
    }
}
