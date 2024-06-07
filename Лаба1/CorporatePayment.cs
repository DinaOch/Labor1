using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    public class CorporatePayment : Payment
    {
        public string? BankAccount { get; set; }
        public int BankId { get; set; }
    }
}
