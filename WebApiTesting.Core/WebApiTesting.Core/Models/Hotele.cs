using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiTesting.Core.Models
{
    public partial class Hotele
    {
        public Hotele()
        {
            Habitaciones = new HashSet<Habitacione>();
            Reservas = new HashSet<Reserva>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public bool? Habilitar { get; set; }

        public virtual ICollection<Habitacione> Habitaciones { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
