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
        Rectangle playerRec = new Rectangle(250, 420, 15, 20);

        Image playerImage = Properties.Resources.Centipede_Player;
        Image mushroomImage = Properties.Resources.Centipede_Mushroom;
        Image enemyImage = Properties.Resources.Centipede_flea;

        SolidBrush whiteBrush = new SolidBrush(Color.White);

        int pSpeed = 5;
        int bulletSpeed = 6;
        int bulletSize = 5;
        int fireCounter = 0;
        int mushroomSize = 15;
        int enemySize = 20;

        Random randGen = new Random();

        bool aDown = false;
        bool dDown = false;
        bool spaceDown = false;

        List<int> bulletXList = new List<int>();
        List<int> bulletYList = new List<int>();
        List<int> mushroomXList = new List<int>();
        List<int> mushroomYList = new List<int>();
        List<int> mushroomHealthList = new List<int>();
        List<int> enemyXList = new List<int>();
        List<int> enemyYList = new List<int>();
        List<int> enemySpeedList = new List<int>();

        #endregion
        public GameScreen()
        {
            InitializeComponent();
            GameInitialize();
        }

        public void GameInitialize()
        {
            #region Random Map Generator

            mushroomXList.Add(randGen.Next(25, 481));
            int tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 15) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            mushroomXList.Add(randGen.Next(25, 481));
            tempNum = randGen.Next(1, 16) * 20;
            mushroomYList.Add(tempNum);
            mushroomHealthList.Add(3);

            #endregion

            #region Enemy Generator
            enemyXList.Add(240);
            enemyYList.Add(0);
            enemySpeedList.Add(4);

            enemyXList.Add(220);
            enemyYList.Add(0);
            enemySpeedList.Add(4);

            enemyXList.Add(200);
            enemyYList.Add(0);
            enemySpeedList.Add(4);

            enemyXList.Add(180);
            enemyYList.Add(0);
            enemySpeedList.Add(4);

            enemyXList.Add(160);
            enemyYList.Add(0);
            enemySpeedList.Add(4);
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
            #region Paint Method
            //Draw player

            e.Graphics.DrawImage(playerImage, playerRec);

            //Draw bullets

            for (int i = 0; i < bulletXList.Count(); i++)
            {
                e.Graphics.FillEllipse(whiteBrush, bulletXList[i], bulletYList[i], bulletSize, bulletSize);
            }

            //Draw Mushrooms

            for (int i = 0; i < mushroomXList.Count(); i++)
            {
                e.Graphics.DrawImage(mushroomImage, mushroomXList[i], mushroomYList[i], mushroomSize, mushroomSize);
            }

            //Draw enemy

            for (int i = 0; i < enemyXList.Count(); i++)
            {
                e.Graphics.DrawImage(enemyImage, enemyXList[i], enemyYList[i], enemySize, enemySize);
            }
            #endregion
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region Player Movement
            //Move the player laft and right while checking the boundaries

            if (aDown == true && playerRec.X > 0)
            {
                playerRec.X -= pSpeed;
            }

            if (dDown == true && playerRec.X < 500 - playerRec.Width)
            {
                playerRec.X += pSpeed;
            }
            #endregion

            #region Bullet Movement

            fireCounter++;

            if (spaceDown == true && fireCounter > 10)
            {
                bulletXList.Add(playerRec.X + playerRec.Width / 2);
                bulletYList.Add(playerRec.Y);
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

            #region Bullet Collision

            for (int i = 0; i < mushroomXList.Count(); i++)
            {
                bool collision = false;
                for (int t = 0; t < bulletXList.Count(); t++)
                {

                    Rectangle bulletRec = new Rectangle(bulletXList[t], bulletYList[t], bulletSize, bulletSize);
                    Rectangle mushroomRec = new Rectangle(mushroomXList[i], mushroomYList[i], mushroomSize, mushroomSize);
                    
                    //Bullet collision with mushrooms

                    if (bulletRec.IntersectsWith(mushroomRec))
                    {
                        mushroomHealthList[i]--;

                        bulletXList.RemoveAt(t);
                        bulletYList.RemoveAt(t);

                        if (mushroomHealthList[i] == 0)
                        {
                            mushroomXList.RemoveAt(i);
                            mushroomYList.RemoveAt(i);
                            mushroomHealthList.RemoveAt(i);
                        }
                        collision = true;
                        break;
                    }
                 
                }
                if (collision)
                {
                    break;
                }
            }
            //Collision between bullets and enemys

            for (int s = 0; s < enemyXList.Count(); s++)
            {
                bool collision = false;
                for (int t = 0; t < bulletXList.Count(); t++)
                {
                    
                        Rectangle enemyRec = new Rectangle(enemyXList[s], enemyYList[s], enemySize, enemySize);
                        Rectangle bulletRec = new Rectangle(bulletXList[t], bulletYList[t], bulletSize, bulletSize);

                        if (bulletRec.IntersectsWith(enemyRec))
                        {
                            enemyXList.RemoveAt(s);
                            enemyYList.RemoveAt(s);
                            enemySpeedList.RemoveAt(s);

                        collision = true;
                        break;
                        }
                    
                }
                if (collision)
                {
                    break;
                }
            }

            for (int i = 0; i < enemyXList.Count(); i++)
            {
                bool collision = false;
                for (int t = 0; t < mushroomXList.Count(); t++)
                {
                    Rectangle enemyRec = new Rectangle(enemyXList[i], enemyYList[i], enemySize, enemySize);
                    Rectangle mushroomRec = new Rectangle(mushroomXList[t], mushroomYList[t], mushroomSize, mushroomSize);

                    if (enemyRec.IntersectsWith(mushroomRec))
                    {
                        enemyYList[i] += 20;
                        enemySpeedList[i] *= -1;

                        collision = true;
                        break;
                    }
                }
                if(collision)
                {
                    break;
                }
            }

            #endregion

            #region Win/Loss

            for (int i = 0; i < enemyYList.Count(); i++)
            {
                Rectangle enemyRec = new Rectangle(enemyXList[i], enemyYList[i], enemySize, enemySize);

                if (enemyRec.IntersectsWith(playerRec))
                {
                    gameTimer.Enabled = false;

                    
                }
            }


            #endregion

            #region Enemy Movement
            for (int i = 0; i < enemyXList.Count(); i++)
            {
                if (enemyXList[i] < 500 - enemySize && enemyXList[i] > 0)
                {
                    enemyXList[i] += enemySpeedList[i];
                }
                else if (enemyXList[i] == 500 - enemySize)
                {
                    enemyYList[i] += 20;
                    enemySpeedList[i] *= -1;
                    enemyXList[i] += enemySpeedList[i];
                }
                else if (enemyXList[i] == 0)
                {
                    enemyYList[i] += 20;
                    enemySpeedList[i] *= -1;
                    enemyXList[i] += enemySpeedList[i];
                }
            }
            #endregion

            Refresh();
        }
    }
}
