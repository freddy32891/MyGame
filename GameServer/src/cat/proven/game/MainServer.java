/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cat.proven.game;

import cat.proven.game.model.Model;
import cat.proven.game.model.User;
import java.io.IOException;
import java.net.BindException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author fredd
 */
public class MainServer {

    private Model model = new Model();
    private Socket socket;
    private List<User> clients = new ArrayList<>();
    private List<Room> rooms = new ArrayList<>();

    private final int port = 32891;

    public static void main(String[] args) {
        MainServer main = new MainServer();
        main.run();
    }

    public List<User> getClients() {
        return clients;
    }

    public List<Room> getRooms() {
        return rooms;
    }

    private void run() {
        try {
            ServerSocket server = new ServerSocket(port);

            System.out.println("Server is started");
            while (true) {
                socket = server.accept();
                Thread hiloParaTratarElCliente = new Hilo(socket, this);
                hiloParaTratarElCliente.start();
            }
        } catch (BindException e) {
            System.out.println("IP address is already used");//en cas de que la direcció estigui repetida
        } catch (IOException ex) {
            System.out.println(ex.getMessage());//Una altra excepció
        }
    }

}
