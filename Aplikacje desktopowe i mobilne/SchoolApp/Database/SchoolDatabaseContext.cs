using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Database
{
    class SchoolDatabaseContext : DbContext
    {
        public DbSet<> SchoolClass { get; set; }
    }
}
