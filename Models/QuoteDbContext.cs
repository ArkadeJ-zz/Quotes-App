using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Quotes_App.Models
{
    public class QuoteDbContext : DbContext
    {
        public QuoteDbContext(DbContextOptions<QuoteDbContext> options) : base(options)
        {
            //enure that the context db is really created
            Database.EnsureCreated();
        }

        public DbSet<Quote> Quote { get; set; }
    }
}
