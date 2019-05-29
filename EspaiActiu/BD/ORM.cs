using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public static class ORM
    {
        public static sant_cugatEntities1 bd = new sant_cugatEntities1();

        public static String MensajesError(SqlException sqlEx)
        {
            String mensaje;
            switch (sqlEx.Number)
            {
                case -1:
                    mensaje = "Error de conexión con el servidor";
                    break;

                case 547:
                    mensaje = "Tiene datos relacionados";
                    break;

                case 2601:
                    mensaje = "Datos duplicados";
                    break;

                case 2627:
                    mensaje = "Datos duplicados";
                    break;

                case 4060:
                    mensaje = "No se encuentra la base de datos";
                    break;

                case 18456:
                    mensaje = "Usuario o contraseña incorrectos";
                    break;

                default:
                    mensaje = sqlEx.Number + " - " + sqlEx.Message;
                    break;
            }

            return mensaje;
        }

        public static void RejectChanges()
        {
            foreach (DbEntityEntry entry in bd.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case System.Data.Entity.EntityState.Modified:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        break;

                    case System.Data.Entity.EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        break;

                    case System.Data.Entity.EntityState.Deleted:
                        entry.Reload();
                        break;



                    default: break;

                }
            }
        }

        public static String SaveChanges()
        {
            String mensaje = "";
            try
            {
                ORM.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                ORM.RejectChanges();
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajesError(sqlEx);

            }

            return mensaje;
        }

    }
}

