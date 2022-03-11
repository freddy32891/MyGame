/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game;

import cat.proven.game.model.Model;
import cat.proven.game.model.Shield;
import cat.proven.game.model.User;
import cat.proven.game.model.Usermatch;
import cat.proven.game.model.Weapon;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.EOFException;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.Socket;
import java.net.SocketException;
import java.util.Arrays;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author fredd
 */
public class Hilo extends Thread {

    private Socket socket;
    private BufferedReader reader;
    private BufferedWriter writer;
    private MainServer server;
    private User user;
    public Model model;
    private Room room;

    public Hilo(Socket socket) {
        this.model = new Model();
        this.socket = socket;
    }

    Hilo(Socket socket, MainServer server) {
        this.socket = socket;
        this.server = server;
        this.model = new Model();
        this.user = new User("Unknown user");
    }

    @Override
    public void run() {
        try {
            System.out.println("Client connected: " + socket.getRemoteSocketAddress());
            boolean exit = false;
            reader = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            writer = new BufferedWriter(new OutputStreamWriter(socket.getOutputStream()));
            do {
                try {
                    exit = executeOrder();
                } catch (SocketException | EOFException ex) {
                    exit = true;
                }
            } while (!exit);//no surt fins que el metode envia un true
            socket.close();
            System.out.println("Client " + user.getName() + " disconnected. ");
            reader.close();
            writer.close();
            server.getClients().remove(user);
        } catch (IOException ex) {
            //   Logger.getLogger(Hilo.class.getName()).log(Level.SEVERE, null, ex);
            System.out.println(ex.getMessage());
        }
    }

    private boolean executeOrder() throws IOException {
        boolean result = false;
        String ordreUsuari = "";

        ordreUsuari = reader.readLine();
        if (ordreUsuari != null) {
            //EXAMPLE ORDER ATA;2737;50 (order;idWeapon)
            String[] parts = ordreUsuari.split(";");
            System.out.println("Client  " + user.getName() + " says: " + ordreUsuari);
            switch (parts[0]) {
                case "GETFRIENDS":
                    getUserFriends();
                    break;
                case "LOGIN":
                    result = login(parts);
                    break;
                case "REGISTER":
                    result = register(parts);
                    break;
                case "FINDUSERBYNAME":
                    findUserByName(parts);
                    break;
                case "FINDUSERBYID":
                    findUserById(parts);
                    break;
                case "LISTMATCHES":
                    listAllMatches(parts);
                    break;
                case "ADDFRIEND":
                    addFriend(parts);
                    break;
                case "GETROOMCODE":
                    createCode();
                    break;
                case "CREATEROOM":
                    startBatle(parts);
                    break;
                case "JOINPRIVATEROOM":
                    joinPrivateBatle(parts);
                    break;
                case "PLAY":
                    play(parts);
                    break;
                case "SAVEMATCH":
                    saveMatch(parts);
                    break;
                case "CHANGENAME":
                    changeName(parts);
                    break;
                case "RANKING":
                    listBestPayers();
                    break;
                case "UPDATEUSER":
                    updateUser(parts);
                    break;
                case "GETSHIELDS":
                    getUserShields();
                    break;
                case "GETWEAPONS":
                    getUserWeapons();
                    break;
                default:
                    invalidOrder(ordreUsuari);
            }
        } else {
            result = true;
        }
        return result;
    }

    public void invalidOrder(String ordreUsuari) throws IOException {
        String missatgeError = "INVALIDORDER";
        this.sendMessageToUser(missatgeError);
        System.out.println(missatgeError + " " + ordreUsuari);
    }

    public boolean quitOrder() {
        boolean salir;
        //en cas de que posi quit
        System.out.println("Client disconnected");
        salir = true;
        return salir;
    }

    private String getMatchesPlayedAndWinned(int userId) {
        String message = "";
        List<Usermatch> matches = model.getAllMatchesOfUser(userId);
        if (matches != null) {
            int winned = 0;
            for (int i = 0; i < matches.size(); i++) {
                if (matches.get(i).getWinned()) {
                    winned++;
                }
            }
            message = matches.size() + ";" + winned;
        } else {
            message = "0;0";
        }
        return message;
    }

