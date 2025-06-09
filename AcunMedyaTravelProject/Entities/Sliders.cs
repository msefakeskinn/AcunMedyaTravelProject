using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
	public class Sliders
	{
        [Key]
        public int SliderID { get; set; }
        public string Title { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string ImageURL{ get; set; }


    }
}