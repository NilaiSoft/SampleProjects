using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SampleProjects.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProjects.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext() : base()
        {

        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
    }
}
