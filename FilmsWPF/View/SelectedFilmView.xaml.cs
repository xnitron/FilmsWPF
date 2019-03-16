using System.Windows.Controls;
using FilmsWPF.ViewModel;
namespace FilmsWPF.View
{
    /// <summary>
    /// Interaction logic for SelectedFilm.xaml
    /// </summary>
    public partial class SelectedFilmView : Page
    {
        public SelectedFilmView(int id)
        {
            InitializeComponent();

            DataContext = new SelectedFilmViewModel(id);
        }
    }
}
