using gameClient.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameClient
{
    public partial class UserProfile : Form
    {
        Player user;
        
        public UserProfile(Player user)
        { 
            InitializeComponent();
            this.user = user;
            loadComponents();
        }

        private void loadComponents()
        {
            if (user!=null) {
                lbHighest.Text = user.HighestTrophies+"";
                lbName.Text = user.Name;
                lbPlayed.Text = user.MatchesPlayed + "";
                lbTrophies.Text = user.Trophies + "";
                lbLevel.Text = user.Level + "";
                lbWins.Text = user.MatchesWinned + "";
                lbUserId.Text = user.UserId + "";
            }
        }

        private Button createButton(String name) {
            Button button = new Button();
            int windowHeight = this.Height;
            int windowWidth = this.Width;
            int y = 12;
            int x = 12;
            button.Text = name;
            button.Name = name;
            //button.ImageList = ;
            button.Width = 75;
            button.Height = 50;
            button.Location = new Point(15, y);
            y += 80;
            x += 80;

            if (windowHeight < x)
            {
                x = 12;
            }
            button.Click += new EventHandler(onClickWeaponShield);
            return button;
        }

        private void onClickWeaponShield(object sender, EventArgs e) {
            MessageBox.Show("Button clicked");
        }

    }
}
