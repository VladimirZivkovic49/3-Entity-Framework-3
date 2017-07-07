using System;
using System.Configuration;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Windows;
using System.Data;

namespace MovieCatSQL1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
        private MovieContext movieContext;//dodato za SQL

        public MainWindow()
        {
            InitializeComponent();
           
            movieContext = new MovieContext();//dodato za SQL
            movies = new ObservableCollection<Movie>(movieContext.Movies);
            dataGrid.ItemsSource = movies;
        }

        
        private void Adding_Click(object sender, RoutedEventArgs e)
        {
            AddWindow ADD = new AddWindow();
            bool dialogResult = ADD.ShowDialog().Value;
            if (dialogResult == true)
            {
                movies.Add(ADD.Movie);
                movieContext.Movies.Add(ADD.Movie);//Dodato za SQL
                movieContext.SaveChanges();//dodato za SQL

            }
        }

        private void Editing_Click(object sender, RoutedEventArgs e)
        {

            var selektedMovie = (Movie)dataGrid.SelectedItem;

            EditWindow EDD = new EditWindow(selektedMovie);

            bool dialogresult = EDD.ShowDialog().Value;

       //     movieContext.Movies.Remove(selektedMovie);//uklanja selektovanu vrstu

          //  movieContext.SaveChanges();//posle ukljanjanja selektovane vrste vrši čuvanje izvršene promene 

           // movieContext.Movies.Add(selektedMovie);//dodaje zmenjenu  selektovanu vrstu

            movieContext.SaveChanges();//posle dodavanja izmenjene  selektovane vrste vrši čuvanje izvršene promene 
        }

        private void Deliting_Click(object sender, RoutedEventArgs e)
        {

            string messageBoxText = "Do you want to delete the movie?";
            string caption = "Delete Movie";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);

            if (result == MessageBoxResult.Yes && dataGrid.SelectedItem != null)


            {

                var selektedMovie = (Movie)dataGrid.SelectedItem;
                movies.Remove(selektedMovie);



                movieContext.Movies.Remove(selektedMovie);//uklanja selektovanu vrstu

                movieContext.SaveChanges();//posle ukljanjanja selektovane vrste vrši čuvanje izvršene promene 

            }

        }

      /*  private void Import_Click(object sender, RoutedEventArgs e)
        {

           

                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT  Name, Genere, Director, RealeseDate FROM Movies";
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Movies");
                    sda.Fill(dt);
                    dataGrid.ItemsSource = dt.DefaultView;
                }
            




        }*/



        private void Exiting_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
           
            movieContext.SaveChanges();
            Close();
        }


    }
}