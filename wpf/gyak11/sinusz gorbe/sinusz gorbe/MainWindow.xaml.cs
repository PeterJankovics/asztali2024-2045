using System.Data;
using System.Globalization;
using System.Numerics;
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
using System.Windows.Threading;

namespace sinusz_gorbe
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
        //koordinata rendszer
        //kor
        //fekete pont
        //sugar
        //magassag
        //szinusz gorbe
        //koriv(kicsi)
        //koriv(nagy)
        //adattabla(szog+)

        int x = 0;
        void rajzol(object sender, EventArgs e)
        {
            origoX = r * 1.1;
            origoY = Height / 2;


            kordinataRajzol();

            

            kor(x);
            sugar(x);
            magassag(x);
            pont(x);
            x += 1;
        }
        private void vaszon_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += rajzol;
            timer.Interval = TimeSpan.FromMilliseconds(40);
            timer.Start();
        }
        int r = 100;
        double origoY = 0;
        double origoX = 0;
        void kordinataRajzol()
        {
            Line xTengely = new Line();
            xTengely.Stroke = Brushes.Black;
            xTengely.X1 = 0;
            xTengely.Y1 = Height / 2;
            xTengely.X2 = Width;
            xTengely.Y2 = Height / 2;



            Line yTengely = new Line();
            yTengely.Stroke = Brushes.Black;
            yTengely.X1 = r * 1.1;
            yTengely.Y1 = 0;
            yTengely.X2 = r * 1.1;
            yTengely.Y2 = Height;


            vaszon.Children.Add(xTengely);
            vaszon.Children.Add(yTengely);

            for (int i = 0; i < 5; i++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = i * 90 + yTengely.X1;
                vonalka.Y1 = Height / 2 - 5;
                vonalka.X2 = i * 90 + yTengely.X1;
                vonalka.Y2 = Height / 2 + 5;
                vaszon.Children.Add(vonalka);
            }

            for (int i = 0; i < 5; i++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = yTengely.X1 - 5;
                vonalka.Y1 = i * 90 + (xTengely.Y1 - 180);
                vonalka.X2 = yTengely.X1 + 5;
                vonalka.Y2 = i * 90 + (xTengely.Y1 - 180);
                vaszon.Children.Add(vonalka);
            }
        }

       

        /*void sugar(int x)
        {
            int dX = (int)(Math.Cos(x / 180 * Math.PI) * r);

            int magassag = (int)(Math.Sin(x / 180 * Math.PI) * r);
            Line sugar = new Line();
            sugar.Stroke = Brushes.Black;
            sugar.X1 = origoX + x - dX;
            sugar.Y1 = origoY;
            sugar.X2 = x + origoX;
            sugar.Y2 = origoY - Math.Sin(x / 180.0 * Math.PI) * r;
            sugar.Y2 = origoY - magassag;
            sugar.StrokeThickness = 3;

            vaszon.Children.Add(sugar);
        }
        */
        void pont(int x)
        { 
            Ellipse pont = new Ellipse();
            pont.Stroke = Brushes.Black;
            pont.Width = r * 0.15;
            pont.Height = r * 0.15;
            pont.Margin = new Thickness(origoX - r * 0.075 + x, origoY - r * 0.075 , 0, 0);
            pont.Fill = Brushes.Red;

            vaszon.Children.Add(pont);
        }

        void magassag(int x)
        {
            int magassag = (int)(Math.Sin(x / 180 * Math.PI) * r);
            Line vonal = new Line();
            vonal.StrokeThickness = 3;
            vonal.Stroke = Brushes.Red;
            vonal.X1 = x + origoX;
            vonal.Y1 = origoY;
            vonal.X2 = x + origoX;
            vonal.Y2 = origoX - magassag;

            vaszon.Children.Add(vonal);

        }

        void sugar(int x)
        {
            int magassag = (int)(Math.Sin(x / 180 * Math.PI) * r);
            int dX = (int)(Math.Cos(x / 180 * Math.PI) * r);


            Line vonal = new Line();
            vonal.StrokeThickness = 3;
            vonal.Stroke = Brushes.Black;
            vonal.X1 = x + origoX - dX;
            vonal.Y1 = origoY;
            vonal.X2 = x + origoX;
            vonal.Y2 = origoX - magassag;

            vaszon.Children.Add(vonal);

        }


        double korX = 0;
        double korY = 0;
        void kor(int x)
        {

            int dX = (int)(Math.Cos(x / 180 * Math.PI) * r);
            Ellipse kor = new Ellipse();
            kor.Stroke = Brushes.Blue;
            kor.Height = 2 * r;
            kor.Width = 2 * r;
            kor.Margin = new Thickness(x + origoX - dX - r, origoY - r, 0, 0);


            vaszon.Children.Add(kor);
            korX = x - r + origoX;
            korY = origoY;
        }


        void koriv(int x)
        {
            Path path = new Path();
            path.Stroke = Brushes.Blue;
            path.StrokeThickness = 3;

            PathGeometry geometry = new PathGeometry();
            PathFigure figure = new PathFigure();
            figure.StartPoint = new Point(100, 100);
            ArcSegment arcSegment = new ArcSegment();
            arcSegment.Point = new Point(200, 200);
            arcSegment.Size = new Size(r, r);
            arcSegment.IsLargeArc = true;
            arcSegment.SweepDirection = SweepDirection.Clockwise;
            figure.Segments.Add(arcSegment);
            figure.Segments.Add(arcSegment);
            geometry.Figures.Add(figure);
            path.Data = geometry;

            vaszon.Children.Add(path);

        }
    }
}