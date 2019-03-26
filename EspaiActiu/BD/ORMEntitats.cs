using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMEntitats
    {
        //LINQ

        public static sant_cugatEntities bd = new sant_cugatEntities();

        //Seleccionar todos las entidades en una List
        public static List<ENTITATS> SelectAllEntitats()
        {
            List<ENTITATS> _entitats =
                (from e in bd.ENTITATS
                 orderby e.nom
                 select e
                 ).ToList();

            return _entitats;
        }

        //Seleccionar todas las entidades filtrando por el nombre
        public static List<ENTITATS> SelectEntitatsByNom(String nom)
        {
            List<ENTITATS> _entitats =
                (from e in bd.ENTITATS
                 where e.nom.Contains(nom)
                 orderby e.nom
                 select e).ToList();

            return _entitats;
        }

        //Agregar nuevas entidades
        public static void InsertEntitat(String nom,String temporada,String adreça,String nif,String correu,String password)
        {
            ENTITATS entitat = new ENTITATS();
            entitat.nom = nom;
            entitat.temporada = temporada;
            entitat.adreca = adreça;
            entitat.nif = nif;
            entitat.correu = correu;
            entitat.password = password;

            ORMEntitats.bd.ENTITATS.Add(entitat);

            try
            {
                ORMEntitats.bd.SaveChanges();
            }
            catch (Exception)
            {
                //Mirar practica control de errores
            }

        }

        //Eliminar entidades
        public static void DeleteEntitat(ENTITATS entitat)
        {
            ORMEntitats.bd.ENTITATS.Remove(entitat);
            try
            {
                ORMEntitats.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;

            }

        }
    }
}
