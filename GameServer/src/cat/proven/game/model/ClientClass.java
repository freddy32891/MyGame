/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game.model;

import java.util.Collection;

/**
 *
 * @author fredd
 */
public class ClientClass {

    private int userId;
    private String name;
    private int port;
    private String ip;

    public ClientClass() {
    }

    public ClientClass(int userId, String name, int port, String ip) {
        this.userId = userId;
        this.name = name;
        this.port = port;
        this.ip = ip;
    }

    public ClientClass(Integer userId, String name, int puertoDisponible) {
        this.userId = userId;
        this.name = name;
        this.port = puertoDisponible;
    }

    public int getUserId() {
        return userId;
    }

    public void setUserId(int userId) {
        this.userId = userId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getPort() {
        return port;
    }

    public void setPort(int port) {
        this.port = port;
    }

    public String getIp() {
        return ip;
    }

    public void setIp(String ip) {
        this.ip = ip;
    }

    @Override
    public int hashCode() {
        int hash = 7;
        hash = 83 * hash + this.userId;
        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final ClientClass other = (ClientClass) obj;
        if (this.userId != other.userId) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Client{" + "userId=" + userId + ", name=" + name + ", port=" + port + ", ip=" + ip + '}';
    }

}
