using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMEntitats
    {
        //LINQ

        public static sant_cugatEntities bd = new sant_cugatEntities();

        //Seleccionar todos las entidades en una List
        public static List<ENTITATS> SelectAllEntitats()
        {
            List<ENTITATS> _entitats =
                (from e in bd.ENTITATS
                 orderby e.nom
                 select e
                 ).ToList();

            return _entitats;
        }
    }
}
