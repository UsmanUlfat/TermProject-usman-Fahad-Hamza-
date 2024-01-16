using Microsoft.EntityFrameworkCore;
using TermProject.Data;

namespace TermProject.Model
{
        public  class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)  
            {

            }
           
        public DbSet<Addmission> Addmissions { get; set; }
        public DbSet<Contect> Contects { get; set; }
        public DbSet<SignUp> SignUps { get; set; }
        public DbSet<Login> Logins { get; set; }


    }
    }

