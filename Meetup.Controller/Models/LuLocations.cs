using System;
using System.Collections.Generic;

namespace Meetup.Controller.Models
{
    public partial class LuLocations
    {
        public LuLocations()
        {
            Events = new HashSet<Events>();
            Users = new HashSet<Users>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }

        public ICollection<Events> Events { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
