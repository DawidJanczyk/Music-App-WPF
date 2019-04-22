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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;

namespace Music_App
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonHome1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow use = new MainWindow();
            use.Show();
            this.Close();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow use = new MainWindow();
            use.Show();
            this.Close();
        }

        private void MouseEnterHome(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.7;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonHome1.BeginAnimation(OpacityProperty, animation);
            buttonHome.BeginAnimation(OpacityProperty, animation);
        }

        private void MouseLeaveHome(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.7;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonHome1.BeginAnimation(OpacityProperty, animation);
            buttonHome.BeginAnimation(OpacityProperty, animation);
        }

        private void MouseEnterHome1(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.7;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonHome.BeginAnimation(OpacityProperty, animation);
            buttonHome1.BeginAnimation(OpacityProperty, animation);
        }

        private void MouseLeaveHome1(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.7;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonHome.BeginAnimation(OpacityProperty, animation);
            buttonHome1.BeginAnimation(OpacityProperty, animation);
        }

        private void MouseEnterBrowse1(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.7;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonBrowse.BeginAnimation(OpacityProperty, animation);
            buttonBrowse1.BeginAnimation(OpacityProperty, animation);
        }

        private void MouseLeaveBrowse1(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.7;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonBrowse.BeginAnimation(OpacityProperty, animation);
            buttonBrowse1.BeginAnimation(OpacityProperty, animation);
        }

        private void MouseEnterBrowse(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.7;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonBrowse1.BeginAnimation(OpacityProperty, animation);
            buttonBrowse.BeginAnimation(OpacityProperty, animation);
        }

        private void MouseLeaveBrowse(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.7;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonBrowse1.BeginAnimation(OpacityProperty, animation);
            buttonBrowse.BeginAnimation(OpacityProperty, animation);
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonBrowse1_Click(object sender, RoutedEventArgs e)
        {
            Browse use = new Browse();
            use.Show();
            this.Close();
        }

        private void ButtonBrowse_Click(object sender, RoutedEventArgs e)
        {
            Browse use = new Browse();
            use.Show();
            this.Close();
        }

        private void MouseEnterTopPop(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopPop.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd.BeginAnimation(OpacityProperty, animation1);
            buttonPlay.BeginAnimation(OpacityProperty,animation1);
        }

        private void MouseLeaveTopPop(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopPop.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd.BeginAnimation(OpacityProperty, animation1);
            buttonPlay.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseEnterAdd(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopPop.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd.BeginAnimation(OpacityProperty, animation1);
            buttonPlay.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseLeaveAdd(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopPop.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd.BeginAnimation(OpacityProperty, animation1);
            buttonPlay.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseEnterPlay(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopPop.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd.BeginAnimation(OpacityProperty, animation1);
            buttonPlay.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseLeavePlay(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopPop.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd.BeginAnimation(OpacityProperty, animation1);
            buttonPlay.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseEnterTopToday(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopToday.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd1.BeginAnimation(OpacityProperty, animation1);
            buttonPlay1.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseLeaveTopToday(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopToday.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd1.BeginAnimation(OpacityProperty, animation1);
            buttonPlay1.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseEnterAdd1(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopToday.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd1.BeginAnimation(OpacityProperty, animation1);
            buttonPlay1.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseLeaveAdd1(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopToday.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd1.BeginAnimation(OpacityProperty, animation1);
            buttonPlay1.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseEnterPlay1(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopToday.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd1.BeginAnimation(OpacityProperty, animation1);
            buttonPlay1.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseLeavePlay1(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonTopToday.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd1.BeginAnimation(OpacityProperty, animation1);
            buttonPlay1.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseEnterBeatles(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonBeatles.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd3.BeginAnimation(OpacityProperty, animation1);
            buttonPlay3.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseLeaveBeatles(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonBeatles.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd3.BeginAnimation(OpacityProperty, animation1);
            buttonPlay3.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseEnterAriana(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAriana.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd2.BeginAnimation(OpacityProperty, animation1);
            buttonPlay2.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseLeaveAriana(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAriana.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd2.BeginAnimation(OpacityProperty, animation1);
            buttonPlay2.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseLeavePlay2(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAriana.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd2.BeginAnimation(OpacityProperty, animation1);
            buttonPlay2.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseEnterPlay2(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAriana.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd2.BeginAnimation(OpacityProperty, animation1);
            buttonPlay2.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseEnterAdd2(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAriana.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd2.BeginAnimation(OpacityProperty, animation1);
            buttonPlay2.BeginAnimation(OpacityProperty, animation1);
        }
        private void MouseLeaveAdd2(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAriana.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd2.BeginAnimation(OpacityProperty, animation1);
            buttonPlay2.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseEnterAdd3(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonBeatles.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd3.BeginAnimation(OpacityProperty, animation1);
            buttonPlay3.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseLeaveAdd3(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonBeatles.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd3.BeginAnimation(OpacityProperty, animation1);
            buttonPlay3.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseEnterPlay3(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0.5;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonBeatles.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 1;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd3.BeginAnimation(OpacityProperty, animation1);
            buttonPlay3.BeginAnimation(OpacityProperty, animation1);
        }

        private void MouseLeavePlay3(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.5;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonBeatles.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 1;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(0.1));
            buttonAdd3.BeginAnimation(OpacityProperty, animation1);
            buttonPlay3.BeginAnimation(OpacityProperty, animation1);
        }
        
        private void ButtonPlay2_Click(object sender, RoutedEventArgs e)
        {
            mediaElementAriana.Source = new Uri(@"C:\Pobrane\ariana-grande-7-rings_2569401.mp4");
            mediaElementAriana.Play();
        }

        private void ButtonPlay3_Click(object sender, RoutedEventArgs e)
        {
            mediaElementAriana.Source = new Uri(@"C:\Pobrane\Beetles Let It Be.mp4");
            mediaElementAriana.Play();
        }
    }
}
