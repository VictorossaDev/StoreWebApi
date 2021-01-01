using System;
using System.Text;
using System.Collections.Generic;
using StoreWebApi.Api.Modelo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StoreWebApi.Api.Modelo
{
    public class CustomerOrder
    {
       [Key]
       [Column("ID")]
       public int ID { get; set; }

        [Column("CustomerID")]
        public int CustomerID { get; set; }

        [Display(Name = "Date")]
        public DateTime? Date { get; set; }
        [Column("OrderStatusID")]
        public int OrderStatusID { get; set; }

        [Required(ErrorMessage = "El Amount es obligatorio")]
        [Display(Name = "Amount")]
        [Column("Datadecimal_18_0", TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }


    }
}

