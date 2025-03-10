using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerApp1.Models
{
    public class Activity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Member { get; set; }

        // Background color of the activity, determined by the member
        public Color BackgroundColor { get; set; }

        // Time range of the activity in "HH:mm - HH:mm" format
        public string TimeRange => $"{StartTime:HH:mm} - {EndTime:HH:mm}";
    }
}
