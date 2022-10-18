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

namespace WpfMahjong
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void guestLogin_Click(object sender, RoutedEventArgs e)
        {
            UserDetailsSingleton si = UserDetailsSingleton.Instance;
            si.Username = guestUsername.Text;

            GameBrowser gameBrowser = new GameBrowser();
            gameBrowser.Show();
            this.Close();
        }
    }
}
