﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMAdmins
    {
        //LINQ

      

        //Seleccionar todos los admins en una List
        public static List<ADMINS> SelectAllAdmins()
        {
            List<ADMINS> _admins =
                (from a in ORM.bd.ADMINS
                 orderby a.nombre
                 select a
                 ).ToList();

            return _admins;

        }

    }
}
