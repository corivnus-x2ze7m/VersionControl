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
        string firstName { get; set; }
        string lastName { get; set; }
        string fullName
        {
            get
            { 
                return string.Format("{0} {1}", lastName, firstName);
            }
        }
    }
}
