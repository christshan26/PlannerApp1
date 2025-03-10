using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PlannerApp1.ViewModels
{
    // Base ViewModel class implementing INotifyPropertyChanged to support property change notifications
    public class BaseViewModel : INotifyPropertyChanged
    {
        // Event to notify when a property has changed
        public event PropertyChangedEventHandler PropertyChanged;

        // Method to raise the PropertyChanged event
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Method to set the property and notify if it has changed
        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = null)
        {
            // Check if the new value is equal to the current value
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            // Set the new value
            backingStore = value;

            // Raise the PropertyChanged event
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
