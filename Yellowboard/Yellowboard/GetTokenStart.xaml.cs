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

namespace Yellowboard
{
    /// <summary>
    /// Interaction logic for GetTokenStart.xaml
    /// </summary>
    public partial class GetTokenStart : Window
    {
        public GetTokenStart()
        {
            InitializeComponent();
        }

        private void GetToken(object sender, RoutedEventArgs e)
        {
            wbToken.Navigate("https://oauth.vk.com/authorize?client_id=5062772&scope=messages&redirect_uri=https://oauth.vk.com/blank.html&display=page&v=5.37&response_type=token");
        }

        private void WriteTokenToFile(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {        
            Console.WriteLine("Navigated");
            string url = wbToken.Source.AbsoluteUri;
            Console.WriteLine(url);
            System.IO.File.WriteAllText("token.txt", url);
            int ind = url.IndexOf('=');
            int ind2 = url.IndexOf('&');
            string token = url.Substring(ind, ind2 - ind);
            Properties.Settings.Default.token = token;
            this.Close();
        }
    }
}
