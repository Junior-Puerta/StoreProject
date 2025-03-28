using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreProject.ClientModels;

namespace StoreProject.Data
{
    public class ClientContext : DbContext
    {
        public DbSet<ClientModel> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Client.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}