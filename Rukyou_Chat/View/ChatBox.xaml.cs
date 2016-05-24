using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Rukyou_Chat.Controller;

namespace Rukyou_Chat.View
{
    /// <summary>
    /// Interaction logic for ChatBox.xaml
    /// </summary>
    public partial class ChatBox : Window
    {

        ManageMessage mm;


        public ChatBox()
        {
            InitializeComponent();

            txtInput.Focus();
            mm = new ManageMessage("htll");

            List<string> messages = mm.showMessages();

            foreach (string message in messages)
            {
                txtOutput.Text += message + "\n";
            }
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
