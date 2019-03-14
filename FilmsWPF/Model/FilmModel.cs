using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsWPF.Model
{
    public class FilmModel
    {
        public int Id { get; set; }
        public string DisplayImage { get; set; }
        public string Title { get; set; }
        public int Vote { get; set; }
    }
}
