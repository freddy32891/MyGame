using gameClient.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameClient
{
    public class MainController
    {
        Model model;
        public Model getModel() {
            return model;
        }
        public MainController() {
            model = new Model();
        }
        public MainController(string mail, string password) {
            model = new Model(mail, password);
        }
        public MainController(string mail, string password, string name)
        {
            model = new Model( mail,  password,  name);
        }
        public String play(String message) { 
            return model.play(message);
        }

        public List<Player> getRankingOfBestPlayers() {
            return model.getBestPlayers();
        }

        internal String createRoom()
        {
            return model.createRoom();
        }

        internal Player login(String mail, String password)
        {
            return model.login(mail, password);
        }

        internal bool disconnect()
        {
            return model.disconnect();
        }

        internal Player register(string mail, string password, string name)
        {
            return model.register(mail,password,name);
        }

        internal String joinPrivateRoom(string roomCode)
        {
            return model.joinPrivateRoom(roomCode);
        }

        internal string createMatch(string code)
        {
            return model.createMatch(code);        }
    }
}
