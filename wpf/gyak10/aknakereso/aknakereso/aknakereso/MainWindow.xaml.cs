using System.Text;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aknakereso
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
        Button[,] gombok;
        int sor = 10;
        int oszlop = 10;


        private void StartGomb_Click(object sender, RoutedEventArgs e)
        {
            gombok = new Button[sor, oszlop];

            for (int j = 0; j < sor; j++)
            {
                for (int i = 0; i < oszlop; i++)
                {
                    Button g = new Button();
                    g.VerticalAlignment = VerticalAlignment.Top;
                    g.HorizontalAlignment = HorizontalAlignment.Left;
                    g.Height = 30;
                    g.Width = 30;
                    g.Click += kattintas;
                    g.Margin = new Thickness(i * 30, j * 30, 0, 0);
                    racs.Children.Add(g);
                    gombok[j, i] = g;
                }
            }

            aknaLerak();
            //aknaMutat();
            racs.Children.Remove(StartGomb);
            this.SizeToContent = SizeToContent.WidthAndHeight;


        }

        int[,] aknaHely;
        Random rand = new Random();

        void aknaLerak()
        {
            aknaHely = new int[sor, oszlop];


            for (int j = 0; j < sor; j++)
            {

                int randomSor = rand.Next(sor);
                int randomOszlop = rand.Next(oszlop);
                if (aknaHely[randomSor, randomOszlop] == 10)
                {
                    j--;
                }
                else
                {
                    aknaHely[randomSor, randomOszlop] = 10; //1 darab akna  

                }

            }
            for (int j = 0; j < aknaHely.GetLength(0); j++)
            {
                for (int k = 0; k < aknaHely.GetLength(1); k++)
                {
                    if (aknaHely[j, k] != 10)
                    {
                        aknaHely[j, k] = aknaSzamol(j, k);
                    }
                }
            }
        }

        void aknaMutat()
        {
            for (int j = 0; j < aknaHely.GetLength(0); j++)
            {
                for (int i = 0; i < aknaHely.GetLength(1); i++)
                {
                    gombok[j, i].Content = aknaHely[j, i];
                }
            }
        }

        int aknaSzamol(int sor, int oszlop)
        {
            int db = 0;
            if (sor - 1 >= 0 && oszlop - 1 >= 0 && aknaHely[sor - 1, oszlop - 1] == 10) { db++; }
            if (sor - 1 >= 0 && oszlop >= 0 && aknaHely[sor - 1, oszlop] == 10) { db++; }
            if (sor - 1 >= 0 && oszlop + 1 < this.oszlop && aknaHely[sor - 1, oszlop + 1] == 10) { db++; }

            if (sor >= 0 && oszlop - 1 >= 0 && aknaHely[sor, oszlop - 1] == 10) { db++; }
            if (sor >= 0 && oszlop + 1 < this.oszlop && aknaHely[sor, oszlop + 1] == 10) { db++; }

            if (sor +1 < this.sor && oszlop - 1 >= 0 && aknaHely[sor + 1, oszlop - 1] == 10) { db++; }
            if (sor + 1 < this.sor && oszlop >= 0 && aknaHely[sor + 1, oszlop] == 10) { db++; }
            if (sor + 1 < this.sor && oszlop + 1 < this.oszlop && aknaHely[sor + 1, oszlop + 1] == 10) { db++; }

            
            return db;

        }


        private void kattintas(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            for (int i = 0;
        }
    }
}