/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game.model;

import cat.proven.game.model.persist.MatchDao;
import cat.proven.game.model.persist.UserDao;
import java.util.List;

/**
 *
 * @author fredd
 */
public class Model {

    private final MatchDao dao;
    private final UserDao user;

    public Model() {
        dao = new MatchDao();
        user = new UserDao();
    }

    public List<Usermatch> getAllMatchesOfUser(Integer idUser) {
        return dao.selectUserMatchWhereUserId(idUser);
    }

    public double playTurn(String[] userOrder1, String[] userOrder2) {
        return dao.turnResult(userOrder1, userOrder2);
    }

    public Matches getMatchWhereId(Integer matchId) {
        return dao.selectWhereId(matchId);
    }

    public List<Usermatch> getUsermatchesWhereMatchId(Integer matchId){
    return dao.selectUserMatchesWhereMatchId(matchId);
    }
    public int userTurn(String[] userOrder) {
        return dao.turnUser(userOrder);
    }

    public int deleteMatch(Integer matchId) {
        return dao.delete(matchId);
    }

    public int createMatch() {
        return dao.createMatch();
    }

    public int saveMatch(Integer matchId, Integer userWinner, Integer userNotWinner, Integer rWinned) {
        return dao.saveMatch(matchId, userWinner, userNotWinner, rWinned);
    }

    public List<User> getUserFriends(Integer userId) {
        if (user.selectWhereUserId(userId) != null) {
            user.selectWhereUserId(userId).getUserCollection().isEmpty();
            return (List<User>) user.selectWhereUserId(userId).getUserCollection();
        } else {
            return null;
        }
    }

    public User findUserById(Integer userId) {
        return user.selectWhereUserId(userId);
    }

    public List<User> findUsersByName(String name) {
        return user.selectWhereName(name);
    }

    public int addFriend(Integer userId, Integer friendId) {
        return user.addFriend(userId, friendId);
    }

    public User changeName(Integer userId, String name) {
        return user.update(userId, name);
    }

    public User login(String mail, String password) {
        return user.selectWhereCredentials(mail, password);
    }

    public List<User> selectAll() {
        return user.selectAll();
    }

    public int updateUser(User usr) {
        return user.update(usr);
    }

    public User register(String mail, String password, String name) {
        return user.insert(mail, password, name);
    }
}
