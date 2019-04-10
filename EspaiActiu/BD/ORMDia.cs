using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMDia
    {
        //Seleccionar todos los dias en una List
        public static List<DIES_SETMANA> SelectAllDies()
        {
            List<DIES_SETMANA> _dies =
                (from d in ORM.bd.DIES_SETMANA
                 orderby d.id
                 select d
                 ).ToList();

            return _dies;

        }

        //seleccionar dias por id, para filtrar en las comboboxes
        public static List<DIES_SETMANA> SelectDiesByID(int id)
        {
            List<DIES_SETMANA> _dies =
                (from d in ORM.bd.DIES_SETMANA
                 where d.id.Equals(id)
                 orderby d.id
                 select d
                 ).ToList();

            return _dies;

        }
    }
}
