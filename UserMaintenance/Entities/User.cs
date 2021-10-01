using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintenance.Entities
{
    class User
    {
        Guid id { get; set; } = Guid.NewGuid();

        public string fullName { get;set;}
    }
}
