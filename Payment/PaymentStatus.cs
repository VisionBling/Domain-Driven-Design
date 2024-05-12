using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Payment
{
    public class PaymentStatus
    {
        public PaymentStatus() { }

        public PaymentStatus(int id) { }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }



    }
}
