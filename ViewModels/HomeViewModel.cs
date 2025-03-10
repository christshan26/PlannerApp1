using PlannerApp1.Models;
using System.Collections.ObjectModel;

namespace PlannerApp1.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        // Collection of todays activites
        public ObservableCollection<Activity> TodayActivities { get; set; }

        public HomeViewModel()
        {
            // Load activities, sort them by time and set their background color
            var activities = LoadTodayActivities()
                .OrderBy(activity => activity.StartTime)
                .ToList();

            foreach (var activity in activities)
            {
                SetBackgroundColorByMember(activity);
            }
            TodayActivities = new ObservableCollection<Activity>(activities);
        }

        // Loads a list of mock activities
        private List<Activity> LoadTodayActivities()
        {
            return new List<Activity>()
            {
                new Activity()
                {
                    Title = "Mock1",
                    Description = "Ea nostrud et dolore facer sit voluptua est",
                    StartTime = DateTime.Today.AddHours(10),
                    EndTime = DateTime.Today.AddHours(11),
                    Member = "A"
                },
                new Activity()
                {
                    Title = "Mock2",
                    Description = "Facilisi magna eirmod ex est eos takimata tempor labore et",
                    StartTime = DateTime.Today.AddHours(9),
                    EndTime = DateTime.Today.AddHours(12),
                    Member = "C"
                },
                new Activity()
                {
                    Title = "Mock3",
                    Description = "Diam rebum sadipscing kasd",
                    StartTime = DateTime.Today.AddHours(20),
                    EndTime = DateTime.Today.AddHours(21),
                    Member = "M"
                },
                new Activity()
                {
                    Title = "Mock4",
                    Description = "Magna ea sanctus ut sea duis",
                    StartTime = DateTime.Today.AddHours(17),
                    EndTime = DateTime.Today.AddHours(19),
                    Member = "R"
                },
                new Activity()
                {
                    Title = "Mock5",
                    Description = "Consetetur accumsan sit",
                    StartTime = DateTime.Today.AddHours(6),
                    EndTime = DateTime.Today.AddHours(10),
                    Member = "ALLA"
                },
                new Activity()
                {
                    Title = "Mock6",
                    Description = "Labore gubergren diam nonumy erat",
                    StartTime = DateTime.Today.AddHours(17),
                    EndTime = DateTime.Today.AddHours(19),
                    Member = "A"
                },
                new Activity()
                {
                    Title = "Mock7",
                    Description = "Voluptua sit nulla dolor sit elitr volutpat",
                    StartTime = DateTime.Today.AddHours(10),
                    EndTime = DateTime.Today.AddHours(19),
                    Member = "R"
                },
            };
        }

        // Sets the background color of an activity based on the member
        private void SetBackgroundColorByMember(Activity activity)
        {
            switch (activity.Member)
            {
                case "A":
                    activity.BackgroundColor = Color.FromRgb(140, 250, 160);
                    break;
                case "C":
                    activity.BackgroundColor = Color.FromRgb(135, 206, 250);
                    break;
                case "M":
                    activity.BackgroundColor = Color.FromRgb(255, 220, 140);
                    break;
                case "R":
                    activity.BackgroundColor = Color.FromRgb(250, 180, 255);
                    break;
                case "ALLA":
                    activity.BackgroundColor = Color.FromRgb(255, 255, 255);
                    break;
                default:
                    activity.BackgroundColor = Color.FromRgb(255, 255, 255);
                    break;
            }
        }
    }
}
