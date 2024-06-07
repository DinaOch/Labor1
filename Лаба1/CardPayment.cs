using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    public class CardPayment : Payment
    {
        public string? CardNumber { get; set; }
        public string? PassportData { get; set; }
    }
}
