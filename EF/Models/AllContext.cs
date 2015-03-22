using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EF.Models
{
    public class AllContext : DbContext
    {

        public AllContext() : base("name=AllAllContext") 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AllContext,EF.Migrations.Configuration>("AllAllContext") );
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        

    }
}