    private boolean login(String[] parts) {
        boolean exit = false;
        user = model.login(parts[1], parts[2]);
        try {
            if (user != null) {
                String sendToClient = convertMyUserToString(user);
                String matchesPW = this.getMatchesPlayedAndWinned(user.getUserId());
                sendToClient = sendToClient + matchesPW;
                this.sendMessageToUser(sendToClient);
                exit = false;
                server.getClients().add(user);
            } else {
                this.sendMessageToUser("USERNOTFOUNDED");
                exit = true;
            }
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return exit;
    }

    private void getUserShields() {
        String messageToClient = "";
        List<Shield> shields = (List<Shield>) user.getShieldCollection();
        try {
            if (!shields.isEmpty()) {
                for (int i = 0; i < shields.size(); i++) {
                    messageToClient = this.convertShieldToString(shields.get(i));
                    this.sendMessageToUser(messageToClient);
                }
                messageToClient = "FINISH";
                this.sendMessageToUser(messageToClient);
            } else {
                messageToClient = "SHIELDSNOTFOUNDED";
                this.sendMessageToUser(messageToClient);
            }
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }

    private void getUserWeapons() {
        String messageToClient = "";
        List<Weapon> weapons = (List<Weapon>) user.getWeaponCollection();
        try {
            if (!weapons.isEmpty()) {
                for (int i = 0; i < weapons.size(); i++) {
                    messageToClient = this.convertWeaponToString(weapons.get(i));
                    this.sendMessageToUser(messageToClient);
                }
                messageToClient = "FINISH";
                this.sendMessageToUser(messageToClient);
            } else {
                messageToClient = "WEAPONSNOTFOUNDED";
                this.sendMessageToUser(messageToClient);
            }
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }

    private void getUserFriends() {
        List<User> users = model.getUserFriends(user.getUserId());
        if (users != null) {
            User[] p = new User[users.size()];
            p = users.toArray(p);
            Arrays.sort(p);
            for (int i = 0; i < p.length; i++) {
                try {
                    if (p[i] != null) {
                        String messageToClient = this.convertUserToString(p[i]);
                        String matchesWP = this.getMatchesPlayedAndWinned(p[i].getUserId());
                        messageToClient = messageToClient + matchesWP;
                        this.sendMessageToUser(messageToClient);
                    }
                } catch (IOException ex) {
                    System.out.println(ex.toString());
                }
            }
            try {
                this.sendMessageToUser("FINISH");
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        } else {
            try {
                this.sendMessageToUser("FRIENDSNOTFOUNDED");
            } catch (IOException ex) {
                System.out.println(ex.getMessage());
            }
        }
    }

    private void listAllMatches(String[] parts) {
        //int userId = Integer.parseInt(parts[1]);
        List<Usermatch> matches = model.getAllMatchesOfUser(user.getUserId());
        if (matches != null) {
            int matchId;
            String userName;
            for (int i = 0; i < matches.size(); i++) {
                try {
                    System.out.println("- ROUNDS WINNED: " + matches.get(i).getRoundsWinned());
                    System.out.println("- WINNED: " + matches.get(i).getWinned());
                    userName = matches.get(i).getUser().getName();
                    System.out.println("- USER: " + userName);
                    matchId = matches.get(i).getUsermatchPK().getMatchId();
                    System.out.println("- MATCH ID:" + matchId);
                    System.out.println("- DATE: " + model.getMatchWhereId(matches.get(i).getUsermatchPK().getMatchId()).getDate());
                    List<Usermatch> um = model.getUsermatchesWhereMatchId(matchId);
                    for (int j = 0; j < um.size(); j++) {
                        if (!um.get(j).getUser().getName().equals(userName)) {
                            System.out.println("- ENEMY: " + um.get(j).getUser().getName());
                            System.out.println("- ENEMY ID: " + um.get(j).getUser().getUserId());
                        }
                    }
                    //TODO
                    this.sendMessageToUser("");
                } catch (IOException ex) {
                    System.out.println("Partida: " + matches.get(i).toString() + " no enviado");

                }
            }
            try {
                this.sendMessageToUser("FINISH");
                System.out.println("END SENDING MATCHES");
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        } else {
            try {
                this.sendMessageToUser("MATCHESNOTFOUNDED");
            } catch (IOException ex) {
                System.out.println(ex.getMessage());
            }
        }
    }

    private void findUserByName(String[] parts) {
        List<User> users = model.findUsersByName(parts[1]);
        if (users != null) {
            for (int i = 0; i < users.size(); i++) {
                try {
                    String userToSend = this.convertMyUserToString(users.get(i));
                    this.sendMessageToUser(userToSend);
                    System.out.println("User: " + users.get(i).toString() + " enviado");
                } catch (IOException ex) {
                    System.out.println("User: " + users.get(i).toString() + " no enviado");
                }
            }
            try {
                writer.write("FINISH");
                System.out.println("FIN DE ENVIO");
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        } else {
            try {
                this.sendMessageToUser("NOTFOUNDED");
                System.out.println("Error, user not founded by name");
            } catch (IOException ex) {
                System.out.println(ex.getMessage());
            }
        }
    }

    private void findUserById(String[] parts) {
        User user = model.findUserById(Integer.parseInt(parts[1]));
        try {
            if (user != null) {
                String userToSend = this.convertUserToString(user);
                this.sendMessageToUser(userToSend);

            } else {
                this.sendMessageToUser("FINISH");
            }
        } catch (NumberFormatException e) {
            System.out.println(e.getMessage());
            try {
                this.sendMessageToUser("INVALIDVALUES");
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }

    private void addFriend(String[] parts) {
        try {
            int result = model.addFriend(Integer.parseInt(parts[1]), Integer.parseInt(parts[2]));
            this.sendMessageToUser(result + "");

        } catch (NumberFormatException e) {
            System.out.println(e.getMessage());
            try {
                this.sendMessageToUser("INVALIDVALUES");
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }

    }

    private void createCode() {
        int n = (int) (Math.random() * (99999 - 10000)) + 10000;
        boolean codeRepeated = false;
        try {
            for (Room r : this.server.getRooms()) {
                if (r.getCode() == n) {
                    codeRepeated = true;
                }
            }
            if (!codeRepeated) {
                this.sendMessageToUser(n + "");
            } else {
                createCode();
            }
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }

//TODO REMEMBER TO REMOVE ROOM IF 2 USERS CONNECTED
    private void startBatle(String[] parts) {
        boolean exit = false;
        boolean playing = false;
        int codeRoom = Integer.parseInt(parts[1]);
        try {
            //int result = model.createMatch();
            int matchId = 21;
            if (!server.getRooms().contains(room)) {
                this.room = new Room(codeRoom, user, matchId);
                server.getRooms().add(room);
            }
            System.out.println("Waiting for another player....");
            //
//            while (!exit) {
            try {
                if (room.getOpponent(user) != null) {//if the oponent is connected to the room
                    this.sendMessageToUser("CONNECTED;" + room.getOpponent(user).getName());
                    exit = true;
                    playing = true;
                    System.out.println("USER " + room.getMyUser(user).getName() + " AND " + room.getOpponent(user).getName() + " ARE PLAYING IN A ROOM");

                } else {
                    this.sendMessageToUser("WAITING");
                }
            } catch (SocketException | EOFException ex) {
                this.room.setMyUser(user, null);
                System.out.println(ex.getMessage());

            }
            //  }
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }

    private void joinPrivateBatle(String[] parts) {
        boolean playing = false;
        try {
            int code = Integer.parseInt(parts[1]);
            List<Room> rooms = server.getRooms();
            for (int i = 0; i < rooms.size(); i++) {
                if (rooms.get(i).getCode() == code) {
                    room = rooms.get(i);
                }
            }
            if (room != null) {
                if (room.joinRoom(user)) {
                    this.sendMessageToUser("JOINED;" + room.getOpponent(user).getName());
                } else {
                    this.sendMessageToUser("FULL ROOM;");
                }
                //this.server.getRooms().remove(room);
            } else {
                this.sendMessageToUser("ROOM NOT FOUNDED;");
            }

        } catch (Exception e) {
            e.printStackTrace();
            System.out.println(e.getMessage());
        }
    }

    private void play(String[] parts) {
        String turnFromOponent;
        try {
            if (room != null) {
                try {
                    if (room.getOpponent(user) != null) { //In case that the other player is also connected
                        //this.sendMessageToUser("CONNECTED;" + room.getUser2().getName());
                        //EXAMPLE play;ATA;8 //play;FINISH;0
                        String resultOfTheTurn = "";
                        System.out.println(user.getName() + " in the sw" + parts[1]);
                        switch (parts[1]) {
                            case "QUIT":
                                System.out.println(user.getName() + "QUIT");
                                room.setMyTurn(user, "QUIT");
                                room.setMyUser(user, null);
                                break;
                            case "FINISH":
                                System.out.println(user.getName() + "FINISH");
                                break;
                            default: //In case the order is ATTACK, DEFENSE OR RECHARGE
                                resultOfTheTurn = room.executeOrder(parts[1] + ";" + parts[2], user);
                                turnFromOponent = room.getTurnFromOponent(user);

                                while (turnFromOponent.equals("")) {
                                    turnFromOponent = room.getTurnFromOponent(user);
                                    if (!turnFromOponent.equals("")) {
                                        System.out.println("Founded: " + turnFromOponent);
                                    }
                                }
                                    this.sendMessageToUser(resultOfTheTurn + turnFromOponent);
                                    System.out.println("SENDED TO " + user.getName() + "    " + resultOfTheTurn + turnFromOponent);
                                break;
                        }
                    } else { //If the other player is disconnected
                        //TODOSAVEMATCH
                        System.out.println("YOUWIN");
                    }
                } catch (SocketException | EOFException ex) {
                    room.setMyUser(user, null);
                    System.out.println(ex.getMessage());
                }

            } else {
                System.out.println(user.getName() + " ROOM IS NULL");
            }
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }

    private void saveMatch(String[] parts) {
        try {
            int result = model.saveMatch(Integer.parseInt(parts[2]), Integer.parseInt(parts[3]), Integer.parseInt(parts[4]), Integer.parseInt(parts[5]));
            writer.write(String.valueOf(result));
        } catch (NumberFormatException e) {
            System.out.println(e.getMessage());
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }

    private void changeName(String[] parts) {
        try {
            User user = model.changeName(Integer.parseInt(parts[1]), parts[2]);
            String message = this.convertMyUserToString(user);
            this.sendMessageToUser(message);
        } catch (NumberFormatException e) {
            try {
                this.sendMessageToUser("FINISH");
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
            ex.printStackTrace();
        }
    }

    private void listBestPayers() {
        List<User> users = model.selectAll();
        if (users != null) {
            User[] p = new User[users.size()];
            p = users.toArray(p);
            Arrays.sort(p);
            for (User usr : p) {
                try {
                    String userToSend = this.convertUserToString(usr);
                    String matchesPW = this.getMatchesPlayedAndWinned(usr.getUserId());
                    userToSend += matchesPW;
                    this.sendMessageToUser(userToSend);
                } catch (IOException ex) {
                    System.out.println("User: " + usr.toString() + " not sended");
                }
            }
            try {
                this.sendMessageToUser("FINISH");
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        } else {
            try {
                this.sendMessageToUser("FINISH");
                System.out.println("Error retrienving data");
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        }
    }

    private void updateUser(String[] parts) {
        try {
            User user = convertMessageToUser(parts);
            if (user != null) {
                int result = model.updateUser(user);
                sendMessageToUser(result + "");
            } else {
                this.sendMessageToUser("-5");
            }
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }

    /**
     * Method that recieves an array with the request of the user, registers the
     * user in to the database and returns all the information of the user. In
     * case of error, it sends an error message to the user.
     *
     * @param parts the array with the request of the user
     */
    private boolean register(String[] parts) {
        boolean result = true;
        user = model.register(parts[1], parts[2], parts[3]);
        try {
            if (user != null) {
                String sendToClient = this.convertMyUserToString(user);
                String matchesPW = this.getMatchesPlayedAndWinned(user.getUserId());
                sendToClient = sendToClient + matchesPW;
                this.sendMessageToUser(sendToClient);
                System.out.println("Register Succesful");
                result = false;
                server.getClients().add(user);
            } else {
                sendMessageToUser("INVALIDREGISTER");
                System.out.println("Register not succesful");
                result = true;
            }
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return result;
    }

    /**
     * Method that convets an array of string to an user
     *
     * @param parts he arraya sended by the user
     * @return an user or null in case of error
     */
    private User convertMessageToUser(String[] parts) {
        User usr = new User();

        try {
            usr.setUserId(Integer.parseInt(parts[1]));
            usr.setName(parts[2]);
            usr.setTrophies(Integer.parseInt(parts[3]));
            usr.setHighestTrophies(Integer.parseInt(parts[4]));
            usr.setExperience(Integer.parseInt(parts[5]));
            usr.setLevel(Integer.parseInt(parts[6]));
        } catch (Exception e) {
            System.out.println(e.getMessage());
            usr = null;
        }
        return usr;
    }

    /**
     * Method that converts an user to a string to send to the client
     *
     * @param user to send
     * @return a strting with all the information of a user
     */
    private String convertMyUserToString(User user) {
        if (user != null) {
            return user.getUserId() + ";" + user.getMail() + ";" + user.getPassword() + ";" + user.getName() + ";" + user.getRole() + ";" + user.getTrophies() + ";" + user.getHighestTrophies() + ";" + user.getLevel() + ";" + user.getExperience() + ";";
        } else {
            return "INVALIDUSER";
        }

    }

    private String convertUserToString(User user) {
        return user.getUserId() + ";" + user.getName() + ";" + user.getTrophies() + ";" + user.getHighestTrophies() + ";" + user.getLevel() + ";";
    }

    private String convertShieldToString(Shield shield) {
        return shield.getShieldId() + ";" + shield.getName() + ";" + shield.getDefensePoints() + ";" + shield.getQuality() + ";" + shield.getCost() + ";";
    }

    private String convertWeaponToString(Weapon weapon) {
        return weapon.getWeaponId() + ";" + weapon.getName() + ";" + weapon.getDamage() + ";" + weapon.getEffectiveness() + ";" + weapon.getQuality() + ";" + weapon.getCost() + ";";
    }

    /**
     * Method that sends a message to the user
     *
     * @param message to send
     * @throws IOException in case of an error
     */
    private void sendMessageToUser(String message) throws IOException {
        writer.write(String.valueOf(message));
        writer.newLine();
        writer.flush();
    }

    private User[] orderByTrophies(List<User> users) {
        User[] p = new User[users.size()];
        p = users.toArray(p);
        Arrays.sort(p);
        return p;
    }

}
