using AcunMedyaTravelProject.Entities;
using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Category = AcunMedyaTravelProject.Entities.Category;

namespace AcunMedyaTravelProject.Context
{
    public class Context:DbContext
	{
       public DbSet<Category> Categories { get; set; }

       public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Destinations> Destinations { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<TripExample> TripExamples { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Sponsor> Sponsor { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }

    }
}