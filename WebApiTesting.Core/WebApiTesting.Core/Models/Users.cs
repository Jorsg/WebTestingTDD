using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTesting.Core.Models
{
    public class Users
    {
        public Users(Guid id, string fullname, string email, string age, string country)
        {
            Id = id;
            FullName = fullname;
            Age = age;
            Country = country;
        }

        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }
        public string Country { get; set; }

        public static readonly Users NullUsers = new Users(Guid.Empty, "[not set]", "[not set]", "[not set]", "[not set]");
    }
}
