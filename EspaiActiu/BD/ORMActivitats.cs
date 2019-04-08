using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMActivitats
    {


        //Seleccionar actividades filtrando la isntalacion
        public static List<ACTIVITATS> SelectActivitatsByInstalacion(int id)
        {

            List<ACTIVITATS> _activitats =
            (from a in ORM.bd.ACTIVITATS
             where a.id_espai.Equals(id)
             select a
             ).ToList();

            return _activitats;
        }
    }
}
