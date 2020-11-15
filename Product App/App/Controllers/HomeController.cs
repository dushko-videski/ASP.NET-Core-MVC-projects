using App.Models;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using BusinessLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductService _productService;

        public HomeController()
        {
            _productService = new ProductService();

        }
        //########################################

        public IActionResult Index(string message)
        {

            ViewBag.Message = message;

            ProductListVM productListVM = _productService.GetProductListVM();

            return View("Index", productListVM);
        }


        //###################################             

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
