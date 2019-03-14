using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmsWPF.Model;

namespace FilmsWPF.ViewModel
{
    public class MainFilmsViewModel
    {
        private FilmModel _film;

        public ObservableCollection<FilmModel> Films { get; set; }

        public MainFilmsViewModel()
        {
            Films = new ObservableCollection<FilmModel>
            {
                new FilmModel{Id=0, DisplayImage="~/Images/5xNBYXuv8wqiLVDhsfqCOr75DL7.jpg",Title ="Asd", Vote=12},
                new FilmModel{Id=1, Title ="DD", Vote=2},
                new FilmModel{Id=2, Title ="Frad", Vote=7},
                new FilmModel{Id=2, Title ="Frad", Vote=7}
            };
        }

    }
}
