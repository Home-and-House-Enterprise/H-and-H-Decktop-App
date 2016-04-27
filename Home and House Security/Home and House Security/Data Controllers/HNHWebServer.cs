﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Home_and_House_Security
{
    class HNHWebServer
    {
        static string url = @"http://ec2-52-91-88-255.compute-1.amazonaws.com/hnh/";

        public static T doJSONPost<T>(string target, string postData)
        {
            WebRequest request = WebRequest.Create(url+target);
            // Set the Method property of the request to POST.
            request.Method = "POST";
            request.Timeout = 1000;
            // Create POST data and convert it to a byte array.
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
           // Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            T data = JsonConvert.DeserializeObject<T>(responseFromServer);
           // Console.WriteLine(response.ToString());
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();
            return data;
        }
    }

}
