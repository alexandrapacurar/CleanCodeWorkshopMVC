using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CleanCodeWorkshopMVC.Models
{
  public class ProductModel
  {
    [Required]
    [Display(Name = "Product Name")]
    public string ProductName { get; set; }

    [Required]
    [Display(Name = "Product Price")]
    public decimal Price { get; set; }

    public int ProductId { get; set; }
  }
}