using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static CustomerOrder.Core.Utility.Enums;

namespace CustomerOrder.Core.ViewModel
{
    public class AddressDTO
    {
        public int AddressId { get; set; }
        [Required(ErrorMessage = "Street is required")]
        [StringLength(128, ErrorMessage = "Street must not be more than 128 characters")]
        [DataType(DataType.Text, ErrorMessage = "Street must be a text")]
        public string Street { get; set; }

        [Required(ErrorMessage = "PostalCode is required")]
        [StringLength(128, ErrorMessage = "Street must not be more than 128 characters")]
        [DataType(DataType.Text, ErrorMessage = "Postal code must be a text")]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "House number is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int HouseNumber { get; set; }
        

    }
}
