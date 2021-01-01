using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StoreWebApi.Api.Modelo;

namespace StoreWebApi.Api.Persistencia
{
    // Esta clase sirve para que se debe de agregar a la base de datos fisica mediante la migracion
    public class StoreWebApiContext : DbContext
    {
        public StoreWebApiContext(DbContextOptions<StoreWebApiContext> options) : base(options)
        { }
        //  Propiedad para la creacion de la entidad en base de datos por migracion


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderStatus> OrderStatuss { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
// ModelCret
   }

    }
}


