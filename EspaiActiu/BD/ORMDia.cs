using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMDia
    {
        //Seleccionar todos los admins en una List
        public static List<DIES_SETMANA> SelectAllDies()
        {
            List<DIES_SETMANA> _admins =
                (from d in ORM.bd.DIES_SETMANA
                 orderby d.id
                 select d
                 ).ToList();

            return _admins;

        }
    }
}
