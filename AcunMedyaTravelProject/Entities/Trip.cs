using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
	public class Trip
	{

        public int TripID { get; set; }
        public string Title { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string IconURL { get; set; }
    }
}