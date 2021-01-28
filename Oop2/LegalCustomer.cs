using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class LegalCustomer: Customer 
    { 

        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string TaxNo { get; set; }
        public string CompanyName { get; set; }
    }
}
