package entities;

import org.json.simple.JSONObject;

public class Sensor {
	long id, floorPlanId;
	boolean enabled;
	int xpos, ypos;
	
	
	public Sensor(long id, long floorPlanId, int xpos, int ypos, boolean enabled) {
		super();
		this.id = id;
		this.floorPlanId = floorPlanId;
		this.enabled = enabled;
		this.xpos = xpos;
		this.ypos = ypos;
	}
	public long getId() {
		return id;
	}
	public void setId(long id) {
		this.id = id;
	}
	public long getFloorPlanId() {
		return floorPlanId;
	}
	public void setFloorPlanId(long floorPlanId) {
		this.floorPlanId = floorPlanId;
	}
	public boolean isEnabled() {
		return enabled;
	}
	public void setEnabled(boolean enabled) {
		this.enabled = enabled;
	}
	public int getXpos() {
		return xpos;
	}
	public void setXpos(int xpos) {
		this.xpos = xpos;
	}
	public int getYpos() {
		return ypos;
	}
	public void setYpos(int ypos) {
		this.ypos = ypos;
	}
	
	@SuppressWarnings("unchecked")
	public JSONObject toJSON(){
		JSONObject outObj = new JSONObject();
		outObj.put("id", this.id);
		outObj.put("fp_id", this.floorPlanId);
		outObj.put("xpos", new Integer(this.xpos));
		outObj.put("ypos", new Integer(this.ypos));
		outObj.put("enabled", new Boolean(this.enabled));
		return outObj;
	}
	
}
