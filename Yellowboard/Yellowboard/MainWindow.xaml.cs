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

namespace Yellowboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isDown = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void GoUpDown(object sender, RoutedEventArgs e)
        {
            if(isDown)
            {
                this.Top = -90;
                ((Button)sender).Content = "Down";
            }
            else
            {
                this.Top = 0;
                ((Button)sender).Content = "Up";
            }
            isDown = !isDown;
        }

        private void GoingOnTop(object sender, EventArgs e)
        {
            this.Topmost = true;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Hide(object sender, RoutedEventArgs e)
        {
            GoUpDown(sender,e);
        }

        private void GetToken(object sender, RoutedEventArgs e)
        {
            Window w = new GetTokenStart();
            w.Show();            
        }
    }
}
