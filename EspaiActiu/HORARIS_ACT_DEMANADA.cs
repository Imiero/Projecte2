//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class HORARIS_ACT_DEMANADA
{
    public int id { get; set; }
    public System.TimeSpan horari_inici { get; set; }
    public System.TimeSpan horari_fi { get; set; }
    public byte dia { get; set; }
    public int id_actividad_demanada { get; set; }

    public virtual ACTIVIDADES_DEMANADAS ACTIVIDADES_DEMANADAS { get; set; }
    public virtual DIES_SETMANA DIES_SETMANA { get; set; }
}
