using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiTesting.Core.Models
{
    public partial class TipoContacto
    {
        public TipoContacto()
        {
            Pasajeros = new HashSet<Pasajero>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Pasajero> Pasajeros { get; set; }
    }
}
