using FilmsWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace FilmsWPF.ViewModel
{
    public class SelectedFilmViewModel : BaseViewModel
    {
        private IEnumerable<SelectFilmModel> json;
        private SelectFilmModel _filmModel;
        private FilmModel _filmM;

        public ObservableCollection<SelectFilmModel> Films { get; set; }
                                                        
        public SelectedFilmViewModel(int id)
        {                                                       
            json = JsonConvert.DeserializeObject<List<SelectFilmModel>>(File.ReadAllText("films_data.json"));
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
