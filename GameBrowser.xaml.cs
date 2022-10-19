using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
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
    /// Interaction logic for GameBrowser.xaml
    /// </summary>
    public partial class GameBrowser : Window
    {
        public GameBrowser()
        {
            InitializeComponent();
            UserDetailsSingleton si = UserDetailsSingleton.Instance;
            usernameBlock.Text = "Welcome back " + si.Username;

            List<string> chat = new List<string>();
            chat.Add("test1");
            chat.Add("test2");
            icChat.ItemsSource = chat;

            List<string> games = new List<string>();
            games.Add("test1");
            games.Add("test2");

            listboxGames.ItemsSource = games;

            
        }

        static async Task<string> GetChatData()
        {
         
            var response = string.Empty;
            var url = "http://localhost:5268/api/Chat";
            var client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync(url);
            response = await result.Content.ReadAsStringAsync();
            Console.WriteLine(response);
            return response;
        }

        private async void refreshChat_Click(object sender, RoutedEventArgs e)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
            var data = await GetChatData();
            icChat.ItemsSource = data;
        }
    }
}
