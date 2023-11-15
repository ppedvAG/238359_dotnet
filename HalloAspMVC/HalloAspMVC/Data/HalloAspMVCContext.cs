using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HalloAspMVC.Models;

namespace HalloAspMVC.Data
{
    public class HalloAspMVCContext : DbContext
    {
        public HalloAspMVCContext (DbContextOptions<HalloAspMVCContext> options)
            : base(options)
        {
        }

        public DbSet<HalloAspMVC.Models.Pizza> Pizza { get; set; } = default!;
    }
}
