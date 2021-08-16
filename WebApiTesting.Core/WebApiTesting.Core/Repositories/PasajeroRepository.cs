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

        public bool DeletePasajero(Pasajero pasajero)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
