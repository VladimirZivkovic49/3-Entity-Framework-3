using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MovieCatSQL1
{
    public class Movie : INotifyPropertyChanged
    {
        

        private string _name;
        public string Name
        {
            get { return _name; }
            set

            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        private string _genere;
        public string Genere
        {
            get { return _genere; }
            set

            {
                _genere = value;
                RaisePropertyChanged();
            }
        }

        private string _director;
        public string Director
        {
            get { return _director; }
            set

            {
                _director = value;
                RaisePropertyChanged();
            }
        }
        private string _realeseDate;
        public string RealiseDate
        {
            get { return _realeseDate; }
            set

            {
                _realeseDate = value;
                RaisePropertyChanged();
            }

        }
        public int Id { get; set; }


        public static ObservableCollection<Movie> GetMovies()
        {
            var movies = new ObservableCollection<Movie>();

            // movies.Add(new Movie() { Name = "Pera", Genere = "Akcija", Director = "Dir1", RealiseDate = "12.12.2012" });
          //  movies.Add(new Movie() { Name = "Janko", Genere = "Komedija", Director = "Dir2", RealiseDate = "13.12.2012" });
         //   movies.Add(new Movie() { Name = "Marko", Genere = "Horor", Director = "Dir3", RealiseDate = "14.12.2012" });
            //  movies.Add(new Movie() { Name = "Goran", Genere = "Ratni", Director = "Dir4", RealiseDate = "15.12.2012" });
         //   movies.Add(new Movie() { Name = "Vlada", Genere = "Drama", Director = "Dir5", RealiseDate = "16.12.2012" });
            return movies;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(
            [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(caller));

            }

        }
    }
}
