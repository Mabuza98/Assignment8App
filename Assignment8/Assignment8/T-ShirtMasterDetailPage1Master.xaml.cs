using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class T_ShirtMasterDetailPage1Master : ContentPage
    {
        public ListView ListView;

        public T_ShirtMasterDetailPage1Master()
        {
            InitializeComponent();

            BindingContext = new T_ShirtMasterDetailPage1MasterViewModel();
            ListView = MenuItemsListView;
        }

        class T_ShirtMasterDetailPage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<T_ShirtMasterDetailPage1MasterMenuItem> MenuItems { get; set; }

            public T_ShirtMasterDetailPage1MasterViewModel()
            {
                MenuItems = new ObservableCollection<T_ShirtMasterDetailPage1MasterMenuItem>(new[]
                {
                    new T_ShirtMasterDetailPage1MasterMenuItem { Id = 0, Title = "Page 1" },
                    new T_ShirtMasterDetailPage1MasterMenuItem { Id = 1, Title = "Page 2" },
                    new T_ShirtMasterDetailPage1MasterMenuItem { Id = 2, Title = "Page 3" },
                    new T_ShirtMasterDetailPage1MasterMenuItem { Id = 3, Title = "Page 4" },
                    new T_ShirtMasterDetailPage1MasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}