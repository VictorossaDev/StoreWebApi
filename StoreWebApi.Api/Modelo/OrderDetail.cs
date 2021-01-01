using System;
using System.Text;
using System.Collections.Generic;
using StoreWebApi.Api.Modelo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StoreWebApi.Api.Modelo
{
    public class OrderDetail
    {
        [Column("CustomerOrderID")]
        public int CustomerOrderID { get; set; }

        [Column("ProductID")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "El Quantity es obligatorio")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "El Amount es obligatorio")]
        [Display(Name = "Amount")]
        [Column("Datadecimal_18_0", TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        public Product Product { get; set; }

        // public ICollection<OrderDetail> ListaOrderDetail { get; set; }  // Poner en tabla dependiente


    }
}

