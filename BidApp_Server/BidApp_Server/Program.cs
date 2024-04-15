using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace BidApp_Server
{
    public class TestService : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine("Received from client: " + e.Data);

            Send("Data from server");
        }

        protected override void OnError(WebSocketSharp.ErrorEventArgs e)
        {
            // do nothing
        }
    }

    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            WebSocketServer wss = new WebSocketServer("ws://10.130.160.101:8001");
            wss.AddWebSocketService<TestService>("/Test");
            wss.Start();
            //Console.OpenStandardInput();
            //Console.ReadKey(true);
            Application.Run(new ServerView());
            wss.Stop();
        }
    }
}