using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static CustomerOrder.Core.Utility.Enums;

namespace CustomerOrder.Core.Domain
{
    public class Customer: BaseEntity<int>
    {
        [Required(ErrorMessage ="Name is required")]
        [StringLength(80,ErrorMessage ="Name must not be more than 50 characters")]
        [DataType(DataType.Text,ErrorMessage ="Name must be a text")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [DataType(DataType.DateTime, ErrorMessage = "Age must be a date")]
        public DateTime Age { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public Gender Gender { get; set; }

        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
