using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static CustomerOrder.Core.Utility.Enums;

namespace CustomerOrder.Core.ViewModel
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(80, ErrorMessage = "Name must not be more than 50 characters")]
        [DataType(DataType.Text, ErrorMessage = "Name must be a text")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public Gender Gender { get; set; }
        public ICollection<AddressDTO> Addresses { get; set; } = new List<AddressDTO>();
        public ICollection<OrderDTO> Orders { get; set; } = new List<OrderDTO>();
    }
}
