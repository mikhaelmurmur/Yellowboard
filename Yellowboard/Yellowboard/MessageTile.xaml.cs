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
    /// Interaction logic for MessageTile.xaml
    /// </summary>
    public partial class MessageTile : UserControl
    {
        public MessageTile()
        {
            InitializeComponent();
        }

        private void MouseEnterElement(object sender, MouseEventArgs e)
        {
            bMain.Background = new SolidColorBrush(Color.FromRgb(223,206,189));
        }

        private void MouseLeaveElement(object sender, MouseEventArgs e)
        {
            bMain.Background = new SolidColorBrush(Color.FromRgb(247, 238, 212));
        }
    }
}
