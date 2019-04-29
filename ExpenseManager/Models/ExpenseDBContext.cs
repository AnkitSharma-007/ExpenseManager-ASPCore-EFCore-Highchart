using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager.Models
{
    public class ExpenseDBContext : DbContext
    {
        public ExpenseDBContext(DbContextOptions<ExpenseDBContext> options) : base(options)
        {

        }
        public virtual DbSet<ExpenseReport> ExpenseReport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
