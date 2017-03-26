using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CleanCodeWorkshopMVC.Models;

namespace CleanCodeWorkshopMVC.Controllers
{
  public class ProductController : Controller
  {
    private static Products products = new Products();
    public ActionResult CreatePRoduct()
    {
      return View();
    }

    [HttpPost]
    public ActionResult CreatePRoduct(ProductModel product)
    {
      products.CreatePRoduct(product);
      return View("Index", products.products);
    }

    public ActionResult Index()
    {
      return View(products.products);
    }
  }

  public class Products
  {
    public List<ProductModel> products = new List<ProductModel>();

    public Products()
    {
      products.Add(new ProductModel
      {
        ProductName = "Apple",
        Price = 2000
      });

      products.Add(new ProductModel
      {
        ProductName = "Samsung",
        Price = 1500
      });
    }

    public void CreatePRoduct(ProductModel product)
    {
      products.Add(product);
    }

    public void UpdatePRoduct(ProductModel product)
    {
      foreach (var productItem in products)
      {
        if (productItem.ProductName == product.ProductName)
        {
          products.Remove(productItem);
          products.Add(product);
        }
      }
    }
  }
}