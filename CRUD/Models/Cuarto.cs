//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Cuarto
    {
        [Display(Name = "#")]
        public int idCuarto { get; set; }
        [Display(Name = "Color del cuarto")]
        public string color { get; set; }
        [Display(Name = "Baño Propio")]
        public byte BañoPropio { get; set; }
        [Display(Name = "Medidas del Cuarto")]
        public string Medidas { get; set; }
    }
}