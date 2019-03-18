using FilmsWPF.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Linq;
using System.IO;

namespace FilmsWPF.ViewModel
{
    public class SelectedFilmViewModel : BaseViewModel
    {
        private IEnumerable<SelectFilmModel> json;
        private string _path = @"..\..\Files\films_data.json";
        private SelectFilmModel _filmModel;
        private FilmModel _filmM;

        public ObservableCollection<SelectFilmModel> Films { get; set; }
                                                        
        public SelectedFilmViewModel(int id)
        {                                                       
            json = JsonConvert.DeserializeObject<List<SelectFilmModel>>(File.ReadAllText(_path));
            json = from film in json
                   where film.id == id
                   select film;
            json = json.Select(img =>
            {
                img.DisplayImage = @"/Images" + img.DisplayImage; return img;
            });
            Films = new ObservableCollection<SelectFilmModel>(json);
        }

    }
}
