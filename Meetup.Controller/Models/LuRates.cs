using System;
using System.Collections.Generic;

namespace Meetup.Controller.Models
{
    public partial class LuRates
    {
        public LuRates()
        {
            UserComments = new HashSet<UserComments>();
        }

        public int RateId { get; set; }
        public string RateName { get; set; }

        public ICollection<UserComments> UserComments { get; set; }
    }
}
