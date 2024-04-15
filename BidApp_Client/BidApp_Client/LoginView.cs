using System;
using System.Windows.Forms;

namespace BidApp_Client
{
    public partial class LoginView : Form
    {
        private ClientCommCtrl commCtrl = new();

        public LoginView()
        {
            InitializeComponent();
        }

        private void uxSend_Click(object sender, EventArgs e)
        {
            commCtrl.SendMessage("Received");
        }
    }
}