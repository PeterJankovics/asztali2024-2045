using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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

namespace gyak5
{
    /// <summary>
    /// Interaction logic for ujablak.xaml
    /// </summary>
    public partial class ujablak : Window
    {
        MainWindow szulo;
        public ujablak(MainWindow szulo)
        {
            InitializeComponent();
            this.szulo = szulo;
        }
        Random random = new Random();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            {
                for (int i = 0; i < 5; i++)
                {
                    int szam = random.Next(1, 91);
                    szulo.textBlock.Text = szam.ToString();

                }
            } 
            this.Close();
        }
    }
}
