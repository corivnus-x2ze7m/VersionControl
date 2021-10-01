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
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName
        {
            get
            { 
                return string.Format("{0} {1}", lastName, firstName);
            }
        }
    }
}
