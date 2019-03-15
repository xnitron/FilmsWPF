using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FilmsWPF.Model;
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace FilmsWPF.ViewModel
{
    public class MainFilmsViewModel : INotifyPropertyChanged
    {
        private FilmModel _film;
        private IEnumerable<FilmModel> json;
        private string _overView;
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<FilmModel> Films { get; set; }

        public MainFilmsViewModel()
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

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
