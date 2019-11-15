using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Measurement;

namespace UDPNumberReceiver
{
    class Program
    {
        static void Main(string[] args)
        {


            //Creates a UdpClient for reading incoming data.
            UdpClient udpServer = new UdpClient(1111);

            //Creates an IPEndPoint to record the IP Address and port number of the sender.  
            IPAddress ip = IPAddress.Parse("185.20.241.83");
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(ip,1111);
            //IPEndPoint object will allow us to read datagrams sent from another source.

            try
            {
                // Blocks until a message is received on this socket from a remote host (a client).
                Console.WriteLine("Server is blocked");
                while (true)
                {
                    Byte[] receiveBytes = udpServer.Receive(ref RemoteIpEndPoint);
                    //Server is now activated");

                    string receivedData = Encoding.ASCII.GetString(receiveBytes);
                    string[] data = receivedData.Split(' ');
                    string clientName = data[0];
                    string text = data[1] + data[2];

                    Console.WriteLine(receivedData);
                    Console.WriteLine("Received from: " + clientName.ToString() + " " + text.ToString());

                    string sendData = "Server: " + receivedData.ToUpper();
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(sendData);

                    udpServer.Send(sendBytes, sendBytes.Length, RemoteIpEndPoint);

                    Console.WriteLine("This message was sent from " +
                                                RemoteIpEndPoint.Address.ToString() +
                                                " on their port number " +
                                                RemoteIpEndPoint.Port.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
