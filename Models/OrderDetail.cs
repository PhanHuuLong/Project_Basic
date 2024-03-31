﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;

namespace PhoneShoppingCartMvc.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int BookId { get; set; }
        public int Quantity {  get; set; }
        public double UnitPrice { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
