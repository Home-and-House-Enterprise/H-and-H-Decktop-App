package home_n_house.hnh;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.ArrayList;

import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

import dataManager.HnHDBConnector;
import entities.Sensor;

public class HnHNetworkConnector implements Runnable {
	static ArrayList<HnHNetworkConnector> connections =
			new ArrayList<HnHNetworkConnector>();
	HnHDBConnector db;
	PrintWriter output;
	BufferedReader input;
	Socket client;
	String IPAddress;
	private boolean stop;
	static int count;
	long ID=0;

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
		connections.add(this);
		count++;
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
						//	System.out.println(info.toJSONString());
							if(request.equals("setup")){
								this.ID = (Long)info.get("id");
							}
							if(request.equals("arm")){
								System.out.println("brodcast arm");
								//broadcast
								for(HnHNetworkConnector con : connections){
									con.send(info);
								}
							}
							if(request.equals("disarm")){
								System.out.println("brodcast disarm");
								//broadcast
								for(HnHNetworkConnector con : connections){
									con.send(info);
								}
							}
							if(request.equals("request")){
								processRequest(info);
							}
							if(request.equals("update")){
								 processUpdate(info);
							}
							if(request.equals("create")){
								 processCreate(info);
							}
							if(request.equals("alert")){
								processAlert(info);
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
		count--;
		connections.remove(this);
	}

	protected void send(JSONObject message){
		output.println(message.toJSONString());
	}

	@SuppressWarnings("unchecked")
	private void processCreate(JSONObject request) {
		JSONObject outObj = new JSONObject();
		try{
			//request a device
			if(request.containsKey("device")){
				//request a sensor
				String device=(String) request.get("device");
				if(device.equals("sensor")){
					long id =(Long)request.get("id");
					db.createSensor(id); // creates a new sensor
					Sensor sensor = db.getSensorById(id);
					outObj.put("status", "success");
					outObj.put("type", "create");
					outObj.put("object", sensor.toJSON());
					output.println(outObj.toJSONString());
				}
				if(device.equals("light")){
					//light code
				}
				if(device.equals("camera")){
					
				}

			}
		}
		catch(Exception e){
			outObj.put("status", "failed");
			outObj.put("type", "create");
			output.println(outObj.toJSONString());
		}
		
	}
	@SuppressWarnings("unchecked")
	private void processRequest(JSONObject request){
		JSONObject outObj = new JSONObject();
		try{
			//request a device
			if(request.containsKey("device")){
				//request a sensor
				String device=(String) request.get("device");
				if(device.equals("sensor")){
					long id =(Long)request.get("id");
					Sensor sensor = db.getSensorById(id);
					//no sensor
					if(sensor != null){
						outObj.put("status", "success");
						outObj.put("type", "request");
						outObj.put("object", sensor.toJSON());
						output.println(outObj.toJSONString());
					}
					else{
						outObj.put("status", "failed");
						outObj.put("type", "request");
						output.println(outObj.toJSONString());
					}
				}
				if(device.equals("light")){
					//light code
				}
				if(device.equals("camera")){
					
				}
			}
		}
		catch(Exception e){
			outObj.put("status", "failed");
			outObj.put("type", "request");
			output.println(outObj.toJSONString());
		}
		/*
		 
		 */
	}

	@SuppressWarnings("unchecked")
	private void processUpdate(JSONObject request){
		JSONObject outObj = new JSONObject();
		outObj.put("status", "success");
		outObj.put("type", "update");
		output.println(outObj.toJSONString());
	}
	@SuppressWarnings("unchecked")
	private void processAlert(JSONObject request){
		JSONObject outObj = new JSONObject();
		outObj.put("status", "success");
		outObj.put("type", "Alert");
		output.println(outObj.toJSONString());
	}
}
