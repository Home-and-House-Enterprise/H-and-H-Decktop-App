using System;
using System.Collections.Generic;
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

        public void sendImage()
        {
            sftp.Connect();
            sftp.Put("like a boss.jpg", "/home/hnh-user/images");
            sftp.Close();
        }

        public void getImage()
        {
            sftp.Connect();
            sftp.Get("/home/hnh-user/images/boss2.jpg");
            sftp.Close();
        }

    }
}
