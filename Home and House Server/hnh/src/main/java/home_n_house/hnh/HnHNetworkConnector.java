package home_n_house.hnh;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.Collection;

import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

import dataManager.HnHDBConnector;

public class HnHNetworkConnector implements Runnable {
	HnHDBConnector db;
	PrintWriter output;
	BufferedReader input;
	Socket client;
	String IPAddress;
	private boolean stop;

	public HnHNetworkConnector(Socket accept, HnHDBConnector db) {
		this.client=accept;
		this.db=db;
		try {
			output = new PrintWriter(client.getOutputStream(), true);
			input = new BufferedReader(new InputStreamReader(client.getInputStream()));
			IPAddress = client.getInetAddress().getHostAddress();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}


	}
	public void run() {
		String message="";
		JSONParser parser = new JSONParser();
		while(!stop){
			try{
				message = input.readLine();
				JSONObject info=null;
				if(message!=null){
					try {
						info= (JSONObject)parser.parse(message);
					} catch (ParseException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
					if(info!=null){//check if proper format
						if(info.containsKey("messageType")){
							String request=(String) info.get("messageType");
							if(request.equals("request")){
								processRequest(info);
							}
							if(request.equals("update")){
								 processUpdate(info);
							}
							if(request.equals("alart")){
								processAlart(info);
							}

						}

					}
				}
			}
			catch (IOException e) {
				System.out.println("Client: "+IPAddress+" disconnected from server!");
				try{
					System.out.println("Closing connection");
					client.close();
				}catch(IOException e2){
					System.out.println("Error closing connection");
				}
				stop=true;
			}
		}
	}



	@SuppressWarnings("unchecked")
	private void processRequest(JSONObject request){
		JSONObject outObj = new JSONObject();
		outObj.put("status", "success");
		output.println(outObj.toJSONString());
	}

	@SuppressWarnings("unchecked")
	private void processUpdate(JSONObject request){
		JSONObject outObj = new JSONObject();
		outObj.put("status", "success");
		output.println(outObj.toJSONString());
	}
	@SuppressWarnings("unchecked")
	private void processAlart(JSONObject request){
		JSONObject outObj = new JSONObject();
		outObj.put("status", "success");
		output.println(outObj.toJSONString());
	}
}
