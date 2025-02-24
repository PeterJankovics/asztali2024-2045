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

namespace gyak
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

        private void mozog(object sender, MouseEventArgs e)
        {
            Random rand = new Random();

            button.Margin = new Thickness(rand.Next(1, (int)this.Width - 80), rand.Next(1, (int)this.Height - 80), 0, 0);
        }
    }
}