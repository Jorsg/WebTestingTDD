using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTesting.Core.Repositories.Interfaces
{
    public interface IReserva
    {
       Task<IEnumerable<Models.Reserva>> GetAll();

       Task<IEnumerable<Models.Reserva>> GetAll(int id);

        void Save();

       Task<int> CreateReserva(Models.Reserva reserva);

       Task<bool> UpdateReserva(Models.Reserva reserva);

       Task<bool> DeleteReserva(int id);
    }
}
