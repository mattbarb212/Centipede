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
        Rectangle player = new Rectangle(250, 420, 15, 20);
        
        Image playerImage = Properties.Resources.Centipede_Player;

        SolidBrush whiteBrush = new SolidBrush(Color.White);

        int pSpeed = 5;
        int bulletSpeed = 3;
        int bulletSize = 5;
        int fireCounter = 0;
        int mushroomSize = 10;

        Random randGen = new Random();

        bool aDown = false;
        bool dDown = false;
        bool spaceDown = false;

        List<int> bulletXList = new List<int>();
        List<int> bulletYList = new List<int>();
        List<int> mushroomXList = new List<int>();
        List<int> mushroomYList = new List<int>();
        List<int> mushroomHealthList = new List<int>();


        #endregion
        public GameScreen()
        {
            InitializeComponent();
            GameInitialize();
        }

        public void GameInitialize()
        {
            #region Random Map Generator

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 491));
            mushroomYList.Add(randGen.Next(25, 300));
            mushroomHealthList.Add(3);

            #endregion
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
                case Keys.Space:
                    spaceDown = true;
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
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(playerImage, player);

            for (int i = 0; i < bulletXList.Count(); i++)
            {
                e.Graphics.FillEllipse(whiteBrush, bulletXList[i], bulletYList[i], bulletSize, bulletSize);
                
            }
            for (int i = 0; i < mushroomXList.Count(); i++)
            {
                e.Graphics.FillRectangle(whiteBrush, mushroomXList[i], mushroomYList[i], mushroomSize, mushroomSize);
                
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region Player Movement
            //Move the player laft and right while checking the boundaries

            if (aDown == true && player.X > 0)
            {
                player.X -= pSpeed;
            }

            if (dDown == true && player.X < 500 - player.Width)
            {
                player.X += pSpeed;
            }
            #endregion

            #region Bullet Movement

            fireCounter++;

            if (spaceDown == true && fireCounter > 15)
            {
                bulletXList.Add(player.X + player.Width/2) ;
                bulletYList.Add(player.Y);
                fireCounter = 0;
            }

            for (int i = 0; i < bulletYList.Count(); i++)
            {
                bulletYList[i] -= bulletSpeed;

                if (bulletYList[i] < 0)
                {
                    bulletYList.RemoveAt(i);
                    bulletXList.RemoveAt(i);
                }
            }


            #endregion

            #region Collision //Not Complete
            for (int i = 0; i < bulletXList.Count(); i++)
            {
                Rectangle bulletRec = new Rectangle(bulletXList[i], bulletYList[i], bulletSize, bulletSize);
                Rectangle mushroomRec = new Rectangle(mushroomXList[i], mushroomYList[i], mushroomSize, mushroomSize);

                if (bulletRec.IntersectsWith(mushroomRec))
                {
                    mushroomHealthList[i]--;

                    bulletXList.RemoveAt(i);
                    bulletYList.RemoveAt(i);
                    
                    if(mushroomHealthList[i] == 0)
                    {
                        mushroomXList.RemoveAt(i);
                        mushroomYList.RemoveAt(i);
                        mushroomHealthList.RemoveAt(i);
                    }
                }
            }
            #endregion

            Refresh();
        }
    }
}
