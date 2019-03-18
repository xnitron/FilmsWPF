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
        private string _path = @"..\..\Files\films_data.json";
        public ObservableCollection<SelectFilmModel> Films { get; set; }

        public SelectedFilmViewModel(int id)
        {
            var json = JsonConvert
                .DeserializeObject<List<SelectFilmModel>>(File.ReadAllText(_path))
                .Where(film => film.id == id)
                .Select(film =>
                {
                    film.DisplayImage = @"/Images" + film.DisplayImage;
                    return film;
                });

            Films = new ObservableCollection<SelectFilmModel>(json);
        }

    }
}
