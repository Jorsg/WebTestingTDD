using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTesting.Core.Models;
using WebApiTesting.Core.Repositories.Interfaces;

namespace WebApiTesting.Core.Repositories
{
    class ReservaRepository : IReserva
    {
        private readonly PruebaContext _context;

        public ReservaRepository(PruebaContext context)
        {
            _context = context;
        }
        public async Task<int> CreateReserva(Reserva reserva)
        {
            try
            {
                var reserv = await _context.Reservas.AddAsync(reserva);
                Save();
                int id = reserv.Entity.Id;
                return id;
            }
            catch (Exception)
            {
                throw new ArgumentNullException(nameof(reserva));
            }
            
        }

        public async Task<bool> DeleteReserva(int id)
        {
            var result = await _context.Reservas.FirstOrDefaultAsync(x => x.Id == id);
            if(result != null)
                _context.Reservas.Remove(result);
            Save();
            return true;

        }

        public async Task<IEnumerable<Reserva>> GetAll()
        {
            return await _context.Reservas.ToListAsync();            
        }

        public async Task<IEnumerable<Reserva>> GetAll(int id)
        {
            return await _context.Reservas.Where(elm => elm.Id == id).ToListAsync();
        }

        public void Save()
        {
            _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateReserva(Reserva reserva)
        {
            try
            {
                var upReserva = await _context.Reservas.FirstOrDefaultAsync(elm => elm.Id == reserva.Id);
                if (upReserva != null)
                {
                    upReserva.CantidadPersonas = reserva.CantidadPersonas;
                    upReserva.Ciudad = reserva.Ciudad;
                    upReserva.FechaIngreso = reserva.FechaIngreso;
                    upReserva.FechaSalida = reserva.FechaSalida;
                    upReserva.IdHotel = reserva.IdHotel;
                    upReserva.IdPasajero = reserva.IdPasajero;
                    _context.Reservas.Update(upReserva);
                    Save();
                }                
                return true;
            }
            catch (Exception)
            {
                throw new ArgumentNullException(nameof(reserva));
            }
        }
    }
}
