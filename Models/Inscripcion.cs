﻿namespace AcademiaBaile.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public int ClaseId { get; set; }
        public DateTime FechaInscripcion { get; set; }
    }

}

