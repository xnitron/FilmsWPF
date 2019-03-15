using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json;
using FilmsWPF.Model;
using System.IO;
using FilmsWPF.Commands;


namespace FilmsWPF.ViewModel
{
    public class FilmsViewModel
    {
        private IEnumerable<FilmModel> json;

        public ObservableCollection<FilmModel> Films { get; set; }

        public FilmsViewModel()
        {
            json = JsonConvert.DeserializeObject<List<FilmModel>>(File.ReadAllText("data.json"));

            json = json.Select(w =>
            {
                if (w.OverView.Length > 40)
                {
                    w.OverView = w.OverView.Substring(0, 40) + "...";
                }
                w.DisplayImage = @"/Images" + w.DisplayImage;
                return w;
            });

            Films = new ObservableCollection<FilmModel>(json);
        }
    }
}
