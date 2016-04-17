package home_n_house.hnh;

import dataManager.HnHDBConnector;
import org.json.simple.JSONObject;

public class HomeNHouse {

	public static void main(String[] args) {
		System.out.println("Server Booting Up!");
		HnHDBConnector db = new HnHDBConnector();
		JSONObject obj = new JSONObject();
		obj.put("name", "foo");
		obj.put("num", new Integer(100));
		obj.put("balance", new Double(1000.21));
		obj.put("is_vip", new Boolean(true));
		System.out.print(obj);
	}

}
