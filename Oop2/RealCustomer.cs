using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class RealCustomer: Customer
    {

        public int Id { get; set; }
        public string CustomerId { get; set; }

        public string IdNo { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
