using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
	public class Testimonials
	{
        [Key]
		public int TestimonialID { get; set; }
        public string Title { get; set; }
        public string TestimonialName { get; set; }
        public string Degree { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }

    }
}