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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_hw_randombutton
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

        private void RunningButton(object sender, MouseEventArgs e)
        {
            int left = Convert.ToInt32(grid.ActualWidth - btnRand.Width);
            int top = Convert.ToInt32(grid.ActualHeight - btnRand.Height);
            Random rand = new Random();
            btnRand.Margin = new Thickness(rand.Next(left), rand.Next(top), 0, 0);
        }
    }
}
