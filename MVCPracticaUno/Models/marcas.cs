﻿using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
namespace MVCPracticaUno.Models
{
    public class marcas
    {
        [Key]
        [Display(Name = "ID")]
        public int id_marcas { get; set; }
        [Display(Name = "Nombre de la Marca")]
        public string? nombre_marcas { get; set; }
        [Display(Name = "Estado")]
        public string? estados { get; set; }
    }
}

