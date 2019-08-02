using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class StorageContext :DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Expends> Expends { get; set; }
        public DbSet<Incomes> Incomes { get; set; }

        public StorageContext(DbContextOptions<StorageContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
