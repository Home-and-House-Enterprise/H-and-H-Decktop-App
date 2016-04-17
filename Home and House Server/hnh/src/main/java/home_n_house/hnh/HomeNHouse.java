package home_n_house.hnh;

import java.net.ServerSocket;

import dataManager.HnHDBConnector;


public class HomeNHouse {
	
	static HnHDBConnector DB;
	public static void main(String[] args) {
		System.out.println("Server Booting Up!");
		DB=new HnHDBConnector();
		try {
			@SuppressWarnings("resource")
			ServerSocket serverSocket = new ServerSocket(14500);
			while (true) {
				// puts a client in a new connection and a seperate thread
				new Thread(new HnHNetworkConnector(serverSocket.accept(),DB)).start();
				System.out.println("Connection estabilshed");
			}
		} catch (Exception e) {
			System.out.println("Connection Error!\n");
			System.exit(0);
		}
		
	}

}
