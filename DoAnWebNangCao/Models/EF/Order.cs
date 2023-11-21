﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoAnWebNangCao.Models.EF
{
    [Table("tb_Order")]
    public class Order:CommonAbstract
    {       
        public Order() { 
            this.orderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string CostomerName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        public decimal TotalAmount  { get; set; }
        public int Quantity { get; set; }
        public ICollection<OrderDetail> orderDetails { get; set; }
    }
}