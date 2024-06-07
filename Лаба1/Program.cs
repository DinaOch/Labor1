using System;
namespace Лаба1{
    class Program{
        static void Main(){

List<Payment> payments = new List<Payment>();
payments.Add(new CashPayment { Amount = 1000.00m, PaymentDate = DateTime.Now, UserLogin = "user1", PassportData = "1234 567890" });
payments.Add(new CardPayment { Amount = 2500.00m, PaymentDate = DateTime.Now.AddDays(-7), UserLogin = "user1", CardNumber = "1234 5678 9012 3456", PassportData = "0987 654321" });
payments.Add(new YandexMoneyPayment { Amount = 500.00m, PaymentDate = DateTime.Now.AddDays(-14), UserLogin = "user1", WalletNumber = "12345678", Commission = 10.00m });
payments.Add(new CorporatePayment { Amount = 50000.00m, PaymentDate = DateTime.Now.AddMonths(-1), UserLogin = "user1", BankAccount = "12345678901234", BankId = 12345 });
payments.Add(new CryptoPayment { Amount = 3000.00m, PaymentDate = DateTime.Now.AddDays(-30), UserLogin = "user1", CryptoWalletNumber = "0x1234567890abcdef" });
}
}
    }