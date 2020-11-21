using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerOrder.Core.Domain
{
    public class Order:BaseEntity<int>
    {
        [Required(ErrorMessage = "Order Date is required")]
        [DataType(DataType.DateTime, ErrorMessage = "Order Date must be a date")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        public decimal Amount { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
