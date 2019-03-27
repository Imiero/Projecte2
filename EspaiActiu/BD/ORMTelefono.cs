using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMTelefono
    {
        //LINQ

        public static sant_cugatEntities bd = new sant_cugatEntities();

        //Agregar telefonos
        public static void InsertTelefono(int id_enti,String rao,String telefono)
        {
            TELEFONS telefon = new TELEFONS();
            telefon.id_entitat = id_enti;
            telefon.rao = rao;
            telefon.telefono = telefono;

            try
            {
                ORMTelefono.bd.SaveChanges();
            }
            catch(Exception){
                //Mirar practica control de errores
            }
        }

        //Seleccionar telefonos de una entidad
        public static List<TELEFONS> SelectTelefonosByEntitat(int id_enti)
        {
            List<TELEFONS> _telefons =
               (from t in bd.TELEFONS
                where t.id_entitat.Equals(id_enti)
                select t).ToList();

            return _telefons;
        }

    }
}
