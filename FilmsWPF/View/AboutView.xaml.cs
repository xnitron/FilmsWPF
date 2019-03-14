using System.Windows;
using FilmsWPF.ViewModel;

namespace FilmsWPF.View
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class AboutView : Window
    {
        public AboutView()
        {
            InitializeComponent();

            DataContext = new AboutViewModel();
        }
    }
}
