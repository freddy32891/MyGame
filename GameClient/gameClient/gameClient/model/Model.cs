using gameClient.model;
using gameClient.model.persist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameClient
{
    public class Model
    {
        private ClientSocket client;

        public ClientSocket getClientSocket() {
            return client;
        }
        public Model(string mail, string password)
        {
            client = new ClientSocket(mail, password);
        }

        public Model(string mail, string password, string name)
        {
            client = new ClientSocket(mail, password, name);
        }

        public Model()
        {
            client = new ClientSocket();
        }

        internal string play(String message)
        {
            return client.play(message); 
        }

        internal string createRoom()
        {
            return client.createRoomCode();
        }

        internal Player login(string mail, string password)
        {
            return client.login(mail,password);
        }

        internal bool disconnect()
        {
            return client.disconnect();
        }

        internal Player register(string mail, string password, string name)
        {
            return client.register(mail, password, name);
        }

        internal String joinPrivateRoom(string roomCode)
        {
            return client.joinPrivateRoon(roomCode);        }

        internal string createMatch(string code)
        {
            return client.createRoom(code);
        }

        /**
         * Method that calls the class client socket to communicate with the server and return a list with the ranking of the best players
         */
        public List<Player> getBestPlayers()
        {
            return client.getRankingBestPlayers();
        }
    }
}
