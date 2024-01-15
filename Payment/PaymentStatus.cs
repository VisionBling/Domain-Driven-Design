using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Payment
{
    public class PayementStatus
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }
        public string Address { get; set; }
       public string City { get; set; }
      public string Region { get; set; }

       public string PostalCode { get; set; }
       public string Country { get; set; }
      public string Phone { get; set; }

       public string Fax { get; set; }
      public string FaxNumber { get; set;}
      public string PhoneNumber { get; set;}
      // public string FaxName { get; set;}
       // public string Email { get; set;}
    }
}
