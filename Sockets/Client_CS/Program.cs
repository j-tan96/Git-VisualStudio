using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Client_CS
{
    class Program
    {
        const int portNo = 500;
        static void Main(string[] args)
        {
            TcpClient tcpclient = new TcpClient();

            //---connect to the server---
            tcpclient.Connect("127.0.0.1", portNo);

            //---use a NetworkStream object to send and receive
            // data---
            NetworkStream ns = tcpclient.GetStream();
            byte[] data = Encoding.ASCII.GetBytes("Hello");

            //---send the text---
            ns.Write(data, 0, data.Length);
        }
    }
}
