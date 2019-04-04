using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMEspai
    {
        //Seleccionar todos los espacios de una instalacion en una greed
     
        public static List<LLOC_DEPORTIVO> SelectAllEspaisById(int id)
        {
            List<LLOC_DEPORTIVO> _espais =
                (from i in ORM.bd.LLOC_DEPORTIVO
                 where i.id_instalacions.Equals(id)
                 orderby i.nom
                 select i).ToList();

            return _espais;
        }
    }
}
