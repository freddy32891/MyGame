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
    public partial class Home : Form
    {
        MainController controller;
        Player user;
        private bool exit;
        private List<Player> ranking;
        public Home(MainController controller,Player user)
        {
            InitializeComponent();
            this.user = user;
            this.controller = controller;
            loadName();
        }
        private void loadName() {
            if (user!=null) {
                lbUserName.Text = user.Name;
            }
        }
        private void btTrophy_Click(object sender, EventArgs e)
        {
            ranking =  controller.getRankingOfBestPlayers();
            if (ranking!=null)
            {
                BestPlayers bestPlayers = new BestPlayers(ranking);
                bestPlayers.Show();
            }

        }

        private void btGoSocial_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            socialPanel.Visible = true;

            listViewFriends.Items.Clear();
            if (user.Friends != null)
            {
                int n = 1;
                foreach (Player player in user.Friends)
                {
                    if (player != null)
                    {
                        listViewFriends.Items.Add(new ListViewItem(new string[] { n.ToString(),player.UserId.ToString(), player.Name, player.Trophies.ToString() }));
                        n++;
                    }
                }
            }

        }

        private void btGoHome_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            homePanel.Visible = true;
        }

        private void btGoSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented :(");
        }

        private void btGoSearchPlayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented searchPlayer");
        }

        private void hideAllPanels() {
            homePanel.Visible = false;
            socialPanel.Visible = false;
            gamePanel.Visible = false;
            joinPublicPanel.Visible = false;
            gbCreateRoom.Visible =false;
        }

        private void btCreateMatch_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            String code = controller.createRoom();
            Console.WriteLine(code);
            lbMatchCode.Text = code;
            gbCreateRoom.Visible = true;
            if (DialogResult.OK==MessageBox.Show("Your code is "+code, "Atention", MessageBoxButtons.OK, MessageBoxIcon.Information))
            {
                    waiting(code);
            }


           
        }

        private void waiting(string code)
        {

            String result = "";
            result = controller.createMatch(code);
            while (!result.Contains("CONNECTED"))
            {
                lbWaitingForPlayer.Text = result;
                result = controller.createMatch(code);
                if (exit) { break; }
            }
            String[] parts = result.Split(';');
            Game game = new Game(user, controller, parts[1]);
            game.Show();
        }

        private void btGoStartBatle_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            setAllHomeButtons(false);
            gamePanel.Visible = true;

        }

        private void btSearchRooms_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            setAllHomeButtons(false);
            joinPublicPanel.Visible = true;
        }

        private void btPrivateRoom_Click(object sender, EventArgs e)
        {
            String roomCode = tbPrivateRoomCode.Text;
            String errorMessage = controller.joinPrivateRoom(roomCode);
            String[] parts = errorMessage.Split(';'); 
            if (parts[0].Equals("JOINED")) {
                Game game =  new Game(user, controller, parts[1]);
                game.Show();
            }
            else{
                lbErrorPrivateRoom.Text = errorMessage;
                lbErrorPrivateRoom.Visible = true;
            }
        }

        private void btSelectOponent_Click(object sender, EventArgs e)
        {
            //Host= false
            hideAllPanels();
            setAllHomeButtons(false);
            
        }

        private void setAllHomeButtons(bool bol)
        {
            btGoHome.Visible = bol;
            btGoSocial.Visible = bol;
            btGoSettings.Visible = bol;
        }

        private void btUserProfile_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile(user);
            profile.Show();
        }

        private void onClosing(object sender, FormClosingEventArgs e)
        {
            if (user != null && controller != null)
            {
                controller.disconnect();
            }
        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void BtBackFromGamePanel_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            homePanel.Visible = true;
            setAllHomeButtons(true);
        }

        private void BtBackFromJoinPublicPanel_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            gamePanel.Visible = true;
        }

        private void BackCreateRoomPanel_Click(object sender, EventArgs e)

        {
            exit = true;
            hideAllPanels();
            gamePanel.Visible = true;
        }
    }
}
