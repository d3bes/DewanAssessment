using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DewanAssessment.mvc.ViewModels
{
    public class CartItemVM
    {
            public int Id { get; set; }
    
     [Required]

    public string Name { get; set; }
     [Required]
    
    public double Price { get; set; }
     [Required]
    
    public int Quantity { get; set; }
    }
}