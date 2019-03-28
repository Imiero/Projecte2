using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMCategoriaEdat
    {
        //LINQ

        //Seleccionamos todas las categorias
        public static List<CATEGORIA_EDAT> SelectAllCateogriasEdat()
        {
            List<CATEGORIA_EDAT> _categorias =
                (from c in ORM.bd.CATEGORIA_EDAT
                 orderby c.nom
                 select c
                 ).ToList();

            return _categorias;

        }
    }
}
