using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    public class YandexMoneyPayment : Payment
    {
        public string? WalletNumber { get; set; }
        public decimal Commission { get; set; }
    }
}
