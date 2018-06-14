using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniProject.Models;
namespace MiniProject.Repository.Pattern.Interfaces
{
    public interface IProductRepository
    {
        
        void InsertProduct();
        IQueryable<Product> GetAllProduct();
        void UpdateProduct();
        void DeleteProduct();

    }
}
