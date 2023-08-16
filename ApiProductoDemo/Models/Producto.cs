﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProductoDemo.Models
{    
    public class Producto
    {
        [Key]
        public int id { get; set; }      
        public string? nombre { get; set; }  
        public string? tipo { get; set; }
        public string? descripcion { get; set; }
        public decimal precio { get; set; }      
        public string? urlImagen { get; set; }
        public int stock { get; set; }
    }
}
