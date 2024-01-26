using homework02_imdbAPI.DataModels;
using homework02_imdbAPI.Services;
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
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            var searchResult = MovieService.GetMovies(movieTitleTextBox.Text);

            movieList.ItemsSource = searchResult.Results;
        }

        private void movieList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Result result = movieList.SelectedItem as Result;

            if (result.TitleType == "movie")
            {
                this.NavigationService.Navigate(new MoviePage(result));
            }
            else if (result.TitleType == "tvSeries")
            {
                this.NavigationService.Navigate(new TvSeriesPage(result));
            }
        }
    }
}
