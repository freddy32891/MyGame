/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game.model;

import java.io.Serializable;
import javax.persistence.Column;
import javax.persistence.EmbeddedId;
import javax.persistence.Entity;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author fredd
 */
@Entity
@Table(name = "usermatch")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Usermatch.findAll", query = "SELECT u FROM Usermatch u"),
    @NamedQuery(name = "Usermatch.findByMatchId", query = "SELECT u FROM Usermatch u WHERE u.usermatchPK.matchId = :matchId"),
    @NamedQuery(name = "Usermatch.findByUserId", query = "SELECT u FROM Usermatch u WHERE u.usermatchPK.userId = :userId"),
    @NamedQuery(name = "Usermatch.findByRoundsWinned", query = "SELECT u FROM Usermatch u WHERE u.roundsWinned = :roundsWinned"),
    @NamedQuery(name = "Usermatch.findByWinned", query = "SELECT u FROM Usermatch u WHERE u.winned = :winned")})
public class Usermatch implements Serializable {

    private static final long serialVersionUID = 1L;
    @EmbeddedId
    protected UsermatchPK usermatchPK;
    @Column(name = "rounds_winned")
    private Integer roundsWinned;
    @Column(name = "winned")
    private Boolean winned;
    @JoinColumn(name = "user_id", referencedColumnName = "user_id", insertable = false, updatable = false)
    @ManyToOne(optional = false)
    private User user;
    @JoinColumn(name = "match_id", referencedColumnName = "match_id", insertable = false, updatable = false)
    @ManyToOne(optional = false)
    private Matches matches;

    public Usermatch() {
    }

    public Usermatch(UsermatchPK usermatchPK) {
        this.usermatchPK = usermatchPK;
    }

    public Usermatch(int matchId, int userId) {
        this.usermatchPK = new UsermatchPK(matchId, userId);
    }

    public UsermatchPK getUsermatchPK() {
        return usermatchPK;
    }

    public void setUsermatchPK(UsermatchPK usermatchPK) {
        this.usermatchPK = usermatchPK;
    }

    public Integer getRoundsWinned() {
        return roundsWinned;
    }

    public void setRoundsWinned(Integer roundsWinned) {
        this.roundsWinned = roundsWinned;
    }

    public Boolean getWinned() {
        return winned;
    }

    public void setWinned(Boolean winned) {
        this.winned = winned;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }

    public Matches getMatches() {
        return matches;
    }

    public void setMatches(Matches matches) {
        this.matches = matches;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (usermatchPK != null ? usermatchPK.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Usermatch)) {
            return false;
        }
        Usermatch other = (Usermatch) object;
        if ((this.usermatchPK == null && other.usermatchPK != null) || (this.usermatchPK != null && !this.usermatchPK.equals(other.usermatchPK))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "cat.proven.game.model.Usermatch[ usermatchPK=" + usermatchPK + " ]";
    }
    
}
