using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using PlannerApp1.Models;

namespace PlannerApp1.ViewModels
{
    public class NewActivityViewModel : BaseViewModel
    {
        private DateTime _startTime;
        private DateTime _endTime;

        // Represents the new activity being created
        public Activity NewActivity { get; set; }

        // Collection of members to choose from
        public ObservableCollection<string> Members { get; set; }

        // Command to save the new activity
        public ICommand SaveCommand { get; set; }

        // Start time of the new activity
        public DateTime StartTime
        {
            get => _startTime;
            set => SetProperty(ref _startTime, value);
        }

        // End time of the new activity
        public DateTime EndTime
        {
            get => _endTime;
            set => SetProperty(ref _endTime, value);
        }

        // Constructor to initialize the ViewModel
        public NewActivityViewModel()
        {
            // Initialize a new activity
            NewActivity = new Activity();

            // Initialize the members collection with predefined values
            Members = new ObservableCollection<string> { "A", "C", "M", "R", "ALLA" };

            // Initialize the save command with the SaveActivity method
            SaveCommand = new Command(SaveActivity);

            // Set default start and end times to the current time
            StartTime = DateTime.Now;
            EndTime = DateTime.Now;
        }

        // Method to save the new activity
        private void SaveActivity()
        {
            // TODO: Implement the save functionality
        }
    }
}
