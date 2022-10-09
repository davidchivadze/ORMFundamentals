using Domain.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace ORMFundamentals.Infrastructure.Store.DatabaseContext
{
    public class CommercialContext:DbContext
    {
        public CommercialContext()
        {
        }

        public CommercialContext(DbContextOptions<CommercialContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-J9G00J3\\SQLEXPRESS;Database=Commercial;Integrated Security=True");
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
