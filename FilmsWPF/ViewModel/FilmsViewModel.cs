using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json;
using FilmsWPF.Model;
using System.IO;
using FilmsWPF.View;
using System.Windows.Controls;

namespace FilmsWPF.ViewModel
{
    public class FilmsViewModel : BaseViewModel
    {
        private FilmModel _filmModel;
        private Page _page;
        public ObservableCollection<FilmModel> Films { get; set; }
        private string _path = @"..\..\Files\films_data.json";

        public FilmsViewModel(Page page)
        {
            this._page = page;

            var json = JsonConvert.DeserializeObject<List<FilmModel>>(File.ReadAllText(_path))
                .Select(film =>
                {
                    film.OverView = TrimString(film.OverView);

                    film.DisplayImage = @"/Images" + film.DisplayImage;
                    return film;
                });

            Films = new ObservableCollection<FilmModel>(json);
        }

        public FilmModel Film
        {
            get
            {
                return _filmModel;
            }
            set
            {
                if (value != _filmModel)
                {
                    _filmModel = value;
                    _page.NavigationService.Navigate(new SelectedFilmView(_filmModel.id));
                    OnPropertyChanged();
                }
            }
        }

        private string TrimString(string str, int length = 100)
        {
            if (str.Length > length)
            {
                return str.Substring(0, length) + " ...";
            }
            return str;
        }
    }
}
