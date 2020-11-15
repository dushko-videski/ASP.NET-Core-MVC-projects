using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using BusinessLayer.ViewModels;
using DataLayer.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }


        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct(string error)
        {
            ViewBag.Error = error;

            return View();
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductVM createProductVM)
        {
            Product newProduct = _productService.CreateProduct(createProductVM);

            if (!ModelState.IsValid)
            {
                return RedirectToAction("CreateProduct", new { error = "The Product was NOT created successfully!!! Please try again!" });
            }
            else
            {
                _productService.InsertProduct(newProduct);


                return RedirectToAction("Index", "Home", new { message = "Product created successfully and added to the Data Base!" });
            }

        }


        [HttpGet]
        public IActionResult ProductDetails(int id)
        {
            ProductVM productVM = _productService.GetProductVMByID(id);

            return View("_PartialProductItem", productVM);
        }


        [HttpGet("Product-Stats")]
        public IActionResult ProductStats()
        {

            return Json(_productService.GetListOfProductDto());
        }

        [HttpGet("edit/{id:int}")]
        public IActionResult EditProduct(int id, string error)
        {
            ProductVM productVM = _productService.GetProductVMByID(id);

            ViewBag.Error = error;


            return View("EditProduct", productVM);
        }

        [HttpPost("edit/{id:int}")]
        public IActionResult EditProduct(ProductVM productVM)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("EditProduct", new { error = "The product was not edited successfully! Please try again!" });

                //return View("EditProduct", productVM);
            }
            else
            {
                Product product = _productService.CreateProductFromProductVM(productVM);

                return RedirectToAction("Index", "Home", new { message = $"Product with Id:{product.Id} was successfully edited. Please check the details!" });

            }

        }



    }
}
