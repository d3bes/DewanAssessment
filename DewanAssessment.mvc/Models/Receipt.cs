using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DewanAssessment.mvc.Models
{
    public class Receipt
    {
          public int Id { get; set; }

    [Required]
    public double Total { get; set; }

    [Required]
    public double PaidAmount { get; set; }

    public virtual ICollection<ReceiptItem> Items { get; set; }

    }
}