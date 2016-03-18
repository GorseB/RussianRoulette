using System;
using System.Windows.Forms;
// This class deals with the picture boxes and the selection of the jet, a nice little addition to russian roullete that i liked, sort of like a "choose which gun you want to shoot yourself with" feature
namespace RussianRoulette
{
    internal class JetSelect
    {
        public static int JetX = 0;
        public static bool IsShielded = false;
        public static int TimesShielded = 0; // more variables

        private JetSelect()
        {
        }

        public JetSelect(PictureBox shadowpicturebox, int Gamestate)
        {
            switch (Gamestate) // this determines wether the user is hovering or clicking on the picturebox
            {
                case 1:
                    Hover(shadowpicturebox);
                    break;

                case 2:
                    Clicky(shadowpicturebox);
                    break;
            }
        }

        private void Hover(PictureBox shadowpicturebox)
        {
            if (shadowpicturebox.Tag.ToString() != "Invisible")
            {
                if (Convert.ToInt32(shadowpicturebox.Tag) == 0)
                {
                    shadowpicturebox.Image = Properties.Resources.Jet;
                    shadowpicturebox.Tag = 1;
                }
                else if (Convert.ToInt32(shadowpicturebox.Tag) == 1)
                {
                    shadowpicturebox.Image = Properties.Resources.HollowJet;
                    shadowpicturebox.Tag = 0;
                }
            }
        }

        private void Clicky(PictureBox shadowpicturebox)
        {
            if (shadowpicturebox.Tag.ToString() == "3")
            {
                JetX = shadowpicturebox.Location.X;
                shadowpicturebox.Tag = 4;
            }
        }
    }
}