using Microsoft.EntityFrameworkCore;
using SchoolApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Database
{
    class SchoolDatabaseContext : DbContext
    {
        public DbSet<SchoolClass> SchoolClasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=schoolDatabase.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
