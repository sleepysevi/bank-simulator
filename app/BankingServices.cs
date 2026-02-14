using System;

namespace ATMApp.Services
{
    public static class BankingService
    {

        public static double GetBalance(double balance)
        {
            return balance;
        }

   
        public static bool Deposit(ref double balance, double amount)
        {
            if (amount > 0)
            {
                balance += amount; 
                return true;  
            }
            return false;  
        }

        public static void Withdraw(ref double balance, double amount, out bool isSuccessful)
        {

            if (amount > 0 && amount <= balance)
            {
                balance -= amount;  
                isSuccessful = true;  
            }
            else
            {
                isSuccessful = false;  
            }
        }

        public static void PrintMiniStatement(string name, double balance, double lastTransaction)
        {

            Console.WriteLine("\n--- Mini Statement ---");
            Console.WriteLine($"Account Holder: {name}");
            Console.WriteLine($"Current Balance: ₱{balance:F2}");
            Console.WriteLine($"Last Transaction Amount: ₱{lastTransaction:F2}");
        }
    }
}
