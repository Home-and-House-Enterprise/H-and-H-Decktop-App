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
	String TYPE=null;

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
						//System.out.println(message);
					} catch (ParseException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
					if(info!=null){//check if proper format
						if(info.containsKey("messageType")){
							String request=(String) info.get("messageType");
						//	System.out.println(info.toJSONString());
							if(request.equals("setup")){
								processSetup(info);
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
	/**
	 * Handles all the request ot update the sysytem
	 * @param request
	 */
	private void processUpdate(JSONObject request){
		if(request.containsKey("type")){
			String type=(String) request.get("type");
			if(type.equals("systemStatus")){
				String value=(String) request.get("value");
				//arm the system
				if(value.equals("arm")){
					if(this.TYPE=="house")
						sendToUser(this.ID, request);
					else
						sendToHouse(this.ID, request);
				}
				//disarm the system
				else if(value.equals("disarm")){
					if(this.TYPE=="house")
						sendToUser(this.ID, request);
					else
						sendToHouse(this.ID, request);
				}
			}
			if(type.equals("sensorStatus")){
				String value=(String) request.get("value");
				if(value.equals("enabled")){
					if(this.TYPE=="house")
						sendToUser(this.ID, request);
					else
						sendToHouse(this.ID, request);
				}
				else if(value.equals("disabled")){
					if(this.TYPE=="house")
						sendToUser(this.ID, request);
					else
						sendToHouse(this.ID, request);
				}
			}
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
			sendFailedStatus("request");
		}
		
	}
	
	private void processSetup(JSONObject request){
		this.ID = (Long)request.get("id");
		this.TYPE = (String)request.get("type");
		if(TYPE!=null){
			sendSuccessStatus("setup");
		}
		
	}
	
	private void processAlert(JSONObject request){
		sendToUser(this.ID,request);
		sendSuccessStatus("alert");
	}

	@SuppressWarnings("unchecked")
	private void sendSuccessStatus(String type){
		JSONObject outObj = new JSONObject();
		outObj.put("status", "success");
		outObj.put("type",type);
		output.println(outObj.toJSONString());
	}
	@SuppressWarnings("unchecked")
	private void sendFailedStatus(String type){
		JSONObject outObj = new JSONObject();
		outObj.put("status", "failed");
		outObj.put("type",type);
		output.println(outObj.toJSONString());
	}
	
	private void sendToHouse(long id, JSONObject request) {
		for(HnHNetworkConnector con : connections){
			if(id==con.ID){
				if(con.TYPE.equals("house")){
					con.send(request);
				}			
			}
		}
	}
	private void sendToUser(long id, JSONObject request){
		for(HnHNetworkConnector con : connections){
			if(id==con.ID){
				if(con.TYPE.equals("user")){
					con.send(request);
				}			
			}
		}
	}
	protected void send(JSONObject message){
		output.println(message.toJSONString());
	}
}
