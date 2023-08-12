using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebBalta.Models;

namespace WebBalta.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext (DbContextOptions<AppDataContext> options)
            : base(options)
        {
        }

        public DbSet<WebBalta.Models.Product> Product { get; set; } = default!;
    }
}
