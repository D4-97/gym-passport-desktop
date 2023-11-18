﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Gym_Passport_Navigation.Utils
{
    public static class ObservableCollectionExtensions
    {
        public static void AddRange<T>(this ObservableCollection<T> observableCollection, IEnumerable<T> data)
        {
            foreach (T item in data)
            {
                observableCollection.Add(item);
            }
        }
    }
}
