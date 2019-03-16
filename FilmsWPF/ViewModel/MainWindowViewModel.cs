using System.Windows.Controls;
using System.Windows.Input;
using FilmsWPF.View;
using FilmsWPF.Commands;
using System.Windows;
using FilmsWPF.Model;

namespace FilmsWPF.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private object _currentPage;
        private FilmModel _filmModel;

        public ICommand ExitBtnCommand { get; set; }
        public ICommand AboutBtnCommand { get; set; }
        public ICommand HomeBtnCommand { get; set; }

        public MainWindowViewModel()
        {

        }
        public MainWindowViewModel(Page page)
        {
            CurrentPage = page;
            AboutBtnCommand = new CommandHandler(AboutBtn, CanExecute);
            ExitBtnCommand = new CommandHandler(ExitBtn, CanExecute);
            HomeBtnCommand = new CommandHandler(HomeBtn, CanExecute);
        }

        public object CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                _currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        private bool CanExecute(object param)
        {
            return true;
        }

        private void AboutBtn(object param)
        {
            CurrentPage = new AboutView();
        }

        private void HomeBtn(object param)
        {
            CurrentPage = new FilmsView();
        }

        private void ExitBtn(object param)
        {
            Application.Current.Shutdown();
        }
    }
}
