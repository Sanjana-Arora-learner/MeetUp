using System;
using System.Collections.Generic;

namespace Meetup.Controller.Models
{
    public partial class LuCategories
    {
        public LuCategories()
        {
            Events = new HashSet<Events>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Events> Events { get; set; }
    }
}
