using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerOrder.Core.ViewModel
{
    public class OrderDTO
    {
        [Required(ErrorMessage = "Order Date is required")]
        [DataType(DataType.DateTime, ErrorMessage = "Order Date must be a date")]
        public string OrderDate { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        public decimal Amount { get; set; }

    }
}
