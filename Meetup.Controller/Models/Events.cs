using System;
using System.Collections.Generic;

namespace Meetup.Controller.Models
{
    public partial class Events
    {
        public Events()
        {
            UserComments = new HashSet<UserComments>();
            UserRegisteredEvents = new HashSet<UserRegisteredEvents>();
        }

        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventStartDate { get; set; }
        public string EventEndDate { get; set; }
        public int LocationId { get; set; }
        public int CategoryId { get; set; }
        public int EventStatusId { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }

        public LuCategories Category { get; set; }
        public Users CreatedByNavigation { get; set; }
        public LuEventStatus EventStatus { get; set; }
        public LuLocations Location { get; set; }
        public ICollection<UserComments> UserComments { get; set; }
        public ICollection<UserRegisteredEvents> UserRegisteredEvents { get; set; }
    }
}
