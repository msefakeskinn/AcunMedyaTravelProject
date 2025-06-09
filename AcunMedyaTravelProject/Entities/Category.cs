using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
	public class Category
	{
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public List<Destinations> Destinations { get; set; }
    }
}