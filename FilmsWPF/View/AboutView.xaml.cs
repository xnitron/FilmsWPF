using System.Windows;
using System.Windows.Controls;
using FilmsWPF.ViewModel;

namespace FilmsWPF.View
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class AboutView : Page
    {
        public AboutView()
        {
            InitializeComponent();

            DataContext = new AboutViewModel();
        }
    }
}
