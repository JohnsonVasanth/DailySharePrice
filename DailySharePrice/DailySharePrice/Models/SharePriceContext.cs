using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Models
{
    public class SharePriceContext : DbContext
    {
        public SharePriceContext() { }
        public SharePriceContext(DbContextOptions options) : base(options) { }

        public DbSet<DailyStockDetails> DailyStockDetails{get; set;}
    }
}
