using System;
using System.Collections.Generic;

namespace Meetup.Controller.Models
{
    public partial class UserComments
    {
        public int UserCommentId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public int RateId { get; set; }
        public string Comments { get; set; }

        public Events Event { get; set; }
        public LuRates Rate { get; set; }
        public Users User { get; set; }
    }
}
