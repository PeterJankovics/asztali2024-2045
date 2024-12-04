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

namespace gyak1
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<string> adatok = new List<string>();
            string adatbek = textBox.Text;
            adatok.Add(adatbek);
                for (int i = 0; i < adatok.Count; i++)
                {
                    listBox.Items.Add(adatok[i]);
                    
                }
                if (textBox.Text != "")
                {
                    textBox.Text = "";
                }
            
        }
        // keszites egy olyan program amely lehetoseget ad egy lista keszitesere.
        // bekeres es ezt egy listaba elhelyezni, eloszor egy adat masodjara harom adat
        // negyedikre ezeknek az ellenorzese.
    }
}