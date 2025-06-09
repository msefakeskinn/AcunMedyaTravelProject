using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
	public class Destinations
	{

        public int DestinationsID { get; set; }
        public string ImageURL { get; set; }

        public string Title { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}