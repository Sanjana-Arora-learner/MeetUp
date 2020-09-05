using System;
using System.Collections.Generic;

namespace Meetup.Controller.Models
{
    public partial class UserRegisterEventNotifications
    {
        public int NotificationId { get; set; }
        public int UserRegisteredEventId { get; set; }
        public string Notification { get; set; }

        public UserRegisteredEvents UserRegisteredEvent { get; set; }
    }
}
