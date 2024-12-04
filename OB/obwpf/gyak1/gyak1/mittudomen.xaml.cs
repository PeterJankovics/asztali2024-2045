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

namespace gyak1
{
    /// <summary>
    /// Interaction logic for mittudomen.xaml
    /// </summary>
    public partial class mittudomen : Window
    {
        private int megnyitasDB = 0;
        public mittudomen()
        {
            InitializeComponent();
        }
        public void Show(bool szamolj)
        {
            megnyitasDB++;
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
