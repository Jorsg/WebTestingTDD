using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTesting.Core.Repositories.Interfaces
{
    public interface IPasajero
    {
        IQueryable<Models.Pasajero> GetAll();

        IQueryable<Models.Pasajero> GetAll(int id);

        void Save();

        int InsertPasajero(Models.Pasajero pasajero);

        bool UpdatePasajero(Models.Pasajero pasajero);

        bool DeletePasajero(int id);

    }
}
