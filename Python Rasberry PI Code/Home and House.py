import HnHSensorConnector as deviceInterface
import HnHServerConnector as server

#initialize sensors
deviceInterface.init()

#creates a system interface
system = deviceInterface.SensorMonitor()
system.init()
server.init(system.ID)
#runs the server update to check
#the system status against the server
system.systemUpdate(server)

ALERT=False
while True:
    obj = server.getResponce()
    if(obj != None):
        if(obj["messageType"]=="update"):
            if(obj["type"]=="systemStatus"):
                if(obj["value"]=="arm"):
                    system.startMonitor()
                    ALERT=False
                if(obj["value"]=="disarm"):
                    system.stopMonitor()
                    ALERT=False
            if(obj["type"]=="sensorStatus"):
                if(obj["value"]=="enabled"):
                    system.enableSensor(obj["id"])
                if(obj["value"]=="disabled"):
                    system.disableSensor(obj["id"])
    if system.alarmTriggered:
        if ALERT==False:
            server.sendAlert("sensor")
            obj=server.getResponceWithTimeOut(5)
            ALERT=True
        
server.close()

deviceInterface.saveState()
