/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game.model;

import java.io.Serializable;
import java.util.Collection;
import javax.persistence.Basic;
import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.JoinTable;
import javax.persistence.ManyToMany;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author fredd
 */
@Entity
@Table(name = "user")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "User.findAll", query = "SELECT u FROM User u"),
    @NamedQuery(name = "User.findByUserId", query = "SELECT u FROM User u WHERE u.userId = :userId"),
    @NamedQuery(name = "User.findByMail", query = "SELECT u FROM User u WHERE u.mail = :mail"),
    @NamedQuery(name = "User.findByPassword", query = "SELECT u FROM User u WHERE u.password = :password"),
    @NamedQuery(name = "User.findByCredentials", query = "SELECT u FROM User u WHERE u.mail = :mail AND u.password = :password"),
    @NamedQuery(name = "User.findByName", query = "SELECT u FROM User u WHERE u.name = :name"),
    @NamedQuery(name = "User.findByRole", query = "SELECT u FROM User u WHERE u.role = :role"),
    @NamedQuery(name = "User.findByTrophies", query = "SELECT u FROM User u WHERE u.trophies = :trophies"),
    @NamedQuery(name = "User.findByHighestTrophies", query = "SELECT u FROM User u WHERE u.highestTrophies = :highestTrophies"),
    @NamedQuery(name = "User.findByLevel", query = "SELECT u FROM User u WHERE u.level = :level"),
    @NamedQuery(name = "User.findByExperience", query = "SELECT u FROM User u WHERE u.experience = :experience")})
public class User implements Serializable, Comparable<User> {

    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "user_id")
    private Integer userId;
    @Basic(optional = false)
    @Column(name = "mail")
    private String mail;
    @Basic(optional = false)
    @Column(name = "password")
    private String password;
    @Column(name = "name")
    private String name;
    @Column(name = "role")
    private String role;
    @Column(name = "trophies")
    private Integer trophies;
    @Column(name = "highest_trophies")
    private Integer highestTrophies;
    @Column(name = "level")
    private Integer level;
    @Column(name = "experience")
    private Integer experience;
    @JoinTable(name = "usershield", joinColumns = {
        @JoinColumn(name = "user_id", referencedColumnName = "user_id")}, inverseJoinColumns = {
        @JoinColumn(name = "shield_id", referencedColumnName = "shield_id")})
    @ManyToMany
    private Collection<Shield> shieldCollection;
    @JoinTable(name = "userfriend", joinColumns = {
        @JoinColumn(name = "user_id", referencedColumnName = "user_id")}, inverseJoinColumns = {
        @JoinColumn(name = "friend_id", referencedColumnName = "user_id")})
    @ManyToMany
    private Collection<User> userCollection;
    @ManyToMany(mappedBy = "userCollection")
    private Collection<User> userCollection1;
    @JoinTable(name = "userweapon", joinColumns = {
        @JoinColumn(name = "user_id", referencedColumnName = "user_id")}, inverseJoinColumns = {
        @JoinColumn(name = "weapon_id", referencedColumnName = "weapon_id")})
    @ManyToMany
    private Collection<Weapon> weaponCollection;
    @OneToMany(cascade = CascadeType.ALL, mappedBy = "user")
    private Collection<Usermatch> usermatchCollection;

    public User() {
    }

    public User(Integer userId) {
        this.userId = userId;
    }

    public User(String name) {
        this.name = name;
    }

    public User(Integer userId, String mail, String password) {
        this.userId = userId;
        this.mail = mail;
        this.password = password;
    }

    public User(String mail, String password) {
        this.mail = mail;
        this.password = password;
    }

    public User(Integer userId, String name) {
        this.name = name;
        this.userId = userId;
    }

    public Integer getUserId() {
        return userId;
    }

    public void setUserId(Integer userId) {
        this.userId = userId;
    }

    public String getMail() {
        return mail;
    }

    public void setMail(String mail) {
        this.mail = mail;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        this.role = role;
    }

    public Integer getTrophies() {
        return trophies;
    }

    public void setTrophies(Integer trophies) {
        this.trophies = trophies;
    }

    public Integer getHighestTrophies() {
        return highestTrophies;
    }

    public void setHighestTrophies(Integer highestTrophies) {
        this.highestTrophies = highestTrophies;
    }

    public Integer getLevel() {
        return level;
    }

    public void setLevel(Integer level) {
        this.level = level;
    }

    public Integer getExperience() {
        return experience;
    }

    public void setExperience(Integer experience) {
        this.experience = experience;
    }

    @XmlTransient
    public Collection<Shield> getShieldCollection() {
        return shieldCollection;
    }

    public void setShieldCollection(Collection<Shield> shieldCollection) {
        this.shieldCollection = shieldCollection;
    }

    @XmlTransient
    public Collection<User> getUserCollection() {
        return userCollection;
    }

    public void setUserCollection(Collection<User> userCollection) {
        this.userCollection = userCollection;
    }

    @XmlTransient
    public Collection<User> getUserCollection1() {
        return userCollection1;
    }

    public void setUserCollection1(Collection<User> userCollection1) {
        this.userCollection1 = userCollection1;
    }

    @XmlTransient
    public Collection<Weapon> getWeaponCollection() {
        return weaponCollection;
    }

    public void setWeaponCollection(Collection<Weapon> weaponCollection) {
        this.weaponCollection = weaponCollection;
    }

    @XmlTransient
    public Collection<Usermatch> getUsermatchCollection() {
        return usermatchCollection;
    }

    public void setUsermatchCollection(Collection<Usermatch> usermatchCollection) {
        this.usermatchCollection = usermatchCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (userId != null ? userId.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof User)) {
            return false;
        }
        User other = (User) object;
        if ((this.userId == null && other.userId != null) || (this.userId != null && !this.userId.equals(other.userId))) {
            return false;
        }
        return true;
    }

    @Override
    public int compareTo(User o) {
        if (trophies < o.getTrophies()) {
            return 1;
        }
        if (trophies > o.getTrophies()) {
            return -1;
        }
        return 0;
    }

//    @Override
//    public String toString() {
//        return "cat.proven.game.model.User[ userId=" + userId + " ]";
//    }

    @Override
    public String toString() {
        return "User{" + "userId=" + userId + ", mail=" + mail + ", password=" + password + ", name=" + name + ", role=" + role + ", trophies=" + trophies + ", highestTrophies=" + highestTrophies + ", level=" + level + ", experience=" + experience + '}';
    }
}
