//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoApiEF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public Nullable<int> carne { get; set; }
        public Nullable<int> DPI { get; set; }
        public string correo { get; set; }
        public string genero { get; set; }
        public string direccion { get; set; }
    }
}
