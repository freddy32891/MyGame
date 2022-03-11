/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game;

import cat.proven.game.model.Model;
import cat.proven.game.model.User;

/**
 *
 * @author fredd
 */
public class Room {

    public Model model = new Model();
    private User user1, user2;
    private String move1 = "";
    private String move2 = "";
    private int CODE;
    private int matchId;
    private int user1Id;
    private int user2Id;

    public Room(int codeRoom, User user, int matchId) {
        this.CODE = codeRoom;
        this.user1 = user;
        this.matchId = matchId;
        this.user1Id = user1.getUserId();
    }

    /**
     * Method that returns the id of your opponent
     *
     * @param user the user of the person who wants to know his opponent id
     * @return the id of the opponent
     */
    public int getOponentId(User user) {
        if (user.getUserId() == user1Id) {
            return user2Id;
        } else {
            return user1Id;
        }
    }

    public boolean setMyTurn(User user, String move) {
        if (user.getUserId().equals(user1Id)) {
            this.move1 = move;
            return true;
        } else if (user.getUserId().equals(user2Id)) {
            this.move2 = move;
            return true;
        } else {
            return false;
        }
    }

    public User getOpponent(User user) {
        if (user.getUserId().equals(user1Id)) {
            return user2;
        } else {
            return user1;
        }
    }

    public User getAvailablePlace() {
        if (user1 == null) {
            return user1;
        } else if (user2 == null) {
            return user2;
        } else {
            return null;
        }
    }

    public boolean joinRoom(User user) {
        if (user1 == null) {
            user1 = user;
            return true;
        } else if (user2 == null) {
            user2 = user;
            user2Id = user.getUserId();
            return true;
        } else {
            return false;
        }

    }

    public User getMyUser(User user) {
        if (user.getUserId().equals(user1Id)) {
            return user1;
        } else {
            return user2;
        }
    }

    public void setMyUser(User user, User nullUser) {
        if (user.getUserId().equals(user1Id)) {
            user1 = nullUser;
        } else {
            user2 = nullUser;
        }
    }

    public int getMatchId() {
        return matchId;
    }

    public void setMatchId(int matchId) {
        this.matchId = matchId;
    }

    /**
     * When the other user wants
     *
     * @param user
     * @return
     */
    public String getTurnFromOponent(User user) {
        String jugadaToReturn;
        if (user.getUserId().equals(user1Id)) {
            jugadaToReturn = move2;
            move2 = "";
        } else {
            jugadaToReturn = move1;
            move1 = "";
        }
        return jugadaToReturn;
    }

    public int getCode() {
        return CODE;
    }

    public boolean accesToTheRoom(int code) {
        return code == CODE;
    }

    public synchronized String executeOrder(String ordreUsuari, User user) {
        int result = 0;
        //String ordreUsuari = br.readLine();
        System.out.println(user.getName() + " says:" + ordreUsuari + "IN ROOM GAME");//mostrem l'ordre de l'usuari
        //EXEMPLE D'ORDRE ATA;2737;50 (order;idWeapon)
        String[] order = ordreUsuari.split(";");
        //System.out.println(parts[0]);
        switch (order[0]) {
            case "ATA":
                result = model.userTurn(order);
                break;
            case "DEF":
                result = model.userTurn(order);
                break;
            case "RCH":
                result = model.userTurn(order);
                break;
            default:
                System.out.println("InvalidOrder " + ordreUsuari + " from " + user.getName());
                result = -1;
                break;
        }
        if (user.getUserId().equals(user1Id)) {
            move1 = ordreUsuari + ";" + result + ";";
        } else {
            move2 = ordreUsuari + ";" + result + ";";
        }
        
        return ordreUsuari + ";" + result + ";";
    }

    @Override
    public int hashCode() {
        int hash = 7;
        hash = 53 * hash + this.CODE;
        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Room other = (Room) obj;
        if (this.CODE != other.CODE) {
            return false;
        }
        return true;
    }

}
