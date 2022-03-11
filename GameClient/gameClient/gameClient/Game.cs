using gameClient.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameClient
{
    public partial class Game : Form
    {
        Stopwatch stopWatch = new Stopwatch();
        List<Shield> shields = new List<Shield>();
        List<Weapon> weapons = new List<Weapon>();
        Player user;
        MainController controller;
        String oponent;
        int bullets, lifeUser, lifeOponent, round;
        public Game(model.Player user, MainController controller, String oponent)
        {
            InitializeComponent();
            this.user = user;
            this.controller = controller;
            this.oponent = oponent;
            loadGame();
            loadListView(listViewArsenalAvailable, user.Weapons, user.Shields);
        }

        private void loadGame()
        {
            bullets = 0;
            lifeOponent = 1000;
            lifeUser = 1000;
            round = 1;
        }

        private void loadListView(ListView list, List<Weapon> wp, List<Shield> sh)
        {
            list.Items.Clear();
            foreach (Shield player in sh)
            {
                if (player != null)
                {

                    list.Items.Add(new ListViewItem(new string[] { player.ShieldId.ToString(), player.Name, "Shield", player.Cost.ToString() }));

                }
            }

            foreach (Weapon player in wp)
            {
                if (player != null)
                {

                    list.Items.Add(new ListViewItem(new string[] { player.WeaponId.ToString(), player.Name, "Weapon", player.Cost.ToString() }));
                }
            }
        }

        private void BtFinishAdding_Click(object sender, EventArgs e)
        {
            selectArsenalPanel.Visible = false;
            gamePanel.Visible = true;
            loadInformation();
        }
        //Remove a weapon or shield on the game arsenal
        private void ListViewArsenal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = listViewArsenal.SelectedItems;
            if (selectedItems.Count > 0)
            {
                //selectedItems[1].Remove();
                String arsenal = selectedItems[0].SubItems[2].Text + ";" + selectedItems[0].Text;
                if (!string.IsNullOrWhiteSpace(arsenal))
                {
                    String[] parts = arsenal.Split(';');
                    if (parts[0].Equals("Shield"))
                    {
                        foreach (Shield shield in shields)
                        {
                            if (shield.ShieldId == int.Parse(parts[1]))
                            {
                                lbCoins.Text=(int.Parse(lbCoins.Text) + shield.Cost).ToString();//if the shield 
                                shields.Remove(shield);
                                break;
                            }
                        }

                    }
                    else if (parts[0].Equals("Weapon"))
                    {
                        foreach (Weapon weapon in weapons)
                        {
                            if (weapon.WeaponId == int.Parse(parts[1]))
                            {
                                lbCoins.Text = (int.Parse(lbCoins.Text) + weapon.Cost).ToString();
                                weapons.Remove(weapon);
                                break;
                            }
                        }
                    }


                    foreach (Shield player in shields)
                    {
                        if (player != null)
                        {

                            listViewArsenal.Items.Add(new ListViewItem(new string[] { player.ShieldId.ToString(), player.Name, "Shield", player.Cost.ToString() }));

                        }
                    }

                    foreach (Weapon player in weapons)
                    {
                        if (player != null)
                        {

                            listViewArsenal.Items.Add(new ListViewItem(new string[] { player.WeaponId.ToString(), player.Name, "Weapon", player.Cost.ToString() }));
                        }
                    }
                }
            }
        }
        //Adds from the arsenal available to the game arsenal
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listViewArsenal.Items.Clear();
                labeErrorAddingArsenal.Text = "";
                var selectedItems = listViewArsenalAvailable.SelectedItems;
                if (selectedItems.Count > 0)
                {
                    String arsenal = selectedItems[0].SubItems[2].Text + ";" + selectedItems[0].Text;
                    if (!string.IsNullOrWhiteSpace(arsenal))
                    {
                        String[] parts = arsenal.Split(';');
                        if (parts[0].Equals("Shield"))
                        {
                            foreach (Shield shield in user.Shields)
                            {
                                if (shield.ShieldId == int.Parse(parts[1]))
                                {
                                    if ((int.Parse(lbCoins.Text) - shield.Cost) >= 0)
                                    {
                                        shields.Add(shield);
                                        lbCoins.Text = (int.Parse(lbCoins.Text) - shield.Cost).ToString();
                                    }
                                    else
                                    {
                                        labeErrorAddingArsenal.Text = "There's not enough coins to add this shield";
                                    }
                                }
                            }

                        }
                        else if (parts[0].Equals("Weapon"))
                        {
                            foreach (Weapon weapon in user.Weapons)
                            {
                                if (weapon.WeaponId == int.Parse(parts[1]))
                                {
                                    if ((int.Parse(lbCoins.Text) - weapon.Cost) >= 0)
                                    {
                                        weapons.Add(weapon);
                                        lbCoins.Text = (int.Parse(lbCoins.Text) - weapon.Cost).ToString();
                                    }
                                    else
                                    {
                                        labeErrorAddingArsenal.Text = "There's not enough coins to add this weapon";
                                    }

                                }
                            }
                        }
                        else
                        {
                            labeErrorAddingArsenal.Text = "Please, intrduce a valid Arsenal type";
                        }
                    }
                    else
                    {
                        labeErrorAddingArsenal.Text = "Error, the there's no text introduced";
                    }

                    foreach (Shield player in shields)
                    {
                        if (player != null)
                        {

                            listViewArsenal.Items.Add(new ListViewItem(new string[] { player.ShieldId.ToString(), player.Name, "Shield", player.Cost.ToString() }));

                        }
                    }

                    foreach (Weapon player in weapons)
                    {
                        if (player != null)
                        {

                            listViewArsenal.Items.Add(new ListViewItem(new string[] { player.WeaponId.ToString(), player.Name, "Weapon", player.Cost.ToString() }));
                        }
                    }
                }
            }
            catch (Exception error)
            {
                labeErrorAddingArsenal.Text = error.Message;
            }

        }

        //GAME PANEL
        private void btRecharge_Click(object sender, EventArgs e)
        {
            try
            {
                String order = "PLAY;RCH;0";
                String messageFromServer = controller.play(order);
                if (checkOKMessage(messageFromServer))
                {
                    introduceDataToGameTurn(messageFromServer);
                }else if (messageFromServer.Equals("YOUWIN"))
                {
                    lifeOponent = 0;
                    MessageBox.Show("Your aponent has left the match, You win!!", "Atention");
                    this.Close();
                }
                else
                {
                    lbErrorPlaying.Text = messageFromServer;
                }
                updateChanges();
            }
            catch (Exception error)
            {
                lbErrorPlaying.Text = error.Message + error.StackTrace;
            }

        }

        private void updateChanges()
        {
            updateShields();
            lbBullets.Text = bullets.ToString();
            lbPointOfLifeEnemy.Text = lifeOponent+"";
            lbPointsOfLifeUser.Text = lifeUser+"";
            lbRound.Text = round + "";
            if (lifeUser <= 0)
            {
                controller.play("PLAY;FINISH");
                lbWinOrLose.Text = "YOU'VE LOST :(";
                lbWinOrLose.Visible = true;
            }else if (lifeOponent <=0)
            {
                controller.play("PLAY;FINISH");
                lbWinOrLose.Visible = true;
                lbWinOrLose.Text = "YOU'VE WON !!!";
            }
        }

        private void introduceDataToGameTurn(string messageFromServer)
        {
            lbErrorPlaying.Text = "";
            round++;
            int result; //The diference between the damage produced by the user and the oponent
            int pointsUser, pointsEnemy;
            //  EXAMPLE messageFromServer: ATA;2;-500;DEF;3;80
            String[] parts = messageFromServer.Split(';');
            if (parts[0].Equals("ATA"))
            {
                bullets--;
                lbActionUser.Text = "ATTACK!!";
                pointsUser = int.Parse(parts[2]); //points of damage of the weapon
                pictureUser.BackgroundImage = Image.FromFile("resources/vector/attack.png");
                if (parts[3].Equals("ATA")) //The 2 users attack at the same time
                {
                    lbActionEnemy.Text = "ATTACK!!";
                    pointsEnemy = int.Parse(parts[5]);
                    pictureEnemy.BackgroundImage = Image.FromFile("resources/vector/attackR.png");
                    if (pointsUser < pointsEnemy)
                    {
                        if (pointsUser == 0)//in case that the user fails his shoot
                        {
                            lbDescription.Text = "You've failed your shoot and your opponent\ndon't. You'll receive " + (pointsEnemy * -1) + " points of damage";
                            lifeUser += pointsEnemy;
                        }
                        else
                        {
                            result = (pointsUser * -1) + pointsEnemy; // (-50*-1)+(-100)
                            lbDescription.Text = "You've done " + (pointsUser * -1) + " points of damage\nBut your opponent has done " + (pointsEnemy * -1) + " ponts.\nYou'' receive " + (result * -1) + " points of damage.";
                            lifeUser += result;
                        }
                    }
                    else if (pointsUser > pointsEnemy)
                    {
                        if (pointsEnemy == 0)
                        {
                            lbDescription.Text = "Your opponent has failed his shoot and you don't.\nYour opponen will receive " + (pointsUser * -1) + " points of damage";
                            lifeOponent += pointsUser;
                        }
                        else
                        {
                            result = pointsUser - (pointsEnemy);
                            lbDescription.Text = "You've more damage in your attack.\nYour opponent will receive " + (result * -1) + " points of damage";
                            lifeOponent += result;
                        }
                    }
                    else //In case that the damage is the same
                    {
                        if (pointsEnemy == 0)
                        {
                            lbDescription.Text = "You and your oponent have failed the shoot\n The points of life are not going to be affected.";
                        }
                        else
                        {
                            lbDescription.Text = "You and your oponent have made the damage of\n" + pointsUser + ". The points of life are not going to be affected.";

                        }
                    }
                }
                else if (parts[3].Equals("DEF"))//Action of the opponent
                {
                    lbActionEnemy.Text = "DEFENSE";
                    pictureEnemy.BackgroundImage = Image.FromFile("resources/vector/defenseR.png");
                    pointsEnemy = int.Parse(parts[5]);
                    if ((pointsUser * -1) < pointsEnemy)
                    {
                        if (pointsUser == 0)//CHECKED
                        {
                            lbDescription.Text = "You've failed your attack. You won't damage your opponent";
                        }
                        else//CHECKED
                        {
                            lbDescription.Text = "Your shoot couldn't broke his shield.\nHis shield was too much to your weapon";
                        }
                    }
                    else if ((pointsUser * -1) > pointsEnemy)
                    {
                        result = (pointsEnemy * -1) + pointsUser;
                        lbDescription.Text = "You've done " + (result * -1) + " points of damage.\nAlthough he had defended himself, your shoot broke his shield";
                        lifeOponent += result; 
                    }
                    else//CHECKED
                    {
                        lbDescription.Text = "You've done " + (pointsUser * -1) + " points of damage.\nBut he defended with a shield of " + pointsEnemy + " points of life\nYour shoot wasn't enough to destroy his shield.";
                    }
                }
                else
                {
                    lbActionEnemy.Text = "RECHARGE";
                    pictureEnemy.BackgroundImage = Image.FromFile("resources/vector/rechargeR.png");
                    lbDescription.Text = "You have done " + (pointsUser * -1) + " of damage";
                    lifeOponent +=pointsUser;
                }
            }
            else if (parts[0].Equals("DEF"))
            {
                lbActionUser.Text = "DEFEND";
                pointsUser = int.Parse(parts[2]);//Get the points of defense of the shield
                pictureUser.BackgroundImage = Image.FromFile("resources/vector/defense.png");
                if (parts[3].Equals("ATA")) //CHECKED
                {
                    lbActionEnemy.Text = "ATTACK";
                    pictureEnemy.BackgroundImage = Image.FromFile("resources/vector/attackR.png");
                    pointsEnemy = int.Parse(parts[5]);
                    if (pointsUser < (pointsEnemy * -1))//CHECKED
                    {
                        result = (pointsUser * -1) + pointsEnemy;
                        lbDescription.Text = "Your shield protected you from " + pointsUser + " points of damage|\nbut it has finally broken.\nYou receive " + (result * -1) + " points of damage";
                        lifeUser += result;
                    }
                    else
                    {
                        if (pointsEnemy == 0)
                        {
                            lbDescription.Text = "You've protected yourself from " + pointsUser + " points \nof damage but your opponent failed the shoot";
                        }
                        else
                        {
                            lbDescription.Text = "Your shield defended succesfully his attack\n of " + (pointsEnemy * -1) + " points of damage";
                        }
                    }
                }
                else if (parts[3].Equals("DEF"))
                {
                    lbActionEnemy.Text = "DEFEND";
                    pictureEnemy.BackgroundImage = Image.FromFile("resources/vector/defenseR.png");
                    lbDescription.Text = "You 2 have wasted a shield unnecessarily";
                }
                else //oponent recharges
                {
                    lbActionEnemy.Text = "RECHARGE";
                    pictureEnemy.BackgroundImage = Image.FromFile("resources/vector/rechargeR.png");
                    lbDescription.Text = "You have wasted a shield unnecessarily";
                }
            }
            else//user recharges
            {
                bullets++;
                lbActionUser.Text = "RECHARGE";
                pictureUser.BackgroundImage = Image.FromFile("resources/vector/recharge.png");
                if (parts[3].Equals("ATA"))
                {
                    lbActionEnemy.Text = "ATTACK";
                    pictureEnemy.BackgroundImage = Image.FromFile("resources/vector/attackR.png");
                    pointsEnemy = int.Parse(parts[5]);
                    if (pointsEnemy == 0)
                    {
                        lbDescription.Text = "You recharged but he failed his shoot.\nYou've been lucky!";
                    }
                    else
                    {
                        lbDescription.Text = "He shooted you while you were recharging.\nYou receive " + (pointsEnemy * -1) + " points of damage";
                        lifeUser += pointsEnemy;
                    }
                }
                else if (parts[3].Equals("DEF"))
                {
                    lbActionEnemy.Text = "DEFEND";
                    pictureEnemy.BackgroundImage = Image.FromFile("resources/vector/defenseR.png");
                    lbDescription.Text = "You've recharged while he was defending.\nWell played!";
                }
                else
                {
                    lbActionEnemy.Text = "RECHARGE";
                    pictureEnemy.BackgroundImage = Image.FromFile("resources/vector/rechargeR.png");
                    lbDescription.Text = "You 2 have recharged at the same time.\nWhat a coincidence!";
                }
            }

        }

        private bool checkOKMessage(String messageFromServer)
        {
            String[] parts = messageFromServer.Split(';');
            return parts.Length > 1;
        }

        private void btAttack_Click(object sender, EventArgs e)
        {
            try
            {
                String order = "";
                String messageFromServer;
                order = "PLAY;";

                if (bullets > 0)
                {
                    String weapon = cbWeapons.SelectedItem.ToString();
                    if (weapon != null)
                    {
                        if (getWeaponId(weapon) != -1)
                        {
                            messageFromServer = controller.play(order + "ATA;" + getWeaponId(weapon) + ";");
                            if (checkOKMessage(messageFromServer))
                            {
                                introduceDataToGameTurn(messageFromServer);
                            }else if (messageFromServer.Equals("YOUWIN"))
                            {
                                lifeOponent = 0; 
                                MessageBox.Show("Your aponent has left the match, You win!!", "Atention");
                                this.Close();
                            }
                            else
                            {
                                lbErrorPlaying.Text = messageFromServer;
                            }
                            updateChanges();
                        }
                    }
                }
                else
                {
                    lbErrorPlaying.Text = "You have no bullets left, please select an other action";
                }
            }
            catch (Exception error)
            {
                lbErrorPlaying.Text = error.Message + error.StackTrace;
            }
        }

        private void btDefend_Click(object sender, EventArgs e)
        {
            try
            {
                String order = "PLAY;";
                String messageFromServer;
                String shield = cbShields.SelectedItem.ToString();
                int index = cbShields.SelectedIndex;
                if (shield != null)
                {
                    if (getShieldId(shield) != -1)
                    {
                        messageFromServer = controller.play(order + "DEF;" + getShieldId(shield) + ";");
                        foreach (Shield sh in shields)
                        {
                            if (sh.ShieldId == getShieldId(shield))
                            {
                                shields.Remove(sh);
                                break;
                            }
                        }
                        if (checkOKMessage(messageFromServer))
                        {
                            introduceDataToGameTurn(messageFromServer);
                        }
                        else if (messageFromServer.Equals("YOUWIN"))
                        {
                            lifeOponent = 0; MessageBox.Show("Your aponent has left the match, You win!!", "Atention");
                            this.Close();
                        }
                        else
                        {
                            lbErrorPlaying.Text = messageFromServer;
                        }
                        updateChanges();
                    }
                }
            }catch(Exception error)
            {
                lbErrorPlaying.Text = error.Message+error.StackTrace;
            }
        }

        private int getWeaponId(String name)
        {
            int weaponId = -1;
            foreach (Weapon weapon in weapons)
            {
                if (weapon.Name.Equals(name))
                {
                    weaponId = weapon.WeaponId;
                }
            }
            return weaponId;
        }

        private void windowClosed(object sender, FormClosingEventArgs e)
        {
            this.controller.play("PLAY;QUIT");
        }

        private int getShieldId(String name)
        {
            int shieldId = -1;

            foreach (Shield shield in shields)
            {
                if (shield.Name.Equals(name))
                {
                    shieldId = shield.ShieldId;
                }
            }
            return shieldId;
        }

        private void loadInformation()
        {
            lbWinOrLose.Text = "";
            lbWinOrLose.Visible = false;
            lbOponentName.Text = oponent;
            lbPointOfLifeEnemy.Text = lifeOponent+"";
            lbDescription.Text = "";
            lbActionUser.Text = "";
            lbActionEnemy.Text = "";
            lbBullets.Text = bullets+"";
            lbPointsOfLifeUser.Text = lifeUser+"";
            lbRound.Text = round + "";
            labelUserName.Text = user.Name;
            for (int i = 0; i < weapons.Count; i++)
            {
                cbWeapons.Items.Add(weapons[i].Name);
            }
            updateShields();
            lbErrorPlaying.Text = "";

        }

        private void updateShields()
        {
            for (int i = 0; i < shields.Count; i++)
            {
                cbShields.Items.Add(shields[i].Name);
            }
        }
    }
}
