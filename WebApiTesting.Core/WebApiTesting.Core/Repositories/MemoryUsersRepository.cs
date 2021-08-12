using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTesting.Core.Models;

namespace WebApiTesting.Core.Repositories
{
    public class MemoryUsersRepository : IUsers
    {
        private static readonly ConcurrentDictionary<Guid, Users> _user;

        static MemoryUsersRepository()
        {
            _user = new ConcurrentDictionary<Guid, Users>();
        }

        public Users GetbyId(Guid id)
        {
            return _user.TryGetValue(id, out Users result) ? result : Users.NullUsers;
        }

        public IReadOnlyCollection<Users> GetUsers()
        {
            return ImmutableArray.CreateRange(_user.Values);
        }

        public bool Remove(Guid id)
        {
            return _user.TryRemove(id, out Users _);
        }

        public Users Upsert(Users user)
        {
            if (null == user)
                throw new ArgumentNullException(nameof(user));            

            return _user.AddOrUpdate(user.Id, user, (id, u) => user);
        }
    }
}
