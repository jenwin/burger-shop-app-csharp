using System;

public class CreditCard {
    public CreditCard() {
        Console.WriteLine("How would you like to pay?");
        Console.WriteLine("Credit Card [A] or Debit Card [B]");
        string payment = Console.ReadLine();
        //credit card payment
        if (!string.IsNullOrWhiteSpace(payment) && payment == "A") {
            Console.WriteLine("Enter your credit card number:");
            string creditString = Console.ReadLine();
            Console.WriteLine("Please confirm payment. Is this correct? [Y]");
            Console.WriteLine("Back to payment options. [C]");
            string confirmCreditPayment = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(confirmCreditPayment) && confirmCreditPayment == "Y") {
                Console.WriteLine("Thank you for your payment. Your order is being processed. We will notify when your order is ready.");
            }

            //back to payment options
            if (!string.IsNullOrWhiteSpace(confirmCreditPayment) && confirmCreditPayment == "C") {
                OptionC c = new OptionC();
            }
        }

        //debit payment
         if (!string.IsNullOrWhiteSpace(payment) && payment == "B") {
                DebitCard debit = new DebitCard();
        }
    }
}