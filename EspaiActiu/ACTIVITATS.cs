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

public partial class ACTIVITATS
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ACTIVITATS()
    {
        this.HORARIS_ACTIVITAT = new HashSet<HORARIS_ACTIVITAT>();
    }

    public int id_actividad_demanada { get; set; }
    public string nom { get; set; }
    public int id_tipus_actividad { get; set; }
    public int id_equip { get; set; }
    public int id_espai { get; set; }
    public System.DateTime ult_modif { get; set; }
    public int id_admin { get; set; }

    public virtual ACTIVIDADES_DEMANADAS ACTIVIDADES_DEMANADAS { get; set; }
    public virtual ADMINS ADMINS { get; set; }
    public virtual EQUIPS EQUIPS { get; set; }
    public virtual LLOC_DEPORTIVO LLOC_DEPORTIVO { get; set; }
    public virtual TIPUS_ACTIVIDAD TIPUS_ACTIVIDAD { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<HORARIS_ACTIVITAT> HORARIS_ACTIVITAT { get; set; }
}
