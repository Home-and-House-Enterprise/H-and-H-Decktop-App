using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_and_House_Security.Data_Controllers
{
    class HnHServerConnector
    {
        String server = "ec2-52-91-88-255.compute-1.amazonaws.com";
        bool shutDown = false, connected=false;
        Queue<Message> messages = new Queue<Message>();
        TcpClient client;
        NetworkStream stream;
        StreamReader reader;
        Thread childThread;

        public HnHServerConnector()
        {
            try
            {
                Int32 port = 14500;
                client = new TcpClient(server, port);
                // Get a client stream for reading and writing.
                stream = client.GetStream();
                reader = new StreamReader(client.GetStream(), Encoding.UTF8);

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }

        internal void init(ulong id)
        {
            Message m = new Message();
            m.messageType = "setup";
            m.type = "user";
            m.id = id;

            try
            {
                send(m);
                Message responce = recieveMessage();
                if (responce.status == "failed")
                {
                    send(m);
                    responce = recieveMessage();
                }
                if (responce.status == "success")
                    Console.WriteLine("Server is ready");
                ThreadStart childref = new ThreadStart(listen);
                childThread = new Thread(childref);
                childThread.Start();
                connected = true;
            }
            catch (Exception e)
            {
                connected = false;
                MessageBox.Show("Could not establish Connection To serever!\n"
                    +"Some Functionality Is limited");
            }
        }

        public void send(Message message)
        {
            string json =JsonConvert.SerializeObject(message);
            send(json);
        }
        public void send(String message)
        {
            if (connected)
            {
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message + "\n");
                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Sent: {0}", message);
            }
            else
                MessageBox.Show("This function is unavaliable\n"
                    + "Could not connect to server");
        }
        private void listen()
        {
            while (shutDown==false)
            {
                Message m = recieveMessage();
                if (m != null)
                {
                    if (m.messageType != "alert")
                    {
                        messages.Enqueue(m);
                    }
                    else
                    {
                        MessageBox.Show("Alarm Was Triggered");
                    }
                }
                Console.Write("new Message");
            }
        }
        public Message getMessage()
        {
            if (messages.Count > 0)
            {
                return messages.Dequeue();
            }
            else
                return null;
        }
        private Message recieveMessage()
        {
            try
            {
                String response = recieve();
                Message data = JsonConvert.DeserializeObject<Message>(response);
                return data;
            }
            catch (Exception e)
            {

                Console.WriteLine("Error Recieving message");
                return null;
            }
        }

        private String recieve()
        {
            try
            {
                /*// Buffer to store the response bytes.
                Byte[] data = new Byte[1024];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.
                    //.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);
                return responseData;*/

                return reader.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("error recieveing message");
                return null;
            }
        }

        public void close()
        {
            // Close everything.
            try
            {
                shutDown = true;
                stream.Close();
                client.Close();
                reader.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine("error Closing");
            }
        }

        static void Connect(String server, String message)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

                Console.WriteLine("Sent: {0}", message);

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                data = new Byte[256];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);

                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }
    }
}
