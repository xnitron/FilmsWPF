using FilmsWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilmsWPF.ViewModel
{
    public class SelectedFilmViewModel
    {
        private IEnumerable<SelectFilmModel> json;
        private SelectFilmModel _filmModel;

        public ObservableCollection<SelectFilmModel> Films { get; set; }

        public SelectedFilmViewModel()
        {
            json = JsonConvert.DeserializeObject<List<SelectFilmModel>>(File.ReadAllText("films_data.json"));
            json = from film in json
                   where film.id == 299537
                   select film;
            json = json.Select(f => 
            {
                f.DisplayImage = @"/Images" + f.DisplayImage; return f;
            });

                   
            Films = new ObservableCollection<SelectFilmModel>(json);
        }
    }
}
