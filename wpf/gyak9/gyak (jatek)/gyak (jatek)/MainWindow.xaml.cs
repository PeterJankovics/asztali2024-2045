using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gyak__jatek_
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

        private void OnMouseEnterHandler(object sender, MouseEventArgs e)
        {
            button.Background = Brushes.Red;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void butNo_MouseEnter(object sender, MouseEventArgs e)
        {
            Random x = new Random();
            Point pt = new Point(int.Parse(x.Next(200).ToString()), int.Parse(x.Next(250).ToString()));
            
        }
    }
}