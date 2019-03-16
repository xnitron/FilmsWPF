using System.Windows.Controls;
using FilmsWPF.ViewModel;

namespace FilmsWPF.View
{
    public partial class SelectedFilmView : Page
    {
        public SelectedFilmView(int id)
        {
            InitializeComponent();

            DataContext = new SelectedFilmViewModel(id);
        }
    }
}
