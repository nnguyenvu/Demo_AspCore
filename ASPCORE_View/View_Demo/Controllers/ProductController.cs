using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using View_Demo.Models;

namespace View_Demo.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> products = new List<Product>()
        {
            new Product
                {
                    MaHH = 001,
                    TenHH = "Iphone X",
                    DonGia = 19890000
                },
                new Product
                {
                    MaHH = 002,
                    TenHH = "Samsung S9",
                    DonGia = 19890000
                },
                new Product
                {
                    MaHH = 003,
                    TenHH = "Nokia 6",
                    DonGia = 19890000
                }
        };
        public IActionResult ShowAll()
        {
            //List<Product> list = new List<Product>()
            //{
            //    new Product
            //    {
            //        MaHH = 001,
            //        TenHH = "Iphone X",
            //        DonGia = 19890000
            //    },
            //    new Product
            //    {
            //        MaHH = 002,
            //        TenHH = "Samsung S9",
            //        DonGia = 19890000
            //    },
            //    new Product
            //    {
            //        MaHH = 003,
            //        TenHH = "Nokia 6",
            //        DonGia = 19890000
            //    },
            //};
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            products.Add(product);
            return RedirectToAction("ShowAll");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}