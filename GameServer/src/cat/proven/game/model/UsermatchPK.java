/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game.model;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Embeddable;

/**
 *
 * @author fredd
 */
@Embeddable
public class UsermatchPK implements Serializable {

    @Basic(optional = false)
    @Column(name = "match_id")
    private int matchId;
    @Basic(optional = false)
    @Column(name = "user_id")
    private int userId;

    public UsermatchPK() {
    }

    public UsermatchPK(int matchId, int userId) {
        this.matchId = matchId;
        this.userId = userId;
    }

    public int getMatchId() {
        return matchId;
    }

    public void setMatchId(int matchId) {
        this.matchId = matchId;
    }

    public int getUserId() {
        return userId;
    }

    public void setUserId(int userId) {
        this.userId = userId;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (int) matchId;
        hash += (int) userId;
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof UsermatchPK)) {
            return false;
        }
        UsermatchPK other = (UsermatchPK) object;
        if (this.matchId != other.matchId) {
            return false;
        }
        if (this.userId != other.userId) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "cat.proven.game.model.UsermatchPK[ matchId=" + matchId + ", userId=" + userId + " ]";
    }
    
}
