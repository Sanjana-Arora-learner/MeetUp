using System;
using System.Collections.Generic;

namespace Meetup.Controller.Models
{
    public partial class LuRoles
    {
        public LuRoles()
        {
            Users = new HashSet<Users>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
