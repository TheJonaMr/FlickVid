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

namespace Flicvid
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MoviesButton_Click(object sender, RoutedEventArgs e)
        {
            Uri NewSource = new Uri("Categories/Movies.xaml", UriKind.Relative);
            CategoryFrame.Source = NewSource;
        }

        private void SeriesButton_Click(object sender, RoutedEventArgs e)
        {
            Uri NewSource = new Uri("Categories/Series.xaml", UriKind.Relative);
            CategoryFrame.Source = NewSource;
        }

        private void AnimeButton_Click(object sender, RoutedEventArgs e)
        {
            Uri NewSource = new Uri("Categories/Anime.xaml", UriKind.Relative);
            CategoryFrame.Source = NewSource;
        }

        private void FlicvidButton_Click(object sender, RoutedEventArgs e)
        {
            Uri NewSource = new Uri("Categories/Flicvid.xaml", UriKind.Relative);
            CategoryFrame.Source = NewSource;
        }

        private void FlickvidMainWindow_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) this.Close();
        }
    }
}
