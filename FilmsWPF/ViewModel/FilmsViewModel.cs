using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json;
using FilmsWPF.Model;
using System.IO;
using FilmsWPF.Commands;
using System.Windows;
using FilmsWPF.View;
using System.Windows.Navigation;
using System;

namespace FilmsWPF.ViewModel
{
    public class FilmsViewModel : BaseViewModel
    {
        private IEnumerable<FilmModel> json;
        private FilmModel _filmModel;

        public ObservableCollection<FilmModel> Films { get; set; }

        public FilmsViewModel()
        {
        
           json = JsonConvert.DeserializeObject<List<FilmModel>>(File.ReadAllText("films_data.json"));
           json = json.Select(film =>
            {
                if (film.OverView.Length > 40)
                {
                    film.OverView = film.OverView.Substring(0, 40) + "...";
                }

                film.DisplayImage = @"/Images" + film.DisplayImage;
                return film;
            });

            Films = new ObservableCollection<FilmModel>(json);
        }


        public FilmModel SelectedFilm
        {
            get
            {
                return _filmModel;
            }
            set
            {
                _filmModel = value;
                OnPropertyChanged();
            }
        }

    }
}
