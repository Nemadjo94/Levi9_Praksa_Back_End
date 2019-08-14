using E_Commerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface IE_CommerceDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Region> Regions { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Shipper> Shippers { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<Territory> Territories { get; set; }
        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
