using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace gameClient.model.persist
{
    public class ClientSocket
    {
        private String IP = "127.0.0.1";
        private int PORT = 32891;
        public StreamWriter writer;
        private StreamReader reader;
        private Player user;
        private TcpClient client;

        public Player getPlayer() {
            return user;
        }
        public ClientSocket(string mail, string password) {
            startConection();
            user = login(mail, password);
        }

        public ClientSocket() {
            startConection();
        }

        internal bool disconnect()
        {
            this.client.Close();
            if (client.Connected)
            {
                return false;
            }
            else {
                return true;
            }
        }
        public string createRoomCode()
        {
            String code = "";
            try
            {
                if (client.Connected)
                {
                    String order = "GETROOMCODE;";
                    writer.WriteLine(order);
                    writer.Flush();
                    code = reader.ReadLine();
                }
                else {
                    code = "Error connecting to the server";
                }

            }
            catch (Exception e)
            {
                code = "Error: "+e.Message;
            }
            return code;
        }
        public String play(String order)
        {
            //Example order PLAY;ATA;4 
            //Example messageServer ATA;3;200;RCH;0;0
            String messageFromServer = "";
            try
            {
                if (client!=null)
                {
                    if (client.Connected)
                    {
                        writer.WriteLine(order);
                        writer.Flush();
                        messageFromServer = reader.ReadLine();
                    }
                    else
                    {

                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return messageFromServer;
        }
        internal String joinPrivateRoon(string roomCode)
        {
            String messageFromServer = "";
            try
            {
                if (client.Connected)
                {
                    String order = "JOINPRIVATEROOM;"+roomCode+";";
                    writer.WriteLine(order);
                    writer.Flush();
                    messageFromServer = reader.ReadLine();
                }
                else
                {
                    messageFromServer = "Error connecting to the server";
                }

            }
            catch (Exception e)
            {
                messageFromServer = "Error: " + e.Message;
            }
            return messageFromServer;
        }

        public string createRoom(String roomCode)
        {
            String code = "";
            try
            {
                if (client.Connected)
                {
                    String order = "CREATEROOM;"+roomCode+";";
                    writer.WriteLine(order);
                    writer.Flush();
                    code = reader.ReadLine();
                }
                else
                {
                    code = "Error connecting to the server";
                }

            }
            catch (Exception e)
            {
                code = "Error: " + e.Message;
            }
            return code;
        }

        /**
         * Method that sends a request to the server and trnasforms the answer of the server into a list of the best players.
         */
        public List<Player> getRankingBestPlayers()
        {
            List<Player> bestPlayers = new List<Player>();
            try
            {
                if (client.Connected)
                {
                    String order = "RANKING;";
                    writer.WriteLine(order);
                    writer.Flush();
                    String server;
                    while ( !(server = reader.ReadLine()).Equals("INVALIDORDER"))
                    {
                        if(server.Equals("FINISH"))
                        {
                            break;
                        }

                        Player player = convertMessageToRankingPlayer(server);
                        if (player != null)
                        {
                            bestPlayers.Add(player);
                        }
                    }
                }
                else
                {
                    bestPlayers = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return bestPlayers;
        }
        private Player convertMessageToRankingPlayer(String message)
        {
            Player player = new Player();
            try
            {
                String[] data = message.Split(';');
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine(data[i]);
                }
                player.UserId = int.Parse(data[0]);
                player.Name = data[1];
                player.Trophies = int.Parse(data[2]);
                player.HighestTrophies = int.Parse(data[3]);
                player.Level = int.Parse(data[4]);
                player.MatchesPlayed = int.Parse(data[5]);
                player.MatchesWinned = int.Parse(data[6]);
            }
            catch (Exception e)
            {
                player = null;
                Console.WriteLine(e.Message);
            }
            return player;
        }
        public ClientSocket(string mail, string password, string name)
        {
            startConection();
            user = register(mail, password, name);
        }

        public void startConection()
        {
            try
            {
                client = new TcpClient();
                client.Connect(IPAddress.Parse(IP), PORT);
                writer = new StreamWriter(client.GetStream());
                reader = new StreamReader(client.GetStream());
                if (client.Connected)
                {
                    Console.WriteLine("Client connected");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Player register(string mail, string password, string name)
        {
            Player usr = null;
            try
            {
                if (client.Connected)
                {
                    String order = "REGISTER;" + mail + ";" + password + ";" + name;
                    writer.WriteLine(order);
                    writer.Flush();

                    String messageFromServer = reader.ReadLine();
                    Console.WriteLine(messageFromServer);
                    if (messageFromServer.Equals("INVALIDREGISTER"))
                    {
                        usr = null;
                        Console.WriteLine("Register unsuccesfully");
                    }
                    else if (messageFromServer.StartsWith("INVALIDORDER"))
                    {
                        usr = null;
                        Console.WriteLine("Error: " + messageFromServer);
                    }
                    else
                    {
                        usr = convertMessageToMyPlayer(messageFromServer);
                        Console.WriteLine(messageFromServer);

                        List<Shield> shields = this.getShieldsOfAnUser();
                        if (shields != null)
                        {
                            usr.Shields = shields;
                        }

                        List<Weapon> weapons = this.getWeaponsOfAnUser();
                        if (weapons != null)
                        {
                            usr.Weapons = weapons;
                        }
                        List<Player> friends = this.getFriendsOfUser();
                        if (friends != null)
                        {
                            usr.Friends = friends;
                        }
                    }
                }
                else {
                    usr = null;
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("Connection rejected by the server");   
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return usr;
        }

        public Player login(string mail, string password) {
            Player usr = null;
            try
            {
                if (client.Connected) { 
                    String order = "LOGIN;" + mail + ";" + password;
                    writer.WriteLine(order);
                    writer.Flush();

                    String messageFromServer = reader.ReadLine();
                    if (messageFromServer.StartsWith("USERNOTFOUNDED"))
                    {
                        usr = null;
                        Console.WriteLine("Error: " + messageFromServer);
                    }
                    else if (messageFromServer.StartsWith("INVALIDORDER"))
                    {
                        usr = null;
                        Console.WriteLine("Error: " + messageFromServer);
                    }
                    else
                    {
                        usr = convertMessageToMyPlayer(messageFromServer);
                        Console.WriteLine(messageFromServer);

                        List<Shield> shields = this.getShieldsOfAnUser();
                        if (shields != null)
                        {
                            Console.WriteLine("Shelds added succesfully");
                            usr.Shields = shields;
                        }

                        List<Weapon> weapons = this.getWeaponsOfAnUser();
                        if (weapons != null)
                        {
                            Console.WriteLine("Weapons added succesfully");
                            usr.Weapons = weapons;
                        }
                        List<Player> friends = this.getFriendsOfUser();
                        if (friends!=null)
                        {
                            Console.WriteLine("Weapons added succesfully");
                            usr.Friends = friends;
                        }
                        Console.WriteLine(usr.toString());

                    }
                }
                else
                {
                    usr = null;
                }

            }
            catch (SocketException e) {
                Console.WriteLine("Connection rejected by the server");
            }
            catch (IOException e) {
                Console.WriteLine("Error: "+e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return usr;
        }

        private List<Player> getFriendsOfUser()
        {
            List<Player> friends = new List<Player>();
            if (client.Connected)
            {
                try
                {
                    String order = "GETFRIENDS;";
                    writer.WriteLine(order);
                    writer.Flush();
                    String messageFromServer;
                    while (!(messageFromServer = reader.ReadLine()).Equals("FRIENDSNOTFOUNDED"))
                    {

                        Console.WriteLine("FRIENDS: " + messageFromServer);
                        if (messageFromServer.Equals("FINISH"))
                        {
                            break;
                        }                            
                        Player friend = convertMessageToPlayer(messageFromServer);
                        if (friend != null)
                        {
                            friends.Add(friend);
                        }
                        
                    }

                }
                catch(Exception e)
                {
                    friends = null;
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                friends = null;
            }
            return friends;
        }

        private List<Shield> getShieldsOfAnUser() {
            List<Shield> shields = new List<Shield>();
            if (client.Connected)
            {
                try
                {
                    String order = "GETSHIELDS;";
                    writer.WriteLine(order);
                    writer.Flush();
                    String messageFromServer;
                    while (!(messageFromServer = reader.ReadLine()).Equals("SHIELDSNOTFOUNDED"))
                    {
                        Console.WriteLine("SHIELD: " + messageFromServer);
                        if (messageFromServer.Equals("FINISH"))
                        {
                            break;
                        }

                        Shield shield = convertMessageToShield(messageFromServer);
                        if (shield != null)
                        {
                            shields.Add(shield);
                        }
                    }
                }catch(Exception e)
                {
                    shields = null;
                    Console.WriteLine(e.Message);
                }
            }
            else {
                shields = null;
            }
            return shields;
        }
        private List<Weapon> getWeaponsOfAnUser()
        {
            List<Weapon> weapons = new List<Weapon>();
            if (client.Connected)
            {
                String order = "GETWEAPONS;";
                writer.WriteLine(order);
                writer.Flush();
                String messageFromServer;
                while (!(messageFromServer = reader.ReadLine()).Equals("WEAPONSNOTFOUNDED"))
                {
                    Console.WriteLine("WEAPONS: "+messageFromServer);
                    if (messageFromServer.Equals("FINISH"))
                    {
                        break;
                    }
                        Weapon weapon = convertMessageToWeapon(messageFromServer);
                        if (weapon != null)
                        {
                            weapons.Add(weapon);
                        }
                }
            }
            else
            {
                weapons = null;
            }
            return weapons;
        }
        private Weapon convertMessageToWeapon(string message) {
            Weapon weapon = new Weapon();
            try
            {
                String [] parts = message.Split(';');
                weapon.WeaponId = int.Parse(parts[0]);
                weapon.Name = parts[1];
                weapon.Damage = int.Parse(parts[2]);
                weapon.Effectiveness = int.Parse(parts[3]);
                weapon.Quality = parts[4];
                weapon.Cost = int.Parse(parts[5]);
            }
            catch (Exception e)
            {
                weapon = null;
            }
            return weapon;
        }
        private Shield convertMessageToShield(string message)
        {
            Shield shield = new Shield();
            try {
                String[] parts = message.Split(';');
                shield.ShieldId = int.Parse(parts[0]);
                shield.Name = parts[1];
                shield.DefensePoints = int.Parse(parts[2]);
                shield.Quality = parts[3];
                shield.Cost = int.Parse(parts[4]);
            }
            catch (Exception e)
            {
                Console.WriteLine("SHIELD: "+e.Message);
                shield = null;
            }
            return shield;
            }
        private Player convertMessageToMyPlayer(String message) {
            Player player = new Player();
            try
            {
                String[] data = message.Split(';');
                player.UserId = int.Parse(data[0]);
                player.Mail = data[1];
                player.Password = data[2];
                player.Name = data[3];
                player.Role = data[4];
                player.Trophies = int.Parse(data[5]);
                player.HighestTrophies = int.Parse(data[6]);
                player.Level = int.Parse(data[7]);
                player.Experience = int.Parse(data[8]);
                player.MatchesPlayed = int.Parse(data[9]);
                player.MatchesWinned = int.Parse(data[10]);
            }
            catch (Exception e) {
                player = null;
                Console.WriteLine(e.Message);
            }
            return player;
        }

        private Player convertMessageToPlayer(String message)
        {
            Player player = new Player();
            try
            {
                String[] data = message.Split(';');
                player.UserId = int.Parse(data[0]);
                player.Name = data[1];
                player.Trophies = int.Parse(data[2]);
                player.HighestTrophies = int.Parse(data[3]);
                player.Level = int.Parse(data[4]);
                player.MatchesPlayed = int.Parse(data[5]);
                player.MatchesWinned = int.Parse(data[6]);
            }
            catch (Exception e)
            {
                player = null;
                Console.WriteLine("FRIEND: "+e.Message+message);
            }
            return player;
        }
    }
}
