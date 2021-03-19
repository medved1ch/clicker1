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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        long point = 0;
        int inter = 1;
        static int point_on_Click = 1;
        int timer_afk = 1;
        int n = 1;
        double sol_1 = 10 + 10 * (10 + point_on_Click * 0.2);
        double sol_2 = 20 + 10 * (30 + point_on_Click * 0.2);
        double afk_1 = 20; //+ point_on_Click * 0.3);


        public MainWindow()
        {

            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(inter);
            timer.Tick += Timer_Tick;
            timer.Start();
            Update();
        }
        public void Update()
        {
            pnt.Content = "Points " + point;
            Points_per_Click.Content = $"Points_per_Click  {point_on_Click}";
            Lb1_bt1.Content = (sol_1).ToString();
            bt2.Content = (sol_2).ToString();

         }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            point += timer_afk;
            Update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (point>=(sol_1))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 3;
                Update();
               

            } else
            {
                MessageBox.Show("Malo");
            }
        }

       
        private void Timer_Tick(object sender, EventArgs e)
        {
            point += timer_afk;
            Update();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_2))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 5;
                Update();
               

            }
            else
            {
                MessageBox.Show("Malo");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (point >= (afk_1))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
               timer_afk += 1;
                Update();


            }
            else
            {
                MessageBox.Show("Malo");
            }
        }
    }
}
