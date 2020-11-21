using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerOrder.Core.Domain
{
    public class Address:BaseEntity<int>
    {
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
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
