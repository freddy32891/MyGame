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
    public partial class BestPlayers : Form
    {
        List<Player> players;
        public BestPlayers(List<Player>ranking)
        {
            InitializeComponent();
            this.players = ranking;
            loadData();
        }

        /**
         * Method that shows the ranking of the best players 
         */
        private void loadData()
        {
            listView1.Items.Clear();
            if (players != null)
            {
                int n = 1;
                foreach (Player player in players)
                {
                    if (player!=null)
                    {

                        listView1.Items.Add(new ListViewItem(new string[] {n.ToString(), player.Name, player.Trophies.ToString() }));
                        n++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error when receiving players");
            }
        }

    }
}
