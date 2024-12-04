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

namespace gyak3
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ablakocska ablakocska = new ablakocska(this);
            ablakocska.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ablak2 ablak2 = new ablak2(this);
            ablak2.Show();
        }
    }
}