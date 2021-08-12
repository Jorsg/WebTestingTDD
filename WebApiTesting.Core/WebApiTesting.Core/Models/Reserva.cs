using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiTesting.Core.Models
{
    public partial class Reserva
    {
        public int Id { get; set; }
        public int IdHotel { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CantidadPersonas { get; set; }
        public string Ciudad { get; set; }
        public int IdPasajero { get; set; }

        public virtual Hotele IdHotelNavigation { get; set; }
        public virtual Pasajero IdPasajeroNavigation { get; set; }
    }
}
