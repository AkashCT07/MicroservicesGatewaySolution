using Microsoft.EntityFrameworkCore;
using ProductAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Data
{
    public interface IApplicationDbContext
    {
        public DbSet<Product> Products { get; set; }
        Task<int> SaveChanges();
    }
}
