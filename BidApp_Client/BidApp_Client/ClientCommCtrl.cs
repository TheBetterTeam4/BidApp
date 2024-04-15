using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace BidApp_Client
{
    public class ClientCommCtrl
    {
        public WebSocketSharp.WebSocket ws;

        public ClientCommCtrl()
        {
            ws = new WebSocketSharp.WebSocket("ws://192.168.80.1:8001/Test");
            ws.Connect();

            //Check Alive
            bool conn = false;
            if (ws.IsAlive)
            {
                conn = true;
            }
            MessageBox.Show("Connection: " + conn);
        }

        public void SendMessage(string message)
        {
            if (ws.IsAlive)
            {
                MessageBox.Show("1");
                ws.Send(message);
                Console.WriteLine("Sent Message");
            }
            else
            {
                MessageBox.Show("0");
                Console.WriteLine("WebSocket is not connected.");
            }
        }
    }
}
