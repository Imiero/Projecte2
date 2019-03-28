using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMEsports
    {
        //LINQ

        //Seleccionamos todos los deports
        public static List<SPORTS> SelectAllEsports()
        {
            List<SPORTS> _esports =
                (from e in ORM.bd.SPORTS
                 orderby e.nom
                 select e
                 ).ToList();

            return _esports;
        }
    }
}
