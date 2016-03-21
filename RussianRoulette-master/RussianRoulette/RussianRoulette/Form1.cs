using System;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using System.IO;
// And now we begin the commenting, there is lots of code to cover so i am making an assumption that the reader has atleast a basic understanding of C#
// or else ill have to explain what objects and variables are and that would take too long. The code is pretty well laid out so if you just breakpoint you'll probably find everything
// Using .Media and .IO because they cover our sound
namespace RussianRoulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbxMissleSize.SelectedIndex = 0; // Makes the Combobox on the form 0 by default 
                                             // Stream str = Properties.Resources.Soundtrack_loop;        // our background game music, played at all stages throughout the game 
                                             // SoundPlayer BGM = new SoundPlayer(str);                     // more BGM code
                                             //  BGM.PlayLooping();                          // Actually ordering the Soundplayer object to start
            
        }
        public static Stream str2 = Properties.Resources.Sound_Hit;
        public static SoundPlayer BGM2 = new SoundPlayer(str2); // The exact same code as before but being used for the explosion sound you hear when you die, the only reason its here instead of in 
        // game stats is because it was getting confusing (for me)

        private void RapidFire_Click(object sender, EventArgs e) // this is the code that deals with the rapid fire section of the game, its really simple code actually so i wont go into much detail
        {
            if (JetSelect.JetX != 0)
            {
                for (int i = 0; i < Convert.ToInt32(cbxMissleSize.SelectedItem); i++)
                {
                    var MyMissile = new Missile(); // creating our missle
                    GameStats.Isplaying = true; // a bool i added in near the end of development, becuase it kept bringing up the winning screen on every shot (roulette) instead of at the end
                    SetInvisible(); // probably the most complex method in our code
                }
                if (GameStats.LostLast)
                {
                    GameStats.LostLast = false;
                    GameStats.Lost++; // pretty simple globals
                }
                else if (GameStats.RouletteMissles == 0 && GameStats.Isplaying)
                {
                    MessageBox.Show("You Won!");
                    GameStats.Won++;
                    GameStats.Isplaying = false;
                }
                GameStats.GamesPlayed++;
                UpdateGameStats();
            }
        }

        private void JetChange(object sender, EventArgs e)
        {
            var Jet1 = new JetSelect(sender as PictureBox, 1);
        }

        private void JetClick(object sender, EventArgs e)
        {
            SetInvisible();
            var Jet1 = new JetSelect(sender as PictureBox, 2);
        }

        public static void SetInvisible() // this method is pretty crazy actually, it goes through all the pictures in the form and assigns them tags based on what it thinks they are
            // such as missle and the jet, its also used for the selecting of the jet at the start of the game
            // there are 5 tags that are used in the game (0,1,2,3,4 and Invisible) which basically tell the method what stage the player is at in the game
        {
            
            foreach (PictureBox PictureinForm in ActiveForm.Controls.OfType<PictureBox>())
            {
                if (PictureinForm.Tag != null && PictureinForm.Tag.ToString() == "0" && PictureinForm.Tag.ToString() != "missile")
                {
                    PictureinForm.Image = null;
                    PictureinForm.Visible = false;
                    PictureinForm.Tag = "Invisible";
                }
                if (PictureinForm.Tag != null && PictureinForm.Tag.ToString() != "Invisible" && PictureinForm.Tag.ToString() != "missile")
                {
                    if (PictureinForm.Tag.ToString() == "1")
                    {
                        PictureinForm.Tag = "3";
                    }
                }
                if (PictureinForm.Tag.ToString() == "4" && JetSelect.IsShielded == true)
                {
                    PictureinForm.Image = Properties.Resources.Jet___Copy;
                }
                if (PictureinForm.Tag.ToString() == "4" && JetSelect.IsShielded == false)
                {
                    PictureinForm.Image = Properties.Resources.Jet;
                    PictureinForm.Refresh();
                }
            }
        }

        private void btnShield_Click(object sender, EventArgs e)
        {
            if (JetSelect.JetX != 0 && JetSelect.IsShielded == false && JetSelect.TimesShielded != 2) // Simple sheilding method which sets the global bool IsSheileded to true if you have sheilds left to use
            {
                JetSelect.TimesShielded++;
                JetSelect.IsShielded = true;
                SetInvisible();
                changethelabel();
            }
        }

        private void changethelabel() // changes the sheild label based on sheilds remaining
        {
            switch (JetSelect.TimesShielded)
            {
                case 0:
                    lblShieldStatus.Text = "You Have Two Shields Remaining!";
                    break;

                case 1:
                    lblShieldStatus.Text = "You Have One Shield Remaining!";
                    break;

                case 2:
                    lblShieldStatus.Text = "You Have No Shields Remaining!";
                    break;
            }
        }

        private void UpdateGameStats() // more label updates based on var's
        {
           
            lblGamesPlayed.Text = "Games Played : " + GameStats.GamesPlayed.ToString();
            lblLost.Text = "Games Lost : " + GameStats.Lost.ToString();
            lblWon.Text = "Games Won : " + GameStats.Won.ToString();
            lblStreak.Text = "Dodge Streak : " + GameStats.Streak.ToString();
            lblRStatus.Text = GameStats.RouletteMissles.ToString();
            GameStats.textinfo[0] = GameStats.GamesPlayed.ToString();
            GameStats.textinfo[1] = GameStats.Won.ToString();
            GameStats.textinfo[2] = GameStats.Lost.ToString();
            File.WriteAllText(@"C:\Users\Siah\Downloads\RussianRoulette-master\RussianRoulette\RussianRoulette\Scores.txt", String.Empty);
            using (System.IO.StreamWriter file =
    new System.IO.StreamWriter(@"C:\Users\Siah\Downloads\RussianRoulette-master\RussianRoulette\RussianRoulette\Scores.txt", true))
            {
                file.WriteLine(GameStats.textinfo[0].ToString());
                file.WriteLine(GameStats.textinfo[1].ToString());
                file.WriteLine(GameStats.textinfo[2].ToString());
            }
        }
        private void Getthescores()
        {
            GameStats.textinfo = System.IO.File.ReadAllLines(@"C:\Users\Siah\Downloads\RussianRoulette-master\RussianRoulette\RussianRoulette\Scores.txt");
            GameStats.GamesPlayed = Convert.ToInt32(GameStats.textinfo.GetValue(0));
            GameStats.Won = Convert.ToInt32(GameStats.textinfo.GetValue(1));
            GameStats.Lost = Convert.ToInt32(GameStats.textinfo.GetValue(2));
        }
        private void btnRLoad_Click(object sender, EventArgs e) // sets the roullete missles to 6 if you arent already playing and you have no missles left to shoot
        {
            if (GameStats.RouletteMissles == 0 && GameStats.Isplaying == false)
            {
                GameStats.RouletteMissles = 6;
                GameStats.Isplaying = true;
            }
            UpdateGameStats();
        }

        private void btnRFire_Click(object sender, EventArgs e) // pretty complex code that deals with shooting the missle 
        {
            if (JetSelect.JetX != 0) // if you are wondering what this is, it is testing for wether the ship is invisible (becuase then you wouldnt be able to play)
            {
                if (GameStats.RouletteMissles > 0) // aslong as you have missles, fire a missle and reduce your total missles by 1
                {
                    var NRM = new Roulette_Missile();
                    GameStats.RouletteMissles--;
                }
                if (GameStats.RouletteMissles == 0 && GameStats.Isplaying) // if you are out of missles and actually pressed the load button, you win!
                {
                    MessageBox.Show("You Won!");
                    GameStats.Isplaying = false;
                    GameStats.GamesPlayed++;
                    GameStats.Won++;
                    JetSelect.TimesShielded = 0;
                    changethelabel();
                    var SuicidedMissle = new Roulette_Missile();
                    SuicidedMissle.ClearDiceHistory();
                    SuicidedMissle.Suicide();
                }
                if (GameStats.LostLast)
                {
                    GameStats.LostLast = false;
                    GameStats.Lost++;
                    GameStats.GamesPlayed++;
                }
                JetSelect.IsShielded = false;
                UpdateGameStats();
                SetInvisible();
            }
        }
        public static void SetVisible()
        {
            foreach (PictureBox PictureinForm in ActiveForm.Controls.OfType<PictureBox>())
            {
                if (PictureinForm.Tag != null && PictureinForm.Tag.ToString() != "missile")
                {
                    PictureinForm.Image = Properties.Resources.HollowJet;
                    PictureinForm.Visible = true;
                    PictureinForm.Tag = 0;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e) // this used to reset all the variables in the code and change the picture boxes back to visible, but it broke and i dont know what happed 
            // so now when you lose the game closes, i was going to fix it but i found that this pretty much does the same thing.
        {
            Getthescores();
            UpdateGameStats();
        }
    }
}