using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Payment
{
    public class Reciept
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }

        public int? Amount { get; set; } = 0;
        public int? Balance { get; set;} = 0;
        public int? TotalBalance { get; set;}   
        public string? Currency { get; set; }
        public string? CurrencyCode { get; set;}
        public string? CurrencyName { get; set;}
        public string? CurrencyDescription { get; set;}



    }
}
