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
        public static HORARIS_ACT_DEMANADA SelectEquiposByID(int id)
        {

            HORARIS_ACT_DEMANADA _horaris =
              (from t in ORM.bd.HORARIS_ACT_DEMANADA
               where t.id_actividad_demanada.Equals(id)
               select t).FirstOrDefault();            

            return _horaris;
        }

    }
}
