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
@Table(name = "shield")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Shield.findAll", query = "SELECT s FROM Shield s"),
    @NamedQuery(name = "Shield.findByShieldId", query = "SELECT s FROM Shield s WHERE s.shieldId = :shieldId"),
    @NamedQuery(name = "Shield.findByName", query = "SELECT s FROM Shield s WHERE s.name = :name"),
    @NamedQuery(name = "Shield.findByDefensePoints", query = "SELECT s FROM Shield s WHERE s.defensePoints = :defensePoints"),
    @NamedQuery(name = "Shield.findByQuality", query = "SELECT s FROM Shield s WHERE s.quality = :quality"),
    @NamedQuery(name = "Shield.findByCost", query = "SELECT s FROM Shield s WHERE s.cost = :cost")})
public class Shield implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "shield_id")
    private Integer shieldId;
    @Basic(optional = false)
    @Column(name = "name")
    private String name;
    @Column(name = "defense_points")
    private Integer defensePoints;
    @Column(name = "quality")
    private String quality;
    @Column(name = "cost")
    private Integer cost;
    @ManyToMany(mappedBy = "shieldCollection")
    private Collection<User> userCollection;

    public Shield() {
    }

    public Shield(Integer shieldId) {
        this.shieldId = shieldId;
    }

    public Shield(Integer shieldId, String name) {
        this.shieldId = shieldId;
        this.name = name;
    }

    public Integer getShieldId() {
        return shieldId;
    }

    public void setShieldId(Integer shieldId) {
        this.shieldId = shieldId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Integer getDefensePoints() {
        return defensePoints;
    }

    public void setDefensePoints(Integer defensePoints) {
        this.defensePoints = defensePoints;
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
        hash += (shieldId != null ? shieldId.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Shield)) {
            return false;
        }
        Shield other = (Shield) object;
        if ((this.shieldId == null && other.shieldId != null) || (this.shieldId != null && !this.shieldId.equals(other.shieldId))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "cat.proven.game.model.Shield[ shieldId=" + shieldId + " ]";
    }
    
}
