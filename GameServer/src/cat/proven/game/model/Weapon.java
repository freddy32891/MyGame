/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game.model;

import java.io.Serializable;
import java.util.Collection;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.ManyToMany;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author fredd
 */
@Entity
@Table(name = "weapon")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Weapon.findAll", query = "SELECT w FROM Weapon w"),
    @NamedQuery(name = "Weapon.findByWeaponId", query = "SELECT w FROM Weapon w WHERE w.weaponId = :weaponId"),
    @NamedQuery(name = "Weapon.findByName", query = "SELECT w FROM Weapon w WHERE w.name = :name"),
    @NamedQuery(name = "Weapon.findByDamage", query = "SELECT w FROM Weapon w WHERE w.damage = :damage"),
    @NamedQuery(name = "Weapon.findByEffectiveness", query = "SELECT w FROM Weapon w WHERE w.effectiveness = :effectiveness"),
    @NamedQuery(name = "Weapon.findByQuality", query = "SELECT w FROM Weapon w WHERE w.quality = :quality"),
    @NamedQuery(name = "Weapon.findByCost", query = "SELECT w FROM Weapon w WHERE w.cost = :cost")})
public class Weapon implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "weapon_id")
    private Integer weaponId;
    @Basic(optional = false)
    @Column(name = "name")
    private String name;
    @Column(name = "damage")
    private Integer damage;
    @Column(name = "effectiveness")
    private Integer effectiveness;
    @Column(name = "quality")
    private String quality;
    @Column(name = "cost")
    private Integer cost;
    @ManyToMany(mappedBy = "weaponCollection")
    private Collection<User> userCollection;

    public Weapon() {
    }

    public Weapon(Integer weaponId) {
        this.weaponId = weaponId;
    }

    public Weapon(Integer weaponId, String name) {
        this.weaponId = weaponId;
        this.name = name;
    }

    public Integer getWeaponId() {
        return weaponId;
    }

    public void setWeaponId(Integer weaponId) {
        this.weaponId = weaponId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Integer getDamage() {
        return damage;
    }

    public void setDamage(Integer damage) {
        this.damage = damage;
    }

    public Integer getEffectiveness() {
        return effectiveness;
    }

    public void setEffectiveness(Integer effectiveness) {
        this.effectiveness = effectiveness;
    }

    public String getQuality() {
        return quality;
    }

    public void setQuality(String quality) {
        this.quality = quality;
    }

    public Integer getCost() {
        return cost;
    }

    public void setCost(Integer cost) {
        this.cost = cost;
    }

    @XmlTransient
    public Collection<User> getUserCollection() {
        return userCollection;
    }

    public void setUserCollection(Collection<User> userCollection) {
        this.userCollection = userCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (weaponId != null ? weaponId.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Weapon)) {
            return false;
        }
        Weapon other = (Weapon) object;
        if ((this.weaponId == null && other.weaponId != null) || (this.weaponId != null && !this.weaponId.equals(other.weaponId))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "cat.proven.game.model.Weapon[ weaponId=" + weaponId + " ]";
    }
    
}
