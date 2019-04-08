using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
                 orderby a.revisada
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

        //Solicitud rechazada, es posa la revisio en True y ya

        public static void SolicitudRechazada(int id)
        {
            ACTIVIDADES_DEMANADAS a = ORM.bd.ACTIVIDADES_DEMANADAS.Find(id);

            a.revisada = true;

            try
            {
                ORM.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                //En caso de estar duplicado no podría crearse y petaria el programa
            }
        }

    }
}
