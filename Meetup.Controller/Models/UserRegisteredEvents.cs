using System;
using System.Collections.Generic;

namespace Meetup.Controller.Models
{
    public partial class UserRegisteredEvents
    {
        public UserRegisteredEvents()
        {
            UserRegisterEventNotifications = new HashSet<UserRegisterEventNotifications>();
        }

        public int UserRegisteredEventId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int RegisteredEventStatusId { get; set; }

        public Events Event { get; set; }
        public LuRegisteredEventStatus RegisteredEventStatus { get; set; }
        public Users User { get; set; }
        public ICollection<UserRegisterEventNotifications> UserRegisterEventNotifications { get; set; }
    }
}
