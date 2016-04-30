using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamir.SharpSsh;

namespace Home_and_House_Security
{
    class MediaStorageConnector
    {
        string host = "ec2-52-91-88-255.compute-1.amazonaws.com",
            user = "hnh-user", pass = "hnhteam";
        Sftp sftp;

        public MediaStorageConnector()
        {
            sftp = new Sftp(host,user,pass);
        }

        public void sendImage(string image)
        {
            sftp.Connect();
            sftp.Put(image, "/home/hnh-user/images");
            sftp.Close();
        }

        public Image getImage(string image)
        {
            sftp.Connect();
            sftp.Get("/home/hnh-user/images/"+image);
            sftp.Close();

            try
            {
                return Image.FromFile(image);
            }
            catch (Exception e)
            {

                return null;
            }
        }

    }
}
