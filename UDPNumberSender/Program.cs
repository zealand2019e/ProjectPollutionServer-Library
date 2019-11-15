using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Measurement;

namespace UDPNumberSender
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            UdpClient udpServer = new UdpClient(0);
            udpServer.EnableBroadcast = true;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 1111);
            Console.WriteLine("Broadcast started");
            Console.ReadLine();
            
              while (true)
            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes("The number is:" + number());
                try
                {
                   udpServer.Send(sendBytes, sendBytes.Length, endPoint);
                }
                catch(Exception e)

                {
                    Console.WriteLine(e.ToString());
                }
                number++;
                measure = new Measurement.Measure()
                postMeasure.PostItemHttpTask(Measurement)


                Console.WriteLine(" " + Measure);
                Thread.Sleep(1000);

            } 
        }
    }
}
