//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EspaiActiu
{
    using System;
    using System.Collections.Generic;
    
    public partial class TELEFONS
    {
        public int id { get; set; }
        public int id_entitat { get; set; }
        public string rao { get; set; }
        public string telefono { get; set; }
    
        public virtual ENTITATS ENTITATS { get; set; }
    }
}
