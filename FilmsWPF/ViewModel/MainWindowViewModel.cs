using System.Windows.Controls;
using System.Windows.Input;
using FilmsWPF.View;
using FilmsWPF.Commands;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FilmsWPF.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ICommand ExitBtnCommand { get; set; }
        public ICommand AboutBtnCommand { get; set; }
        private object _currentPage;
        public object CurrentPage
        {
            get
            {
                return _currentPage; 
            }
            set
            {
                _currentPage = value;
                OnPropertyChanged();
            }
        }


        public MainWindowViewModel()
        {
            CurrentPage = new FilmsView();
            AboutBtnCommand = new CommandHandler(AboutBtn, CanExecute);
            ExitBtnCommand = new CommandHandler(ExitBtn, CanExecute);
        }


        private bool CanExecute(object param)
        {
            return true;
        }

        private void AboutBtn(object param)
        {
            CurrentPage = new AboutView();
        }

        private void ExitBtn(object param)
        {
            Application.Current.Shutdown();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
