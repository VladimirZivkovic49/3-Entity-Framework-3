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
using System.Windows.Shapes;

namespace MovieCatSQL1
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public Movie Movie { get; set; }

        public AddWindow()
        {
            InitializeComponent();
        }

        

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Movie = new Movie();
            Movie.Name = AddMovieName.Text;
            Movie.Genere = AddMovieGenere.Text;
            Movie.Director = AddMovieDirector.Text;
            Movie.RealiseDate = AddRealeseDate.Text;
        }

        private void NoADD_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
