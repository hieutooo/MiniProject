using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject.Repository.Pattern.Interfaces
{
    public interface IProductRepository
    {
        void InsertProduct();
        void GetAllProduct();
        void UpdateProduct();
        void DeleteProduct();

    }
}
