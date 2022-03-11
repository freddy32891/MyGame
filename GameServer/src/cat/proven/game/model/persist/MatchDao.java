/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game.model.persist;

import cat.proven.game.model.Matches;
import cat.proven.game.model.Shield;
import cat.proven.game.model.Usermatch;
import cat.proven.game.model.Weapon;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;
import java.util.Random;
import javax.persistence.EntityExistsException;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;
import javax.persistence.RollbackException;
import javax.persistence.TypedQuery;

/**
 *
 * @author Alumne
 */
public class MatchDao {

    private final EntityManager entity;

    public MatchDao() {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("GameModelPU");
        entity = emf.createEntityManager();
    }

    public EntityManager getEntityManager() {
        return entity;
    }

    public List<Usermatch> selectUserMatchesWhereMatchId(Integer matchId) {
        List<Usermatch> usermatch = null;
        try {
            EntityManager em = entity;
            TypedQuery<Usermatch> query = em.createNamedQuery("Usermatch.findByMatchId", cat.proven.game.model.Usermatch.class);
            query.setParameter("matchId", matchId);
            usermatch = query.getResultList();
        } catch (Exception e) {
            usermatch = null;
            System.out.println(e.getMessage());
        }
        return usermatch;
    }

    public List<Usermatch> selectUserMatchWhereUserId(Integer userId) {
        List<Usermatch> matches;
        try {
            EntityManager em = entity;
            TypedQuery<Usermatch> query = em.createNamedQuery("Usermatch.findByUserId", cat.proven.game.model.Usermatch.class);
            query.setParameter("userId", userId);
            matches = query.getResultList();
        } catch (Exception e) {
            matches = null;
            System.out.println(e.getMessage());
            e.printStackTrace();
        }
        return matches;
    }

    public int delete(Integer matchId) {
        int result = 0;
        EntityManager em = getEntityManager();
        EntityTransaction et = em.getTransaction();
        try {
            et.begin();
            Matches user = this.selectWhereId(matchId);
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

    public Matches selectWhereId(Integer matchId) {
        Matches match = null;
        try {
            EntityManager em = entity;
            TypedQuery<Matches> query = em.createNamedQuery("Matches.findByMatchId", cat.proven.game.model.Matches.class);
            query.setParameter("matchId", matchId);
            match = query.getSingleResult();
        } catch (Exception e) {
            match = null;
        }
        return match;
    }

    /**
     * Method that creates a match in the database
     *
     * @return the id of the match or a negative number in case of error
     */
    public int createMatch() {
        int result = 0;
        try {
            EntityManager em = this.getEntityManager();
            EntityTransaction et = em.getTransaction();
            et.begin();
            java.util.Date dt = new java.util.Date();
            Matches match = new Matches();
            match.setDate(dt);
            em.persist(match);
            et.commit();
            result = match.getMatchId();
        } catch (RollbackException e) {
            result = 0;
            System.out.println(e.getMessage());
        } catch (EntityExistsException e) {
            result = 0;
            System.out.println(e.getMessage());
        } catch (Exception e) {
            result = 0;
            System.out.println(e.getMessage());
        }
        return result;
    }

    public int saveMatch(Integer matchId, Integer userWinner, Integer userNotWinner, Integer rWinned) {
        int result = 0;
        try {
            EntityManager em = this.getEntityManager();
            EntityTransaction et = em.getTransaction();
            et.begin();
            Usermatch u = new Usermatch(matchId, userWinner);
            u.setRoundsWinned(rWinned);
            u.setWinned(true);
            em.persist(u);
            Usermatch u2 = new Usermatch(matchId, userNotWinner);
            u2.setRoundsWinned(3 - rWinned);
            u2.setWinned(false);
            em.persist(u2);
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

    public Weapon selectWhereWeaponId(Integer weaponId) {
        Weapon weapon = null;
        try {
            EntityManager em = entity;
            TypedQuery<Weapon> query = em.createNamedQuery("Weapon.findByWeaponId", cat.proven.game.model.Weapon.class);
            query.setParameter("weaponId", weaponId);
            weapon = query.getSingleResult();
        } catch (Exception e) {
            weapon = null;
        }
        return weapon;
    }

    public Shield selectWhereShieldId(Integer shieldId) {
        Shield shield = null;
        try {
            EntityManager em = entity;
            TypedQuery<Shield> query = em.createNamedQuery("Shield.findByShieldId", cat.proven.game.model.Shield.class);
            query.setParameter("shieldId", shieldId);
            shield = query.getSingleResult();
        } catch (Exception e) {
            shield = null;
        }
        return shield;
    }

    public double turnResult(String[] userOrder1, String[] userOrder2) {
        double result;
        if (validateUserOrder(userOrder1)) {
            if (validateUserOrder(userOrder2)) {
                double user1 = turnUser(userOrder1);
                double user2 = turnUser(userOrder2);
                result = user1 + user2;
                System.out.println("User1 = " + user1 + " User2 = " + user2);
            } else {
                result = -22222;
            }
        } else {
            result = -11111;
        }

        return result;
    }

    public int turnUser(String[] userOrder) {
        int result = 0;
        //"ATA;3" exampleOfORder
        switch (userOrder[0]) {
            case "ATA":
                Integer weaponId = Integer.parseInt(userOrder[1]);
                Weapon weapon = this.selectWhereWeaponId(weaponId);
                if (weapon != null) {
                    if (successfulShot(weapon.getEffectiveness())) {
                        result = weapon.getDamage()*-1;
                    } else {
                        result = 0;
                    }
                } else {
                    result = -44444;
                }
                break;
            case "DEF":
                Integer shieldId = Integer.parseInt(userOrder[1]);
                Shield shield = selectWhereShieldId(shieldId);
                if (shield != null) {
                    result = shield.getDefensePoints();
                } else {
                    result = -44444;
                }

                break;
            case "RCH":
                result = 1;
                break;
            default:
                result = 0;
                break;
        }

        return result;
    }

    public boolean successfulShot(Integer effectiveness) {
        Random rnd = new Random();
        int result = rnd.nextInt(100);
        return result < effectiveness;
    }

    public boolean validateUserOrder(String[] userOrder) {
        boolean result = false;
        if (userOrder != null) {
            if (userOrder.length >= 2) {
                result = true;
            }
        }
        return result;
    }

}
