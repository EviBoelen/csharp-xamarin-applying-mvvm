using Roster.Client.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private string _title = "Roster App";

        public ObservableCollection<Person> People { get; set; }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }
        public Command UpdateApplicationCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(UpdateTitle);
            FillPeopleCollection();
        }

        private void UpdateTitle()
        {
            Title = "Roster App (v2.0)";
        }

        private void FillPeopleCollection()
        {
            People = new ObservableCollection<Person>()
            {
                new Person { Name = "Delores Feil", Company = "Legros Group" },
                new Person { Name = "Ann Zboncak", Company = "Ledner - Ferry" },
                new Person { Name = "Jaime Lesch", Company = "Herzog and Sons" }
            };
        }
        //private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    }
}
