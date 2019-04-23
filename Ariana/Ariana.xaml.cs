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
    /// Logika interakcji dla klasy Ariana.xaml
    /// </summary>
    public partial class Ariana : Window
    {
        public Ariana()
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

        private void buttonThankYouNext_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Ariana_Grande_-_thank_u_next.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonPause_Click(object sender, RoutedEventArgs e)
        {
              mediaElementVideo.Pause();
        }

        private void button7rings_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\ariana-grande-7-rings_2569401.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonProblem_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Ariana_Grande_-_Problem_ft._Iggy_Azalea.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonNoTearsLeftToCry_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Ariana_Grande_-_no_tears_left_to_cry.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonIntoYou_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Ariana_Grande_-_Into_You.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonBlazed_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Ariana_Grande_-_blazed_(Audio)_ft._Pharrell_Williams.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonDangerousWoman_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Ariana_Grande_-_Dangerous_Woman.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonFocus_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Ariana_Grande_-_Focus.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonTattooedHeart_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Ariana_Grande_-_Tattooed_Heart_(Audio_Only).mp4");
            mediaElementVideo.Play();
        }

        private void ButtonGodIsAWoman_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Ariana_Grande_-_God_is_a_woman.mp4");
            mediaElementVideo.Play();
        }

        private void ButtonBabyI_Click(object sender, RoutedEventArgs e)
        {
            mediaElementVideo.Source = new Uri(@"C:\Pobrane\Ariana_Grande_-_Baby_I.mp4");
            mediaElementVideo.Play();
        }
    }
}
