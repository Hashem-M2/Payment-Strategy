# 💳 Payment Strategy Demo

This is a simple demo project to illustrate the **Strategy Design Pattern** using C# and .NET Console App.

## 🧠 What is the Strategy Pattern?

Strategy Pattern is a behavioral design pattern that enables selecting an algorithm's behavior at runtime. It defines a family of algorithms, encapsulates each one, and makes them interchangeable without modifying the context class.

This allows the application to be **Open for Extension** and **Closed for Modification** (OCP from SOLID principles).

## 📦 Project Structure

- `IPaymentStrategy`: Interface for all payment strategies.
- `CardPayment`, `PaypalPayment`, `BankTransferPayment`: Concrete strategies implementing payment logic.
- `PaymentService`: Uses a payment strategy to process the payment without knowing the details of how the payment is done.
- `Program.cs`: Client code that selects a strategy at runtime based on user input.

## 💡 How It Works

User selects a payment method from the console. Based on their choice, the corresponding payment strategy is injected into `PaymentService`, which then processes the payment.

## 🛠 Technologies

- .NET 8
- C#
- Console Application

## 📷 Example

```bash
Enter amount:
100
Choose payment method: 1. Credit Card 2. PayPal 3. Bank Transfer
1
Paid 100 using Credit Card
