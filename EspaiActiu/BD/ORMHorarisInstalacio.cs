using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMHorarisInstalacio
    {
        //Agregar nuevos horarios a una instalación
        public static void InsertHorarisInstalacio(int id_centre, List<DateTime> Obertures, List<DateTime> tancaments)
        {

            int i = 0;
            foreach ( DateTime Obertura in Obertures)
            {
                HORARIS_INSTALACIO horarisIns = new HORARIS_INSTALACIO();

                horarisIns.dia = byte.Parse((i+1).ToString());
                horarisIns.horari_inici = Obertura.TimeOfDay;
                horarisIns.horari_fi = tancaments[i].TimeOfDay;
                horarisIns.id_centre = id_centre;

                ORM.bd.HORARIS_INSTALACIO.Add(horarisIns);

                try
                {
                    ORM.SaveChanges();
                }
                catch (Exception)
                {
                    //Mirar practica control de errores
                }
                i++;
            }

            

        }
    }
}
