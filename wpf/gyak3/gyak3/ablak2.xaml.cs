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
using System.Windows.Shapes;

namespace gyak3
{
    /// <summary>
    /// Interaction logic for ablak2.xaml
    /// </summary>
    public partial class ablak2 : Window
    {
        MainWindow szulo;
        public ablak2(MainWindow szulo)
        {
            InitializeComponent();
           this.szulo = szulo;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            if (textBox.Text.Length > 2)
            {
                szulo.textBlock.Text = textBox.Text;
                this.Close();
            }
            
        }
    }
}
