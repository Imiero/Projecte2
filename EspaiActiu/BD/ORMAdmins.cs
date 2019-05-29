using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMAdmins
    {
        //LINQ

      

        //Seleccionar todos los admins en una List
        public static List<ADMINS> SelectAllAdmins()
        {

            try
            {
                List<ADMINS> _admins =
                    (from a in ORM.bd.ADMINS
                     orderby a.nombre
                     select a
                     ).ToList();

                return _admins;
            }catch(Exception e)
            {
                return null;
            }

        }

        //Agregar nuaevos admins
        public static void InsertAdmin(String nom,String password,String correu)
        {
            ADMINS admin = new ADMINS();
            admin.nombre = nom;
            admin.password = password;
            admin.correu = correu;

            ORM.bd.ADMINS.Add(admin);

            try
            {
                ORM.SaveChanges();
            }
            catch (Exception)
            {
                //Mirar practica control de errores
            }

        }

        //Eliminar admin
        public static void DeleteAdmin(ADMINS admin)
        {
            ORM.bd.ADMINS.Remove(admin);
            try
            {
                ORM.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;

            }

        }

    }
}
