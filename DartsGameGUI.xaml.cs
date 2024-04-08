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
using System.Windows.Threading;

namespace _2PlayersGames
{
    /// <summary>
    /// Interaction logic for DartsGameGUI.xaml
    /// </summary>
    public partial class DartsGameGUI : Window
    {
        public DartsGameGUI()
        {
            InitializeComponent();


        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            string msg = String.Format("Power: {0}", e.NewValue);
            this.textBlock1.Text = msg;
        }
    }
}
