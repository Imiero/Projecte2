using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMCategoria
    {
        //LINQ

        //Seleccionamos todas las categorias
        public static List<CATEGORIA_NIVELL> SelectAllCateogrias()
        {
            List<CATEGORIA_NIVELL> _categorias =
                (from c in ORM.bd.CATEGORIA_NIVELL
                 orderby c.nom
                 select c
                 ).ToList();

            return _categorias;

        }

    }
}
