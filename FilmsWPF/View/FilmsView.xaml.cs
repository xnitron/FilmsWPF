using FilmsWPF.ViewModel;
using System.Windows.Controls;

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
    }
}
