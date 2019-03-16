using System.Windows.Controls;
using FilmsWPF.ViewModel;

namespace FilmsWPF.View
{
    public partial class AboutView : Page
    {
        public AboutView()
        {
            InitializeComponent();

            DataContext = new AboutViewModel();
        }
    }
}
