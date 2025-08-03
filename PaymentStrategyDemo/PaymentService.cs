using PaymentStrategyDemo.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentStrategyDemo
{
    public class PaymentService
    {
        private readonly IPaymentStrategy _paymentStrategy;
        public PaymentService(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void ProcessPayment(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero.");
            }
            _paymentStrategy.Pay(amount);
        }           
    }
}
