/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game.model.persist;

import cat.proven.game.model.Shield;
import cat.proven.game.model.User;
import cat.proven.game.model.Weapon;
import java.util.ArrayList;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.TypedQuery;

/**
 *
 * @author freddy
 */
public class UserByDefault {

    private final EntityManager entity;
    //array with the id's of the weapons
    private final Integer[] WEAPONS_BY_DEFAULT = {
        1, 2, 4
    };
    //array with the id's of the shields
    private final Integer[] SHIELDS_BY_DEFAULT = {
        1, 3
    };
    private final String USER_NAME;
    private final String USER_ROLE;
    private final Integer USER_LEVEL;
    private final Integer USER_EXPERIENCE;
    private final Integer USER_TROPHIES;
    private final Integer USER_MAXTROPHIES;

    public UserByDefault() {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("GameModelPU");
        entity = emf.createEntityManager();
        this.USER_MAXTROPHIES = 0;
        this.USER_LEVEL = 1;
        this.USER_EXPERIENCE = 0;
        this.USER_TROPHIES = 0;
        this.USER_NAME = "player";
        this.USER_ROLE = "player";

    }

    public EntityManager getEntityManager() {
        return entity;
    }

    /**
     * Method that gives default values to a new user in the database
     *
     * @param mail of the new user
     * @param password of the new user
     * @return the user with all the values by default or null in case of error.
     */
    public User getUserByDefault(String mail, String password) {
        User user = null;
        if (getWeaponsByDefault() != null && getShieldsByDefault() != null) {
            user = new User(mail, password);
            user.setExperience(this.USER_EXPERIENCE);
            user.setHighestTrophies(this.USER_MAXTROPHIES);
            user.setTrophies(this.USER_TROPHIES);
            user.setLevel(this.USER_LEVEL);
            user.setName(this.USER_NAME);
            user.setRole(this.USER_ROLE);
            user.setWeaponCollection(getWeaponsByDefault());
            user.setShieldCollection(getShieldsByDefault());
        } else {
            user = null;
        }
        return user;
    }
    
        public User getUserByDefault(String mail, String password,String name) {
        User user = null;
        if (getWeaponsByDefault() != null && getShieldsByDefault() != null) {
            user = new User(mail, password);
            user.setExperience(this.USER_EXPERIENCE);
            user.setHighestTrophies(this.USER_MAXTROPHIES);
            user.setTrophies(this.USER_TROPHIES);
            user.setLevel(this.USER_LEVEL);
            user.setName(name);
            user.setRole(this.USER_ROLE);
            user.setWeaponCollection(getWeaponsByDefault());
            user.setShieldCollection(getShieldsByDefault());
        } else {
            user = null;
        }
        return user;
    }

    /**
     * Method that selects all the weapons given by default
     *
     * @return a list with all the weapons
     */
    public List<Weapon> getWeaponsByDefault() {
        List<Weapon> weapons = new ArrayList<>();
        try {
            for (int i = 0; i < this.WEAPONS_BY_DEFAULT.length; i++) {
                Weapon weapon = this.selectWeaponWhereId(WEAPONS_BY_DEFAULT[i]);
                if (weapon != null) {
                    weapons.add(weapon);
                }
            }
        } catch (Exception e) {
            weapons = null;
        }
        return weapons;
    }

    /**
     * Method that selects the shields given by default
     *
     * @return a list with all the shields by default
     */
    public List<Shield> getShieldsByDefault() {
        List<Shield> shields = new ArrayList<>();
        try {
            for (int i = 0; i < this.SHIELDS_BY_DEFAULT.length; i++) {
                Shield shield = this.selectShieldWhereId(SHIELDS_BY_DEFAULT[i]);
                if (shield != null) {
                    shields.add(shield);
                }
            }
        } catch (Exception e) {
            shields = null;
        }

        return shields;
    }

    /**
     * Method that searchs a weapopn in the database by his id
     *
     * @param weaponId the id of the weapon to search
     * @return the weapon founded or null in case of error
     */
    public Weapon selectWeaponWhereId(Integer weaponId) {
        Weapon weapon = null;
        try {
            EntityManager em = getEntityManager();
            TypedQuery<Weapon> query = em.createNamedQuery("Weapon.findByWeaponId", cat.proven.game.model.Weapon.class);
            query.setParameter("weaponId", weaponId);
            weapon = query.getSingleResult();

        } catch (Exception e) {
            weapon = null;
        }

        return weapon;
    }

    /**
     * Method that searchs a shield in the database by his id
     *
     * @param shieldId the id of the shield to search
     * @return the shield founded or null in case of error
     */
    private Shield selectShieldWhereId(Integer shieldId) {
        Shield shield = null;
        try {
            EntityManager em = getEntityManager();
            TypedQuery<Shield> query = em.createNamedQuery("Shield.findByShieldId", cat.proven.game.model.Shield.class);
            query.setParameter("shieldId", shieldId);
            shield = query.getSingleResult();
        } catch (Exception e) {
            shield = null;
        }
        return shield;
    }
}
