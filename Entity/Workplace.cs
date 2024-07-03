using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Workplace
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string AuthorizedPerson { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
        public virtual ICollection<PropertySale> Sales { get; set; }
    }
}
