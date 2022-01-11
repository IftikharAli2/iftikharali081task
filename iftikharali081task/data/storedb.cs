using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iftikharali_081auto.data
{
    public class storedb : DbContext
    {

        public storedb(DbContextOptions<storedb> options) : base(options){
            {
                Database.EnsureCreated();
            }

        }
        public DbSet<storedb> orders { get; set; }
        
    }
}
