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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Rukyou_Chat.Controller;

namespace Rukyou_Chat.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            ManageUser mu = new ManageUser();
            if (mu.login(txtUser.Text, txtPass.Text))
            {
                this.Hide();
                new ChatBox().ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("failed");
        }
    }
}
