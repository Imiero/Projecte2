﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu.BD
{
    public class ORMActivitats
    {


        //Seleccionar actividades filtrando la isntalacion
        public static List<ACTIVITATS> SelectActivitatsByInstalacion(int id)
        {

            List<ACTIVITATS> _activitats =
            (from a in ORM.bd.ACTIVITATS
             where a.id_espai.Equals(id)
             select a
             ).ToList();

            return _activitats;
        }

        //nueva actividad

        public static void InsertActividad(int id_actividad_demanada, String nom, int id_tipus_actividad, int id_equip, int id_espai, int id_admin)
        {
            ACTIVITATS actividad = new ACTIVITATS();

            actividad.id_actividad_demanada = id_actividad_demanada;
            actividad.nom = nom;
            actividad.id_tipus_actividad = id_tipus_actividad;
            actividad.id_equip = id_equip;
            actividad.id_espai = id_espai;
            actividad.id_admin = id_admin;
            actividad.ult_modif = DateTime.Now;
            

            ORM.bd.ACTIVITATS.Add(actividad);

            try
            {
                ORM.bd.SaveChanges();
            }
            catch (Exception)
            {

            }
        }


    }
}