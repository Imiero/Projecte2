using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMEquips
    {
        //LINQ

        //Agregar equipos
        public static void InsertEquipo(int id_enti, String nom,int id_esport,int id_competicio,int id_categoria, int id_categoria_edat,int sexe)
        {
            EQUIPS equip = new EQUIPS();
            equip.id_entitat = id_enti;
            equip.nom = nom;
            equip.id_sport = id_esport;
            equip.id_competicio = id_competicio;
            equip.id_categoria = id_categoria;
            equip.id_categoria_edat = id_categoria_edat;
            equip.id_sexe = sexe;

            ORM.bd.EQUIPS.Add(equip);

            try
            {
                ORM.bd.SaveChanges();
            }
            catch (Exception)
            {

            }
        }

        //Seleccionar equipos por id de entidad
        public static List<EQUIPS> SelectEquiposByEntitat(int id_enti)
        {

            List<EQUIPS> _equipos =
               (from t in ORM.bd.EQUIPS
                where t.id_entitat.Equals(id_enti)
                select t).ToList();

            return _equipos;
        }

        //Eliminar telefonos
        public static void DeleteEquip(EQUIPS equip)
        {
            ORM.bd.EQUIPS.Remove(equip);
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
