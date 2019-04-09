using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMInstalacions
    {
        //Seleccionar todas las instalaciones en una List
        public static List<INSTALACIO> SelectAllInstalacions()
        {
            List<INSTALACIO> _instalacions =
                (from i in ORM.bd.INSTALACIO
                 orderby i.nom
                 select i
                 ).ToList();

            return _instalacions;
        }

        //Seleccionar todas las instalaciones filtrando por el nombre
        public static List<INSTALACIO> SelectInstalacionssByNom(String nom)
        {
            List<INSTALACIO> _instalacions =
                (from i in ORM.bd.INSTALACIO
                 where i.nom.Contains(nom)
                 orderby i.nom
                 select i).ToList();

            return _instalacions;
        }

        //Seleccionar horaris
        public static List<HORARIS_INSTALACIO> SelectHorarisById(int id)
        {
            List<HORARIS_INSTALACIO> _horaris =
                (from i in ORM.bd.HORARIS_INSTALACIO
                 where i.id_centre.Equals(id)
                 orderby i.dia
                 select i).ToList();
           


            return _horaris;
        }

        //AGREGAR INSTALACIÓN

        public static int InsertInstalcion(String nom, String adreca, bool es_propi)
        {
            INSTALACIO instalacio = new INSTALACIO();
            instalacio.nom = nom;
            instalacio.adreca = adreca;
            instalacio.es_propi = es_propi;

            ORM.bd.INSTALACIO.Add(instalacio);

            try
            {
                ORM.bd.SaveChanges();
            }
            catch (Exception)
            {
                //Mirar practica control de errores
            }
            return instalacio.id;
        }

        //Filtrar instalacio per id
        public static INSTALACIO SelectInstalacioByID(int id)
        {
            INSTALACIO ins = ORM.bd.INSTALACIO.Find(id);
            return ins;
        }

        //Modificar instalacio
        public static void UpdateInstalacio(String nom, String adreca, int id)
        {

            INSTALACIO instalacio = ORM.bd.INSTALACIO.Find(id);

            instalacio.nom = nom;
            instalacio.adreca = adreca;

            try
            {
                ORM.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                //En caso de estar duplicado no podría crearse y petaria el programa
            }

        }

        //Eliminar instalación --> cambiar bdd para poder eliminar
        public static void DeleteInstalacio(INSTALACIO instalacio)
        {
            ORM.bd.INSTALACIO.Remove(instalacio);
            try
            {
                ORM.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;

            }

        }


    }
}
