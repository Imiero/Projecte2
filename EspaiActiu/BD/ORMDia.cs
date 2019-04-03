using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMDia
    {
        //Seleccionar dias por id 
        public static DIES_SETMANA SelectDiaByID(int id)
        {

            DIES_SETMANA _dies = ORM.bd.DIES_SETMANA.Find(id);

            return _dies;
        }
    }
}
