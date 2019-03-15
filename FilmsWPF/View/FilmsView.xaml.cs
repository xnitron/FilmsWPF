using FilmsWPF.ViewModel;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace FilmsWPF.View
{
    /// <summary>
    /// Interaction logic for FilmsView.xaml
    /// </summary>
    public partial class FilmsView : Page
    {
        
        public FilmsView()
        {
            InitializeComponent();

            DataContext = new FilmsViewModel();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NavigationService.Navigate(new SelectedFilmView());
        }
    }
}
