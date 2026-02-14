public static class BankingView
    {
        public static void Run()
        {
            Console.WriteLine("Jeremy Andy Ampatin");
            Console.WriteLine("=== Simple ATM System ===");

            double balance = 1000.00;
            Console.WriteLine("Initial Balance: P" + balance.ToString("0.00"));

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1: Check Balance");
                Console.WriteLine("2: Deposit Money");
                Console.WriteLine("3: Withdraw Money");
                Console.WriteLine("4: Print Mini Statement");
                Console.WriteLine("5: Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();
                int option;

                if (!int.TryParse(input, out option))
                {
                    Console.WriteLine("Invalid option selected. Please try again.");
                    continue;
                }

                if (option == 1)
                {
                    double current = BankingServices.GetBalance(balance);
                    Console.WriteLine("Current Balance: P" + current.ToString("0.00"));
                }
                else if (option == 2)
                {
                    Console.Write("Enter amount to deposit: ");
                    double amount;

                    if (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                    {
                        Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
                        continue;
                    }

                    bool success = BankingServices.Deposit(ref balance, amount);

                    if (success)
                    {
                        Console.WriteLine("Deposit successful.");
                        Console.WriteLine("Updated Balance: P" + balance.ToString("0.00"));
                    }
                    else
                    {
                        Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
                    }
                }
                else if (option == 3)
                {
                    Console.Write("Enter amount to withdraw: ");
                    double amount;

                    if (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                    {
                        Console.WriteLine("Invalid withdrawal amount. Please enter a positive value.");
                        continue;
                    }

                    bool isSuccessful;
                    BankingServices.Withdraw(ref balance, amount, out isSuccessful);

                    if (isSuccessful)
                    {
                        Console.WriteLine("Withdrawal successful.");
                        Console.WriteLine("Updated Balance: P" + balance.ToString("0.00"));
                    }
                    else
                    {
                        Console.WriteLine("Withdrawal failed. Insufficient balance.");
                    }
                }
                else if (option == 4)
                {
                    string statement = BankingServices.GetMiniStatement(
                        balance,
                        BankingServices.GetLastTransaction()
                    );

                    Console.WriteLine(statement);
                }
                else if (option == 5)
                {
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option selected. Please try again.");
                }
            }
        }
    }
}
