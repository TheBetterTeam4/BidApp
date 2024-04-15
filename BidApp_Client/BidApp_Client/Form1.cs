using System;
using System.Windows.Forms;

namespace BidApp_Client
{
    public partial class Form1 : Form
    {
        private ClientCommCtrl commCtrl = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void uxSend_Click(object sender, EventArgs e)
        {
            commCtrl.SendMessage("Received");
        }
    }
}