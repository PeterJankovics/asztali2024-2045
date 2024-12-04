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

namespace gyak4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// wpf amin van ketto gombb aminek lenyomasara megnyilik egy ablak,
    /// ami beker egy erteket es visszajuttatja a fo programba,
    /// a masik gom is azt nyitja meg es ha ezzel nyitottuk meg akkor uyganabba dobja vissza.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ujablak uj = new ujablak((Button)sender);
            uj.Show();
        }
    }
}