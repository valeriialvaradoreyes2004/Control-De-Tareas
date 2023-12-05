﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeTareas
{
    public class Tarea
    {
        public int TareaId { get; set; }
        public string Nombre { get; set; }
        public int ProyectoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
    }

}
