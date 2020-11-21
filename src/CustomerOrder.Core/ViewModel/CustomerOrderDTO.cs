using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerOrder.Core.ViewModel
{
    public class CustomerOrderDTO
    {
        
        [Required(ErrorMessage = "Customer Id is required")]
        public int CustomerId { get; set; }
        public ICollection<OrderDTO> Orders { get; set; } = new List<OrderDTO>();

    }
}
