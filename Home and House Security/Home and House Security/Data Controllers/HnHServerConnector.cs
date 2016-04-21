using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Home_and_House_Security.Data_Controllers
{
    class HnHServerConnector
    {
        String server = "ec2-52-91-88-255.compute-1.amazonaws.com";
        TcpClient client;
        NetworkStream stream;
        StreamReader reader;

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
        public void send(Message message)
        {
            string json =JsonConvert.SerializeObject(message);
            send(json);
        }
        public void send(String message)
        {
            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message+"\n");
            // Send the message to the connected TcpServer. 
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Sent: {0}", message);
        }
        public Message recieveMessage()
        {
            String response = recieve();
            Message data = JsonConvert.DeserializeObject<Message>(response);
            return data;
        }

        public String recieve()
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
            stream.Close();
            client.Close();
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
