using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMTipoActividad
    {

        //Seleccionar actividades por id 
        public static TIPUS_ACTIVIDAD SelectTipoActividadByID(int id)
        {

            TIPUS_ACTIVIDAD _Acti = ORM.bd.TIPUS_ACTIVIDAD.Find(id);

            return _Acti;
        }
    }
}
