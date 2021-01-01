using System;
using System.Text;
using System.Collections.Generic;
using StoreWebApi.Api.Modelo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StoreWebApi.Api.Modelo
{
    public class OrderStatus
    {
       [Key]
       [Column("ID")]
       public int ID { get; set; }

        [Required(ErrorMessage = "El Name es obligatorio")]
        [Display(Name = "Name")]
        [StringLength(500)]
        public string Name { get; set; }


    }
}

