using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
    public class Subscriber
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime SubscribedAt { get; set; } = DateTime.Now;
    }
}