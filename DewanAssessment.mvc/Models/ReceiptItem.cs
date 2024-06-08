using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DewanAssessment.mvc.Models
{
    public class ReceiptItem
    {
            public int Id { get; set; }
    
    public int ReceiptId { get; set; }
    public  Receipt Receipt { get; set; }
    
    public int ItemId { get; set; }
    public  Item Item { get; set; }
    
    public int Quantity { get; set; }
    }
}