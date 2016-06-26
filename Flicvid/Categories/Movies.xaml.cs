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
//using System.Windows.Shapes;
using System.IO;

namespace Flicvid.Categories
{
    /// <summary>
    /// Interaction logic for Movies.xaml
    /// </summary>
    public partial class Movies : Page
    {
        public Movies()
        {
            InitializeComponent();
            LoadMovies();
        }

        private void LoadMovies()
        {
            string Moviepath = @"F:\Torrent\The Boy and The Beast";

            for (int i = 0; i < 11; i++)
            {
                //ListViewItem Movie = new ListViewItem();

                //Movie.Name = Path.GetFileName(Moviepath);
                

                //MovieList.Items.Add(Movie);
            }
        }
    }
}
