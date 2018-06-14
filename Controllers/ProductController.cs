using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniProject.Repository.Pattern.Interfaces;
using MiniProject.Repository.Pattern;
using MiniProject.Models;

namespace MiniProject.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;
        public ProductController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        
        public IActionResult Index()
        {
            var result = productRepository.GetAllProduct().ToList();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            return View();
        }
    }
}