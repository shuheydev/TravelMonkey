using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TravelMonkey.Models;
using TravelMonkey.Services;

namespace TravelMonkey.Data
{
    public class MockDataStore
    {
        public static ObservableCollection<PictureEntry> Pictures { get; set; }
            = new ObservableCollection<PictureEntry>();

        public static List<Destination> Destinations { get; set; } = new List<Destination>();

        public static ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();
    }
}