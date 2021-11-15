using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Roster.Client.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Company { get; set; }

        public ObservableCollection<Person> People { get; set; }
    }
}
