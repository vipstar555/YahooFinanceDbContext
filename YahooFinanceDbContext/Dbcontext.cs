using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace System.Data
{
    public class YahooFinanceDbContext : DbContext
    {
        public YahooFinanceDbContext() : base(("name=YahooFinanceDbContext"))
        {

        }
        public DbSet<CodeList> CodeLists { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<TradeIndex> TradeIndexs { get; set; }
    }
}
