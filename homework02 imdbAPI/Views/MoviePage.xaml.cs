
using homework02_imdbAPI.DataModels;
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

namespace homework02_imdbAPI.Views
{
    /// <summary>
    /// Interaction logic for MoviePage.xaml
    /// </summary>
    public partial class MoviePage : Page
    {
        public MoviePage(Result movie)
        {
            InitializeComponent();

            movieTitle.Content = movie.Title;
            yearLabel.Content = movie.Year;

            runningTimeLabel.Content = movie.RunningTimeInMinutes;

            actorsList.ItemsSource = movie.Principals;

            poster.Source = new BitmapImage(new Uri(movie.Image.Url));
        }
    }
}
