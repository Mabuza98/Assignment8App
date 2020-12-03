using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Assignment8.ViewModels
{

    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _demoText;

        public string DemoText
        {
            get { return _demoText; }
            set { _demoText = value;
                OnPropertyChanged("DemoText");
            }
        }

        public ICommand TestButtonCommand { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            var propertyHandler = PropertyChanged;

            if (propertyHandler != null)
            {
                propertyHandler(this, new PropertyChangedEventArgs(propertyName));
            }


        }
       
        private void TestButton()
        {
            DemoText = "Trigger the shooter";
        }
    }
}
