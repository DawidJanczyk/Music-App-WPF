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
using System.Windows.Shapes;

namespace Music_App
{
    /// <summary>
    /// Logika interakcji dla klasy Beatles.xaml
    /// </summary>
    public partial class Beatles : Window
    {
        public Beatles()
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

        private void ButtonPause_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Pause();
        }

        private void buttonDontLetMeDown_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Beatles_-_Don't_Let_Me_Down.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonHeyJude_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Beatles_-_Hey_Jude.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonHelloGoodbye_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Beatles_-_Hello__Goodbye.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonLetItBe_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Beetles Let It Be.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonPennyLane_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Beatles_-_Penny_Lane.mp4");
            mediaElementVideo.Play();
        }


    }
}
