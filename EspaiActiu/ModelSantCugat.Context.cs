﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sant_cugatEntities1 : DbContext
    {
        public sant_cugatEntities1()
            : base("name=sant_cugatEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACTIVIDADES_DEMANADAS> ACTIVIDADES_DEMANADAS { get; set; }
        public virtual DbSet<ACTIVITATS> ACTIVITATS { get; set; }
        public virtual DbSet<ADMINS> ADMINS { get; set; }
        public virtual DbSet<CATEGORIA_EDAT> CATEGORIA_EDAT { get; set; }
        public virtual DbSet<CATEGORIA_NIVELL> CATEGORIA_NIVELL { get; set; }
        public virtual DbSet<COMPETICIO> COMPETICIO { get; set; }
        public virtual DbSet<DIES_SETMANA> DIES_SETMANA { get; set; }
        public virtual DbSet<ENTITATS> ENTITATS { get; set; }
        public virtual DbSet<EQUIPS> EQUIPS { get; set; }
        public virtual DbSet<HORARIS_ACT_DEMANADA> HORARIS_ACT_DEMANADA { get; set; }
        public virtual DbSet<HORARIS_INSTALACIO> HORARIS_INSTALACIO { get; set; }
        public virtual DbSet<INCIDENCIA> INCIDENCIA { get; set; }
        public virtual DbSet<INSTALACIO> INSTALACIO { get; set; }
        public virtual DbSet<LLOC_DEPORTIVO> LLOC_DEPORTIVO { get; set; }
        public virtual DbSet<SEXE> SEXE { get; set; }
        public virtual DbSet<SPORTS> SPORTS { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TELEFONS> TELEFONS { get; set; }
        public virtual DbSet<TIPUS_ACTIVIDAD> TIPUS_ACTIVIDAD { get; set; }
        public virtual DbSet<TIPUS_INCIDENCIES> TIPUS_INCIDENCIES { get; set; }
        public virtual DbSet<HORARIS_ACTIVITAT> HORARIS_ACTIVITAT { get; set; }
    }
}
