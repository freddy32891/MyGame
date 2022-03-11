/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game.model.persist;

import cat.proven.game.model.User;
import java.util.ArrayList;
import java.util.List;
import javax.persistence.EntityExistsException;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;
import javax.persistence.RollbackException;
import javax.persistence.TypedQuery;

/**
 *
 * @author fredd
 */
public class UserDao {

    private final EntityManager entity;
    private final UserByDefault userByDefault;

    //Constructor
    public UserDao() {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("GameModelPU");
        entity = emf.createEntityManager();
        this.userByDefault = new UserByDefault();
    }

    public EntityManager getEntityManager() {
        return entity;
    }

    /**
     * Method that selects all the users in the database
     *
     * @return a list of users or null in case of error
     */
    public List<User> selectAll() {
        List<User> users = new ArrayList<>();
        try {
            EntityManager em = getEntityManager();
            TypedQuery<User> query = em.createNamedQuery("User.findAll", cat.proven.game.model.User.class);
            users = query.getResultList();
        } catch (Exception ex) {
            users = null;
        }
        return users;
    }

    /**
     * Method that selects users by a given name
     *
     * @param name of the users to search
     * @return a list with all the users that contain that name or null in case
     * of error
     */
    public List<User> selectWhereName(String name) {
        List<User> users = new ArrayList<>();
        try {
            EntityManager em = getEntityManager();
            TypedQuery<User> query = em.createNamedQuery("User.findByName", cat.proven.game.model.User.class);
            query.setParameter("name", name);
            users = query.getResultList();
        } catch (Exception e) {
            users = null;
        }
        return users;
    }

    /**
     * Method that selects an user by his credentials (user passworrd)
     *
     * @param mail of the user
     * @param password of the user
     * @return the user or null in case of error
     */
    public User selectWhereCredentials(String mail, String password) {
        User user = null;
        try {
            EntityManager em = getEntityManager();
            TypedQuery<User> query = em.createNamedQuery("User.findByCredentials", cat.proven.game.model.User.class);
            query.setParameter("mail", mail);
            query.setParameter("password", password);
            user = query.getSingleResult();
        } catch (Exception e) {
            user = null;
            System.out.println(e.getMessage());
        }

        return user;
    }

    /**
     * Method that selects an user by his id
     *
     * @param userId the id of the user to search
     * @return the user with the given id or null in case of error
     */
    public User selectWhereUserId(Integer userId) {
        User user = null;
        try {
            EntityManager em = getEntityManager();
            TypedQuery<User> query = em.createNamedQuery("User.findByUserId", cat.proven.game.model.User.class);
            query.setParameter("userId", userId);
            user = query.getSingleResult();
        } catch (Exception e) {
            user = null;
        }
        return user;
    }

    /**
     * Method that inserts a new user in the database
     *
     * @param mail of the user to insert
     * @param password of the user to insert
     * @return the user if succesfully inserted, null in case of
     * rollbackexception, 0 in case of another error
     */
    public User insert(String mail, String password, String name) {
        User result = null;
        try {
            EntityManager em = this.getEntityManager();
            EntityTransaction et = em.getTransaction();
            et.begin();
            User user = userByDefault.getUserByDefault(mail, password, name);
            em.persist(user);
            et.commit();
            result = user;
        } catch (RollbackException e) {
            result = null;
        } catch (EntityExistsException e) {
            result = null;
        } catch (Exception e) {
            result = null;
        }
        return result;
    }

    /**
     * Method that delettes an user by his mail and password
     *
     * @param mail of the user to delete
     * @param password of the user's account
     * @return 1 if succesfully deleted, -1 in case of rollbackexception, 0 in
     * case of another error
     */
    public int delete(String mail, String password) {
        int result = 0;
        EntityManager em = getEntityManager();
        EntityTransaction et = em.getTransaction();
        try {
            et.begin();
            User user = this.selectWhereCredentials(mail, password);
            if (user != null) {
                em.remove(user);
                et.commit();
                result = 1;
            } else {
                result = 0;
            }
        } catch (RollbackException e) {
            result = -1;
        } catch (Exception e) {
            result = 0;
        }
        return result;
    }

    /**
     * Method that deletes a user by his id
     *
     * @param userId the id of the user to delete
     * @return 1 if succesfully updated, -1 in case of rollbackexception, 0 in
     * case of another error
     */
    public int delete(Integer userId) {
        int result = 0;
        EntityManager em = getEntityManager();
        EntityTransaction et = em.getTransaction();
        try {
            et.begin();
            User user = this.selectWhereUserId(userId);
            if (user != null) {
                em.remove(user);
                et.commit();
                result = 1;
            } else {
                result = 0;
            }
        } catch (RollbackException e) {
            result = -1;
        } catch (Exception e) {
            result = 0;
        }
        return result;
    }

    /**
     * Method that updates the name of a given user
     *
     * @param userId the id of the user to update
     * @param name the new name of the user
     * @return 1 if succesfully updated, -1 in case of rollbackexception, 0 in
     * case of another error
     */
    public User update(Integer userId, String name) {
        User result = null;
        try {
            EntityManager em = getEntityManager();
            EntityTransaction et = em.getTransaction();
            et.begin();
            result = this.selectWhereUserId(userId);
            result.setName(name);
            em.merge(result);
            et.commit();
        } catch (RollbackException ex) {
            result = null;
        } catch (Exception ex) {
            result = null;
        }
        return result;
    }

    /**
     * Method that updates a given user
     *
     * @param user with all the modifications
     * @return 1 if succesfully updated, -1 in case of rollbackexception, 0 in
     * case of another error
     */
    public int update(User user) {
        int result = 0;
        try {
            EntityManager em = getEntityManager();
            EntityTransaction et = em.getTransaction();
            et.begin();
            User usr = this.selectWhereUserId(user.getUserId());
            if (usr != null) {
                usr.setExperience(user.getExperience());
                usr.setName(user.getName());
                usr.setTrophies(user.getTrophies());
                usr.setLevel(user.getLevel());
                usr.setHighestTrophies(user.getHighestTrophies());
                em.merge(usr);
            }
            et.commit();
            result = 1;
        } catch (RollbackException ex) {
            result = -1;
        } catch (Exception ex) {
            result = 0;
        }
        return result;
    }

    public int addFriend(Integer userId, Integer friendId) {
        int result = 0;
        try {
            EntityManager em = this.getEntityManager();
            EntityTransaction et = em.getTransaction();
            et.begin();
            User user = this.selectWhereUserId(userId);
            User friend = this.selectWhereUserId(friendId);
            user.getUserCollection().add(friend);
            em.merge(user);
            et.commit();
            result = 1;
        } catch (RollbackException e) {
            result = -1;
            System.out.println(e.getMessage());
        } catch (EntityExistsException e) {
            result = -2;
        } catch (Exception e) {
            result = 0;
            System.out.println(e.getMessage());
        }
        return result;
    }

    public List<User> selectUserFriendsWhereUserId(Integer userId) {
        List<User> friends = new ArrayList<>();
        try {
            User user = this.selectWhereUserId(userId);
            friends = (List<User>) user.getUserCollection();

        } catch (Exception e) {
            friends = null;
        }
        return friends;

    }
}
