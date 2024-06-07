using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    public abstract class Payment
    {
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? UserLogin { get; set; }
    }
}
