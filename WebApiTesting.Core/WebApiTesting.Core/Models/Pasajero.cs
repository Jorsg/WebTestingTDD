using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiTesting.Core.Models
{
    public partial class Pasajero
    {
        public Pasajero()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int Id { get; set; }
        public string NombresCompletos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public string Email { get; set; }
        public string TelefonoContacto { get; set; }
        public int IdTipoContacto { get; set; }

        public virtual TipoContacto IdTipoContactoNavigation { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
