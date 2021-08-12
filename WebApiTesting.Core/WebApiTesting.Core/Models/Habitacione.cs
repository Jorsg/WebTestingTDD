using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiTesting.Core.Models
{
    public partial class Habitacione
    {
        public int Id { get; set; }
        public int NumHabitacion { get; set; }
        public string Ubicacion { get; set; }
        public int IdHotel { get; set; }
        public bool Habilitar { get; set; }
        public bool? Disponible { get; set; }
        public int IdTipoHabitacion { get; set; }
        public decimal CostoBase { get; set; }
        public decimal Impuesto { get; set; }
        public decimal ValorTotal { get; set; }

        public virtual Hotele IdHotelNavigation { get; set; }
    }
}
