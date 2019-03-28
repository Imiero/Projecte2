using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMSexe
    {
        //LINQ

        //Seleccionamos todas las categorias
        public static List<SEXE> SelectAllSexes()
        {
            List<SEXE> _sexe =
                (from s in ORM.bd.SEXE
                 orderby s.nom
                 select s
                 ).ToList();

            return _sexe;

        }
    }
}
