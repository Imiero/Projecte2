using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMCompeticio
    {
        //LINQ

        //Seleccionamos todas las competiciones

        public static List<COMPETICIO> SelectAllCompeticio()
        {
            List<COMPETICIO> _competicions =
                (from c in ORM.bd.COMPETICIO
                 orderby c.nom
                 select c
                 ).ToList();

            return _competicions;

        }
    }
}
