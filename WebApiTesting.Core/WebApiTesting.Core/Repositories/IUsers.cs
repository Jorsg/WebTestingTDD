using System;
using System.Collections.Generic;
using WebApiTesting.Core.Models;

namespace WebApiTesting.Core
{
    public interface IUsers
    {
        IReadOnlyCollection<Users> GetUsers();
        Users GetbyId(Guid id);
        bool Remove(Guid id);
        Users Upsert(Users user);
    }
}
