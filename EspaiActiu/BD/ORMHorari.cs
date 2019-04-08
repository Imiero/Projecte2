using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMHorari
    {
        //Seleccionar horarios por id de la actividad
        public static HORARIS_ACT_DEMANADA SelectHorarisByID(int id)
        {

            HORARIS_ACT_DEMANADA _horaris =
              (from t in ORM.bd.HORARIS_ACT_DEMANADA
               where t.id_actividad_demanada.Equals(id)
               select t).FirstOrDefault();            

            return _horaris;
        }

        //Seleccionar todos los horarios en una list
        public static List<HORARIS_ACT_DEMANADA> SelectAllHoraris(int id)
        {
            List<HORARIS_ACT_DEMANADA> _horaris =
                (from a in ORM.bd.HORARIS_ACT_DEMANADA
                 where a.id_actividad_demanada.Equals(id)
                 orderby a.dia
                 select a
                 ).ToList();

            return _horaris;

        }





        //HORARIS D'ACTIVITATS JA ASSIGNADES

        //Seleccionar horarios por la id de la actividad
        public static HORARIS_ACTIVITAT SelectHorarisActvitatByID(int id)
        {

            HORARIS_ACTIVITAT _horaris =
              (from t in ORM.bd.HORARIS_ACTIVITAT
               where t.id_actividad.Equals(id)
               select t).FirstOrDefault();

            return _horaris;
        }

        public static List<HORARIS_ACTIVITAT> SelectAllHorarisByInstalacio(int id)
        {
            List<HORARIS_ACTIVITAT> _horaris =
                (from a in ORM.bd.HORARIS_ACTIVITAT
                 where a.id.Equals(id)
                 orderby a.dia
                 select a
                 ).ToList();

            return _horaris;

        }
    }
}
