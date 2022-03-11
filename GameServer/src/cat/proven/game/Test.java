/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game;

import cat.proven.game.model.Matches;
import cat.proven.game.model.Model;
import cat.proven.game.model.Shield;
import cat.proven.game.model.User;
import cat.proven.game.model.Usermatch;
import cat.proven.game.model.persist.MatchDao;
import cat.proven.game.model.persist.UserDao;
import java.util.Arrays;
import java.util.Date;
import java.util.List;

/**
 *
 * @author fredd
 */
public class Test {

    public static void main(String[] args) {
        //MatchDao dao = new MatchDao();
        Model dao = new Model();
        List<Usermatch> matches = dao.getAllMatchesOfUser(1);
        int matchId;
        String user;
//        User fredd = dao.findUserById(3);
//        fredd.setTrophies(90);
//        fredd.setLevel(3);
//        fredd.setExperience(14);
//        fredd.setHighestTrophies(111);
//        System.out.println(dao.updateUser(fredd));
//
//        fredd = dao.findUserById(4);
//        fredd.setTrophies(500);
//        fredd.setLevel(9);
//        fredd.setExperience(986);
//        fredd.setHighestTrophies(512);
//        System.out.println(dao.updateUser(fredd));
//
//        fredd = dao.findUserById(5);
//        fredd.setTrophies(100);
//        fredd.setLevel(5);
//        fredd.setExperience(234);
//        fredd.setHighestTrophies(356);
//        System.out.println(dao.updateUser(fredd));
//
//        fredd = dao.findUserById(4);
//        fredd.setTrophies(500);
//        fredd.setLevel(9);
//        fredd.setExperience(986);
//        fredd.setHighestTrophies(512);
//        System.out.println(dao.updateUser(fredd));

//        
//        Date date =  new Date();
//        System.out.println(date.getTime()+"   "+date.toString());
        int winned = 0;
        for (int i = 0; i < matches.size(); i++) {
            if (matches.get(i).getWinned()) {
                winned++;
            }
            //matches.get(i).getUsermatchPK().
            System.out.println("------------------MATCH-----------------");
            System.out.println("- ROUNDS WINNED: " + matches.get(i).getRoundsWinned());
            System.out.println("- WINNED: " + matches.get(i).getWinned());
            user = matches.get(i).getUser().getName();
            int id = matches.get(i).getUser().getUserId();
            System.out.println("- USER: " + user);
            matchId = matches.get(i).getUsermatchPK().getMatchId();
            System.out.println("- MATCH ID:" + matchId);
            System.out.println("- DATE: " + dao.getMatchWhereId(matches.get(i).getUsermatchPK().getMatchId()).getDate());
            List<Usermatch> um = dao.getUsermatchesWhereMatchId(matchId);
            for (int j = 0; j < um.size(); j++) {
                if (um.get(j).getUser().getUserId() != id) {
                    System.out.println("- ENEMY: " + um.get(j).getUser().getName());
                }
            }

            System.out.println("----------------------------------------");
        }

        List<User> players = dao.selectAll();
        for (User player : players) {
            System.out.println(player.toString());
        }
        User[] p = new User[players.size()];
        p = players.toArray(p);
        Arrays.sort(p);
        System.out.println("ORDENADO");
        for (User player : p) {
            System.out.println(player.toString());
        }
        
        String message ="";
        List<Usermatch> m = dao.getAllMatchesOfUser(1);
        System.out.println(m.size());
        if (m != null) {
            int win = 0;
            for (int i = 0; i < m.size(); i++) {
                System.out.println(m.get(i).toString());
                if (m.get(i).getWinned()) {
                    win++;
                }
            }
            message = m.size() + ";" + win;
        } else {
            message = "0;0";
        }
        System.out.println(message);

//        String partes = "hola;buena;tardes;como";
//        String partes2 = "hola;buena;tardes;como;";
//        String [] part = partes.split(";");
//        System.out.println("PRIMERO SIN ; FINAL");
//        for (int i  = 0; i<part.length;i++){
//            System.out.println(part[i]);
//        }
//        
//        part = partes2.split(";");
//        System.out.println("SEGUNDP CON ; FINAL");
//        for (int i  = 0; i<part.length;i++){
//            System.out.println(part[i]);
//        }
//        System.out.println();
//
//        System.out.println("MATCHES PLAYED: " + matches.size() + "\nMATCHES WINNED: " + winned);
//        UserDao dao = new UserDao();
//        System.out.println(dao.addFriend(8,1));
//        System.out.println("TEST");
//        List<Shield> shields = (List<Shield>) dao.findUserById(1).getShieldCollection();
//        for(int i = 0; i<shields.size();i++){
//            System.out.println(shields.get(i).toString());
//        }
        List<User> users = dao.selectAll();

    }
}
