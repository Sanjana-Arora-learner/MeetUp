using System;
using System.Collections.Generic;

namespace Meetup.Controller.Models
{
    public partial class LuEventStatus
    {
        public LuEventStatus()
        {
            Events = new HashSet<Events>();
        }

        public int EventStatusId { get; set; }
        public string EventStatusName { get; set; }

        public ICollection<Events> Events { get; set; }
    }
}
