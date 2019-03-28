using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMTelefono
    {
        //LINQ


        //Agregar telefonos
        public static void InsertTelefono(int id_enti, String rao, String telefono)
        {
            TELEFONS telefon = new TELEFONS();
            telefon.id_entitat = id_enti;
            telefon.rao = rao;
            telefon.telefono = telefono;

            ORM.bd.TELEFONS.Add(telefon);
            try
            {
                ORM.bd.SaveChanges();
            }
            catch (Exception) {

            }
        }

        //Seleccionar telefonos de una entidad
        public static List<TELEFONS> SelectTelefonosByEntitat(int id_enti)
        {

            List<TELEFONS> _telefons =
               (from t in ORM.bd.TELEFONS
                where t.id_entitat.Equals(id_enti)
                select t).ToList();

            return _telefons;
        }

        //Eliminar telefonos
        public static void DeleteTelefon(TELEFONS telefon)
        {
            ORM.bd.TELEFONS.Remove(telefon);
            try
            {
                ORM.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;

            }

        }

        //Seleccionar un telefono filtrando por id
        public static TELEFONS SelectTelefonByID(int id)
        {
            TELEFONS telefon = ORM.bd.TELEFONS.Find(id);
            return telefon;
        }

    }



    }

