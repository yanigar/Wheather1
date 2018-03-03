using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheatherStation.Models
{
    public class WheatherContext : DbContext
    {
        public WheatherContext(DbContextOptions<WheatherContext> options)
            : base(options)
        {
        }

        public DbSet<Wheather> Wheathers { get; set; }

    }
}
