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

        

        //Seleccionar todos las entidades en una List
        public static List<ENTITATS> SelectAllEntitats()
        {
            List<ENTITATS> _entitats =
                (from e in ORM.bd.ENTITATS
                 orderby e.nom
                 select e
                 ).ToList();

            return _entitats;
        }

        //Seleccionar todas las entidades filtrando por el nombre
        public static List<ENTITATS> SelectEntitatsByNom(String nom)
        {
            List<ENTITATS> _entitats =
                (from e in ORM.bd.ENTITATS
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

            ORM.bd.ENTITATS.Add(entitat);

            try
            {
                ORM.bd.SaveChanges();
            }
            catch (Exception)
            {
                //Mirar practica control de errores
            }

        }

        //Eliminar entidades
        public static void DeleteEntitat(ENTITATS entitat)
        {
            ORM.bd.ENTITATS.Remove(entitat);
            try
            {
                ORM.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;

            }

        }

        //Modificar entidades
        public static void UpdateEntitat(String nom,String temporada,String adreça,String nif,String correu,int id)
        {
            ENTITATS entitat = ORM.bd.ENTITATS.Find(id);

            entitat.nom = nom;
            entitat.temporada = temporada;
            entitat.adreca = adreça;
            entitat.correu = correu;
            entitat.nif = nif;

            try
            {
                ORM.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                //En caso de estar duplicado no podría crearse y petaria el programa
            }
        }

        //Seleccionar una entidad filtrando por ID
        public static ENTITATS SelectEntitatByID(int id)
        {
            ENTITATS entitat = ORM.bd.ENTITATS.Find(id);
            return entitat;
        }
    }
}
