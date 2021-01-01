using System;
using System.Text;
using System.Collections.Generic;
using StoreWebApi.Api.Modelo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StoreWebApi.Api.Modelo
{
    public class Product
    {
       [Key]
       [Column("ID")]
       public int ID { get; set; }

        [Required(ErrorMessage = "El Name es obligatorio")]
        [Display(Name = "Name")]
        [StringLength(500)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El UnitPrice es obligatorio")]
        [Display(Name = "UnitPrice")]
        [Column("Datadecimal_18_0", TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string Imagen { get; set; }


    }
}

