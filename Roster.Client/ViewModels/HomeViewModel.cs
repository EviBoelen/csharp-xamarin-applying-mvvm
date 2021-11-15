﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; } = "Roster App";
        public Command UpdateApplicationCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(
                execute: () => {
                    Title = "RosterApp (v2.0)";
                    NotifyPropertyChanged();
            });
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
