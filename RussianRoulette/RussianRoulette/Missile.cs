using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
// Missle and Roulette missle pretty much do the same thing, aside from Roulette missle using the "DiceHistory" feature, i found it terribly difficult to fit them both into one class and also
// thought that it wouldnt be the best idea to actually do so, so they are two classes now, this is all the code that deals with the shooting of missles. 
namespace RussianRoulette
{
    internal class Missile
    {
        private int DiceRoll = 0;
        private Point MissilePoint = new Point(40, -10);// Where its drawn on the screen
        private Random rng = new Random();
        private PictureBox MissileObject = new PictureBox();
        private Size MissileSize = new Size(16, 51);  // How big the missle is 

        public Missile()
        {
            Dice();
            CreateObject();
            Movement();
        }

        private void CreateObject()
        {
            MissileObject.Image = Properties.Resources.Missile; // actually creating the missle
            MissileObject.Size = MissileSize;
            MissileObject.Visible = true;
            MissileObject.Location = MissilePoint;
            MissileObject.Tag = "missile";
            Form.ActiveForm.Controls.Add(MissileObject);
        }

        private void Dice()
        {
            DiceRoll = rng.Next(1, 7); // deciding where to put it based on rng
            switch (DiceRoll)
            {
                case 1:
                    MissilePoint.X = 40;
                    break;

                case 2:
                    MissilePoint.X = 120;
                    break;

                case 3:
                    MissilePoint.X = 200;
                    break;

                case 4:
                    MissilePoint.X = 280;
                    break;

                case 5:
                    MissilePoint.X = 360;
                    break;

                case 6:
                    MissilePoint.X = 440;
                    break;
            }
        }

        private void Movement()
        {
            GameStats.Streak++; // this method deals with the movement and collision of the missle, pretty self explanitory actually
            while ((MissileObject.Location.Y + 51) < 900)
            {
                MissilePoint.Y += 3;
                MissileObject.Location = MissilePoint;
                MissileObject.Refresh(); // refresh so that the game can redraw the missle
                System.Threading.Thread.Sleep(2); // sleep so that the game doesnt perform all this math in the blink of an eye
                if ((MissileObject.Location.Y + 1) == 300 && (MissileObject.Location.X - 20) == JetSelect.JetX)
                {
                    if (JetSelect.IsShielded)
                    {
                        JetSelect.IsShielded = false; // sheilding stuff
                        Form1.SetInvisible();
                    }
                    else
                    {
                        Form1.BGM2.PlayLooping();
                        MessageBox.Show("You Have Been Destroyed!!!"); // boom, dead. end it all
                        GameStats.LostLast = true;
                        GameStats.Streak = 0;
                        Application.Exit();
                    }
                }
            }
            this.MissileObject.Dispose();
        }
    }
}