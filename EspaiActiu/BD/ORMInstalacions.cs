using System;
using System.Collections.Generic;
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

        //

    }
}
