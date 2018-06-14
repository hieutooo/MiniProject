using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniProject.Repository.Pattern.Interfaces;
using MiniProject.Models;
using Microsoft.EntityFrameworkCore;

namespace MiniProject.Repository.Pattern
{
    public class ProductRepository : IProductRepository
    {
        protected DbContext productcontext { get; set; } // nguyên cai database
        protected DbSet<Product> DbSet { get; set; } //bang product

        public ProductRepository(ProductContext _dbContext)
        {
            productcontext = _dbContext;
            DbSet = _dbContext.Set<Product>();
        }

        public void DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAllProduct()
        {
            return DbSet;
        }

        public void InsertProduct()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct()
        {
            throw new NotImplementedException();
        }
    }
}
