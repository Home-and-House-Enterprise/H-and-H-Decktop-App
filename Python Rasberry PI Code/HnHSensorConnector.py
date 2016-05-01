import RPi.GPIO as GPIO
import threading
import time

#Make sure the GPIO pins are ready
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)

class SensorMonitor(threading.Thread):
    sensors = []
    armed=False;
    monitoring=False
    alarmTriggered=False
    ID=0

    def init(self, armedpin=25, disarmedpin=24):
        self.armedpin=armedpin
        self.disarmedpin=disarmedpin
        GPIO.setup(self.armedpin, GPIO.OUT)
        GPIO.setup(self.disarmedpin, GPIO.OUT)
        GPIO.output(self.armedpin, 0)
        GPIO.output(self.disarmedpin, 1)
        
    #starts a system wide monitoring of activity
    def startMonitor(self): 
        if SensorMonitor.monitoring==False:
            SensorMonitor.armed=True
            monitor = SensorMonitor()
            monitor.start()
            GPIO.output(self.armedpin, 1)
            GPIO.output(self.disarmedpin, 0)
    
    def stopMonitor(self):
        SensorMonitor.armed=False
        time.sleep(1) #gives the system one second to shut down
        self.reset()
        SensorMonitor.monitoring = False
        GPIO.output(self.armedpin, 0)
        GPIO.output(self.disarmedpin, 1)

    def systemUpdate(self, server):
        for s in SensorMonitor.sensors:
            server.sendRequest("sensor",s.id)
            obj=server.getResponceWithTimeOut(5)
            if(obj != None):
                if(obj["status"]=="success"):
                    s.enabled=obj["object"]["enabled"]
                if(obj["status"]=="failed"):
                    server.sendCreate("sensor",s.id)
                    obj=server.getResponceWithTimeOut(5)
                    if(obj["status"]=="success"):
                        s.enabled=obj["object"]["enabled"]
                        print('sensor created')
            else:
                print('no responce from server of sensor update')
        print('system update complete')
        
    #Scans the system of activity
    def runChecks(self):
        for s in SensorMonitor.sensors:
            if s.enabled:
                s.update()
                if s.triggered:
                    SensorMonitor.alarmTriggered = True
    #Monitors system on a new thread
    def run(self):
        SensorMonitor.monitoring = True
        print("System Active")
        while SensorMonitor.armed:
            self.runChecks()
        print("System deactivated")

    def reset(self):
        for s in SensorMonitor.sensors:
            s.triggered=False
        SensorMonitor.alarmTriggered=False

    def enableSensor(self, ID):
        for s in SensorMonitor.sensors:
            if (s.id == ID):
                s.enabled=True
                print("Sensor enabled")
    def disableSensor(self, ID):
        for s in SensorMonitor.sensors:
            if (s.id == ID):
                s.enabled=False
                print("Sensor disabled")
                
        

class Sensor:   
    def __init__(self, num, inpin, outpin=0 ,enabled=True):
        self.pin=inpin
        self.id =num
        GPIO.setup(self.pin, GPIO.IN)
        self.triggered = False
        self.enabled=enabled
        SensorMonitor.sensors.append(self)
        if(outpin):
            self.outPin=outpin
        

    def update(self):
        if self.triggered == False: 
            if GPIO.input(self.pin): # tripped
                self.triggered=True
                print("sensor at pin "+str(self.pin)+" tripped!")
            else: # button is pressed:
                pass
    def toFileText(self):
        out=str(self.id)+','+str(self.pin)+','+str(self.outPin)+','+str(self.enabled)
        return out
    

def init():
    file= open("hnh config.hnh")
    info=file.readline()
    sInfo=info.split(',') #get user id
    SensorMonitor.ID = int(sInfo[1])
    info=file.readline()
    while info != '':
        sInfo=info.split(',')
        s = Sensor(int(sInfo[0]),int(sInfo[1]),int(sInfo[2]),enabled=bool(sInfo[3]))
        info=file.readline()
    file.close()
def saveState():
    file= open("hnh config.hnh",mode="w")
    file.write("house,"+str(SensorMonitor.ID) +'\n')
    for s in SensorMonitor.sensors:
        file.write(s.toFileText()+'\n')
    file.close

if __name__=="__main__":
   init()
