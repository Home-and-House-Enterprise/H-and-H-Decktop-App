__author__ = 'Emanuel Peters'
import threading
import json
import socket
import sys
import time


HOST, PORT = "ec2-52-91-88-255.compute-1.amazonaws.com", 14500
RESPONCES =[]
shutDown=False


def sendRequest(device,idNum):
    out={"messageType":"request"}
    out["device"]=device
    out["id"]=idNum
    jsonString=json.dumps(out)
    sock.sendall(bytes(jsonString + "\n", "utf-8"))

def sendCreate(device,idNum):
    out={"messageType":"create"}
    out["device"]=device
    out["id"]=idNum
    jsonString=json.dumps(out)
    sock.sendall(bytes(jsonString + "\n", "utf-8"))

def sendAlert(message):
    out={"messageType":"alert"}
    out["message"]=message
    jsonString=json.dumps(out)
    sock.sendall(bytes(jsonString + "\n", "utf-8"))

def sendUpdate(device,idNum):
    out={"messageType":"update"}
    out["device"]=device
    out["id"]=idNum
    jsonString=json.dumps(out)
    sock.sendall(bytes(jsonString + "\n", "utf-8"))

def getResponce():
    if(len(RESPONCES)>0):
        return RESPONCES.pop()
    else:
        return None
def getResponceWithTimeOut(timeout):
    startTime=time.time()
    while (len(RESPONCES)<1):
        if(time.time()-startTime>=timeout):
            break
    if(len(RESPONCES)>0):
        return RESPONCES.pop()
    else:
        return None
def listener():
    while not shutDown:
        # Receive data from the server and shut down
        try:
            received = str(sock.recv(1024), "utf-8")
            obj=json.loads(received)
            RESPONCES.append(obj)
        except:
            print("could not read server responce")

def close():
    global shutDown
    shutDown=True
    sock.shutdown(socket.SHUT_RDWR)
    sock.close()

def init(ID):
    out={"messageType":"setup"}
    out["type"]="house"
    out["id"]=ID
    jsonString=json.dumps(out)
    sock.sendall(bytes(jsonString + "\n", "utf-8"))
    obj=getResponceWithTimeOut(5)
    if(obj != None):
        if(obj["status"]=="failed"):
            sock.sendall(bytes(jsonString + "\n", "utf-8"))
            obj=getResponceWithTimeOut(1)
    if(obj != None):
        if(obj["status"]=="success"):
            print("server connection setup is complete")

# Create a socket (SOCK_STREAM means a TCP socket)
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

try:
    # Connect to server and send data
    sock.connect((HOST, PORT))
    t=threading.Thread(target=listener)
    t.start()
except:
    print("Error Connection to server!")
    sock.close()



