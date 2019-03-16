using System.Windows;
using FilmsWPF.View;
using FilmsWPF.ViewModel;

namespace FilmsWPF
{
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(new FilmsView());
        }
    }
}
