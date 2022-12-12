using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClaimManageAPI.Models;

namespace ClaimManageAPI.Data
{
    public class ClaimManageAPIContext : DbContext
    {
        public ClaimManageAPIContext (DbContextOptions<ClaimManageAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ClaimManageAPI.Models.Members> Members { get; set; }

        public DbSet<ClaimManageAPI.Models.Plans> Plans { get; set; }

        public DbSet<ClaimManageAPI.Models.Login> Login { get; set; }

        public DbSet<ClaimManageAPI.Models.User> User { get; set; }
    }
}
