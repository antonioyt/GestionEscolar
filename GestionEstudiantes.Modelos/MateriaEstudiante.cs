﻿using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace GestionEstudiantes.Modelos
{
    public class MateriaEstudiante
    {
        public int Id { get; }
        public int IdGrupo { get; private set; }
        public string TarjetaIdentidadEstudiante { get; private set; }
        public float? CalificacionPrimerPeriodo { get; private set; }
        public float? CalificacionSegundoPeriodo { get; private set; }
        public float? CalificacionTercerPeriodo { get; private set; }
        public Estudiante Estudiante { get; private set; }
        public Grupo Grupo { get; private set; }
    }
}