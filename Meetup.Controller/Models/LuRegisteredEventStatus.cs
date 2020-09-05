using System;
using System.Collections.Generic;

namespace Meetup.Controller.Models
{
    public partial class LuRegisteredEventStatus
    {
        public LuRegisteredEventStatus()
        {
            UserRegisteredEvents = new HashSet<UserRegisteredEvents>();
        }

        public int RegisteredEventStatusId { get; set; }
        public string RegisteredEventStatusName { get; set; }

        public ICollection<UserRegisteredEvents> UserRegisteredEvents { get; set; }
    }
}
