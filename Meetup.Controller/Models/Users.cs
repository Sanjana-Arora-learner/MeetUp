using System;
using System.Collections.Generic;

namespace Meetup.Controller.Models
{
    public partial class Users
    {
        public Users()
        {
            Events = new HashSet<Events>();
            UserComments = new HashSet<UserComments>();
            UserRegisteredEvents = new HashSet<UserRegisteredEvents>();
        }

        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string EmailId { get; set; }
        public string UserName { get; set; }
        public int LocationId { get; set; }
        public string Password { get; set; }

        public LuLocations Location { get; set; }
        public LuRoles Role { get; set; }
        public ICollection<Events> Events { get; set; }
        public ICollection<UserComments> UserComments { get; set; }
        public ICollection<UserRegisteredEvents> UserRegisteredEvents { get; set; }
    }
}
