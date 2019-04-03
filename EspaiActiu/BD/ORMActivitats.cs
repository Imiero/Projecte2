using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMActivitats
    {
        //LINQ



        //Seleccionar todas las actividades en una List
        public static List<ACTIVITATS> SelectAllActivitats()
        {
            List<ACTIVITATS> _activitats =
                (from a in ORM.bd.ACTIVITATS
                 orderby a.nom
                 select a
                 ).ToList();

            return _activitats;

        }
    }
}
