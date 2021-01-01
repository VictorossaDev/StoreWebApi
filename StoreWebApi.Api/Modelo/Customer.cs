using System;
using System.Text;
using System.Collections.Generic;
using StoreWebApi.Api.Modelo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StoreWebApi.Api.Modelo
{
    public class Customer
    {
       [Key]
       [Column("ID")]
       public int ID { get; set; }

        [Required(ErrorMessage = "El FirstName  es obligatorio")]
        [Display(Name = "FirstName ")]
        [StringLength(50)]
        public string FirstName  { get; set; }

        [Required(ErrorMessage = "El LastName  es obligatorio")]
        [Display(Name = "LastName ")]
        [StringLength(50)]
        public string LastName  { get; set; }

        [Required(ErrorMessage = "El UserName  es obligatorio")]
        [Display(Name = "UserName ")]
        [StringLength(50)]
        public string UserName  { get; set; }

        [Required(ErrorMessage = "El Password es obligatorio")]
        [Display(Name = "Password")]
        [StringLength(50)]
        public string Password { get; set; }


    }
}

