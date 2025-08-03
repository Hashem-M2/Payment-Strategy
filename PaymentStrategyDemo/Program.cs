// See https://aka.ms/new-console-template for more information

using PaymentStrategyDemo;
using PaymentStrategyDemo.Strategies;

Console.WriteLine("Enter amount:");
decimal amount = decimal.Parse(Console.ReadLine());
Console.WriteLine("Choose payment method: 1. Credit Card 2. PayPal 3. Bank Transfer");
int choice = int.Parse(Console.ReadLine());
IPaymentStrategy paymentStrategy;
switch (choice)
{
    case 1:
        paymentStrategy = new CardPayment();
        break;
    case 2:
        paymentStrategy = new PaypalPayment();
        break;
    case 3:
        paymentStrategy = new BankTransferPayment();
        break;
    default:
        throw new ArgumentException("Invalid payment method selected.");
}

PaymentService paymentService = new PaymentService(paymentStrategy);
try
{
    paymentService.ProcessPayment(amount);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}


