using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTesting.Core.Models;
using WebApiTesting.Core.Repositories.Interfaces;

namespace WebApiTesting.Core.Repositories
{
    public class PasajeroRepository : IPasajero
    {
        private readonly PruebaContext _context;
        int _id;

        public PasajeroRepository(PruebaContext context)
        {
            _context = context;
        }

        public bool DeletePasajero(int id)
        {
            bool respuesta = false;
            try
            {
                var result = _context.Pasajeros.FirstOrDefault(p => p.Id == id);
                var deletPasajero = _context.Pasajeros.Remove(result);
                Save();
                respuesta = true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                
            }
            return respuesta;            
        }

        public IQueryable<Pasajero> GetAll()
        {
            return _context.Pasajeros;
        }

        public IQueryable<Pasajero> GetAll(int id)
        {
            return _context.Pasajeros.Where(x => x.Id == id);   
        }

        public int InsertPasajero(Pasajero pasajero)
        {
            var pasaj = _context.Pasajeros.Add(pasajero);
            Save();
            return _id = pasaj.Entity.Id;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool UpdatePasajero(Pasajero pasajero)
        {
            bool result = false;
            try
            {
                var upTraveler = _context.Pasajeros.Update(pasajero).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Save();
                result = true;
            }
            catch (Exception)
            {
                throw new ArgumentNullException(nameof(pasajero));
            }
            return result;           
        }

        


    }
}
