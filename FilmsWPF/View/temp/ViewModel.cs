using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp1
{
    public class ViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<string> Items { get; set; }
       
        public ViewModel()
        {
            Items = new ObservableCollection<string>() { "afd", "bbbb", "cccc"};
            IsActive = false;
        }

        bool isActive;
        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
                OnPropertyChanged("IsActive");
            }
        }
        private string itembox;
        public string Itembox
        {
            get { return itembox; }
            set
            {
                if (value != itembox)
                {
                    itembox = value;
                    foreach (var item in Items)
                    {
                        if(item.Contains(itembox))
                        {
                            IsActive = true;
                        }
                    }
                    OnPropertyChanged("ItemBox");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string s)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(s));
            }
        }
    }
}
