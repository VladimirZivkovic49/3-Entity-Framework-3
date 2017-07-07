using System.Windows;

namespace MovieCatSQL1
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public Movie Movie { get; set; }
        public EditWindow(Movie movie)
        {
            InitializeComponent();
            Movie = movie;
            EddName.Text = Movie.Name;
            EddGenere.Text = Movie.Genere;
            EddDirector.Text = Movie.Director;
            EddRealeseDate.Text = Movie.RealiseDate;

        }
        private void OkEdit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;

            Movie.Name = EddName.Text;
            Movie.Genere = EddGenere.Text;
            Movie.Director = EddDirector.Text;
            Movie.RealiseDate = EddRealeseDate.Text;

            Close();
        }

        private void CancelEdit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       
    }
}
