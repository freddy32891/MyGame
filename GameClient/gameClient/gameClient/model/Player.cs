using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameClient.model
{
    [Serializable]
    public class Player
    {
        private int userId;
        private String mail;
        private String password;
        private String name;
        private String role;
        private int trophies;
        private int highestTrophies;
        private int level;
        private int experience;
        private int matchesPlayed;
        private int matchesWinned;
        private List<Player> friends;
        private List<Matches> matches;
        private List<Shield> shields;
        private List<Weapon> weapons;

        public Player(int userId, string mail, string password, string name, string role, int trophies, int highestTrophies, int level, int experience)
        {
            this.userId = userId;
            this.mail = mail;
            this.password = password;
            this.name = name;
            this.role = role;
            this.trophies = trophies;
            this.highestTrophies = highestTrophies;
            this.level = level;
            this.experience = experience;
        }

        public Player(int userId, string mail, string password, string name, string role, int trophies, int highestTrophies, int level, int experience, int matchesPlayed, int matchesWinned)
        {
            this.userId = userId;
            this.mail = mail;
            this.password = password;
            this.name = name;
            this.role = role;
            this.trophies = trophies;
            this.highestTrophies = highestTrophies;
            this.level = level;
            this.experience = experience;
            this.matchesPlayed = matchesPlayed;
        }

        public Player(int userId,String name, int trophies){
            this.userId = userId;
            this.name = name;
            this.trophies = trophies;
            matches = new List<Matches>();
            shields = new List<Shield>();
            weapons = new List<Weapon>();
        }
        public Player(String name) {
            this.name = name;
            matches = new List<Matches>();
            shields = new List<Shield>();
            weapons = new List<Weapon>();
        }


        public Player(int userId)
        {
            this.userId = userId;
            friends = new List<Player>();
            matches = new List<Matches>();
            shields = new List<Shield>();
            weapons = new List<Weapon>();
        }

        public Player(string mail, string password, string name)
        {
            this.mail = mail;
            this.password = password;
            this.name = name;
            friends = new List<Player>();
            matches = new List<Matches>();
            shields = new List<Shield>();
            weapons = new List<Weapon>();
        }

        public Player(string mail, string password)
        {
            this.mail = mail;
            this.password = password;
            friends = new List<Player>();
            matches = new List<Matches>();
            shields = new List<Shield>();
            weapons = new List<Weapon>();
        }

        public Player()
        {
            friends = new List<Player>();
            matches = new List<Matches>();
            shields = new List<Shield>();
            weapons = new List<Weapon>();
        }

        public int UserId { get => userId; set => userId = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }
        public int Trophies { get => trophies; set => trophies = value; }
        public int HighestTrophies { get => highestTrophies; set => highestTrophies = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public int MatchesPlayed { get => matchesPlayed; set => matchesPlayed = value; }
        public int MatchesWinned { get => matchesWinned; set => matchesWinned = value; }
        internal List<Player> Friends { get => friends; set => friends = value; }
        internal List<Matches> Matches { get => matches; set => matches = value; }
        internal List<Shield> Shields { get => shields; set => shields = value; }
        internal List<Weapon> Weapons { get => weapons; set => weapons = value; }

        public override bool Equals(object obj)
        {
            return obj is Player user &&
                   userId == user.userId;
        }

        public override int GetHashCode()
        {
            return -394678857 + userId.GetHashCode();
        }

        public String toString()
        {
            return "User{" + "userId=" + userId + ", mail=" + mail + ", password=" + password + ", name=" + name + ", role=" + role + ", trophies=" + trophies + ", highestTrophies=" + highestTrophies + ", level=" + level + ", experience=" + experience + ", matchesPlayed=" + matchesPlayed + ", matchesWinned=" + matchesWinned + '}';
        }

    }
}
