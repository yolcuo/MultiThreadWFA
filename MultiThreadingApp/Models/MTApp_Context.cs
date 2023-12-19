using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingApp.Models
{
    public class MTApp_Context : DbContext
    {
        public virtual DbSet<Data> Datas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MTApp_DB;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
