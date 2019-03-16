using FilmsWPF.ViewModel;
using System.Windows.Controls;

namespace FilmsWPF.View
{
    public partial class FilmsView : Page
    {
        public FilmsView()
        {
            InitializeComponent();

            DataContext = new FilmsViewModel(this);
        }
    }
}
