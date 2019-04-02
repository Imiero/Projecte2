using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMActivitatsDemandades
    {
        //LINQ



        //Seleccionar todas las peticiones demandadas en una lista
        public static List<ACTIVIDADES_DEMANADAS> SelectAllActvitats()
        {
            List<ACTIVIDADES_DEMANADAS> _actividades =
                (from a in ORM.bd.ACTIVIDADES_DEMANADAS
                 orderby a.nom
                 select a
                 ).ToList();

            return _actividades;

        }

        //Seleccionar todas las actividades demandadas filtrando por el nombre
        public static List<ACTIVIDADES_DEMANADAS> SelectEntitatsByNom(String nom)
        {
            List<ACTIVIDADES_DEMANADAS> _actividades =
                (from a in ORM.bd.ACTIVIDADES_DEMANADAS
                 where a.nom.Contains(nom)
                 orderby a.nom
                 select a).ToList();

            return _actividades;
        }


    }
}
