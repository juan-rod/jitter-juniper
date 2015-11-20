using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Jitter.Models
{
    public class JitterContext : DbContext
    {
        // IDbset, IQueryable, IList
        public DbSet<JitterUser> JitterUsers { get; set; }
        public DbSet<Jot> Jots { get; set;}
    }
}