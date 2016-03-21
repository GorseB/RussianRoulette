using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
// Exactly the same as Missle.cs execpt with a few more things added in, like dicehistory and the suicide missle, refer to the comments on Missle.cs or read through the code if you cant figure something out
// its all pretty easy if you read through it actually.
namespace RussianRoulette
{
    internal class Roulette_Missile
    {
        private int DiceRoll = 0;
        private Point MissilePoint = new Point(40, -10);
        private Random rng = new Random();
        private PictureBox MissileObject = new PictureBox();
        private Size MissileSize = new Size(16, 51);
        private static List<int> DiceHistory = new List<int>();

        public Roulette_Missile()
        {
            if (DiceHistory.Count == 7)
            {
                MessageBox.Show("Error! Too Many Missiles! Program will now exit.");
                Form.ActiveForm.Close();
                Application.Exit();
            }
            if (GameStats.RouletteMissles > 0)
            {
                Dice();
                CreateObject();
                Movement();
            }
        }

        private void CreateObject()
        {
            MissileObject.Image = Properties.Resources.Missile;
            MissileObject.Size = MissileSize;
            MissileObject.Visible = true;
            MissileObject.Location = MissilePoint;
            MissileObject.Tag = "missile";
            Form.ActiveForm.Controls.Add(MissileObject);
        }

        private void Dice()
        {
            do
            {
                DiceRoll = rng.Next(1, 7);
            } while (DiceHistory.Contains(DiceRoll));
            DiceHistory.Add(DiceRoll);
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
            GameStats.Streak++;
            while ((MissileObject.Location.Y + 51) < 900)
            {
                MissilePoint.Y += 3;
                MissileObject.Location = MissilePoint;
                MissileObject.Refresh();
                System.Threading.Thread.Sleep(2);
                if ((MissileObject.Location.Y + 1) == 300 && (MissileObject.Location.X - 20) == JetSelect.JetX)
                {
                    if (JetSelect.IsShielded)
                    {
                        JetSelect.IsShielded = false;
                        Form1.SetInvisible();
                    }
                    else
                    {
                        Form1.BGM2.Play();
                        MessageBox.Show("You Have Been Destroyed!!!");                        
                        GameStats.LostLast = true;
                        GameStats.Streak = 0;
                    }
                }
            }
            this.MissileObject.Dispose();
        }

        public void ClearDiceHistory()
        {
            DiceHistory.Clear();
        }

        public void Suicide()
        {
            // End it all...
            this.MissileObject.Dispose();
        }
    }
}